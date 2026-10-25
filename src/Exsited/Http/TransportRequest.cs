using System.Collections;
using System.Collections.Immutable;
using System.Globalization;
using System.Text;

using Exsited.Client;
using Exsited.Config;
using Exsited.Errors;

using static Exsited.Http.QueryParams;

namespace Exsited.Http;

/// <summary>One request, snapshotted: one wire representation reused by every attempt and replay.</summary>
public sealed class TransportRequest
{
    public TransportRequest(string httpMethod, string url)
    {
        HttpMethod = httpMethod;
        Url = url;
    }

    // The with-headers copy, so a replay after a token refresh cannot send different bytes.
    private TransportRequest(
        TransportRequest source,
        IReadOnlyDictionary<string, string>? headers,
        IReadOnlyDictionary<string, string>? requestInfoHeaders)
    {
        HttpMethod = source.HttpMethod;
        Url = source.Url;
        _queryParams = source._queryParams;
        // Through the property, so both hold the same text rather than each deriving one.
        _urlWithQuery = source.UrlWithQuery;
        _jsonBody = source._jsonBody;
        _jsonBodyBytes = source._jsonBodyBytes;
        _formData = source._formData;
        _formFields = source._formFields;
        _files = source._files;
        _streamOrigins = source._streamOrigins;
        // The same boundary: the replay must frame its parts as the first attempt did.
        _multipartBoundary = source._multipartBoundary;
        // Prepared state travels too, so the replay sends the first attempt's array.
        _prepared = source._prepared;
        _replaySafe = source._replaySafe;
        _wireBody = source._wireBody;
        _wireContentType = source._wireContentType;
        _headers = headers;
        _requestInfoHeaders = requestInfoHeaders;
        _requestInfoBody = source._requestInfoBody;
        ResponseFormat = source.ResponseFormat;
        DtoType = source.DtoType;
        EndpointTemplate = source.EndpointTemplate;
    }

    public string HttpMethod { get; }

    /// <summary>The absolute URL without the query string; see <see cref="UrlWithQuery"/>.</summary>
    public string Url { get; }

    /// <summary>Query parameters, normalised to the text they go out as and held immutably.</summary>
    public IReadOnlyDictionary<string, object?>? QueryParams
    {
        get => _queryParams;
        init => _queryParams = Redaction.DetachMap(
            value is null ? null : (IReadOnlyDictionary<string, object?>)BuildQueryParams(value));
    }

    /// <summary>A JSON body, encoded to its wire bytes as it is set, so it is read exactly once.</summary>
    public object? JsonBody
    {
        get => _jsonBody;
        init
        {
            _jsonBody = value;
            _jsonBodyBytes = Transport.EncodeJsonBody(value);
        }
    }

    // The pre-flight's own encoding handed across, so what was judged is what is sent.
    internal (object? Body, byte[]? Bytes) EncodedJsonBody
    {
        init
        {
            _jsonBody = value.Body;
            _jsonBodyBytes = value.Bytes;
        }
    }

    /// <summary>Form-encoded data, normalised once as it is set; immutable afterwards.</summary>
    public IReadOnlyDictionary<string, object?>? FormData
    {
        get => _formData;
        init
        {
            var (recorded, sent) = NormaliseFormData(value);
            _formData = recorded;
            _formFields = sent;
        }
    }

    /// <summary>Multipart files to send; immutable, with byte parts copied both ways.</summary>
    public IReadOnlyDictionary<string, object?>? Files
    {
        get => Redaction.CopyBuffersInMap(_files);
        init
        {
            _files = Redaction.DetachMap(value);
            _streamOrigins = RecordStreamOrigins(_files);
        }
    }

    // Chosen by PrepareAsync once the part bytes are frozen: it must not appear inside a part.
    internal string? MultipartBoundary => _multipartBoundary;

    /// <summary>The real headers to send; <see cref="RequestInfoHeaders"/> is the redacted copy.</summary>
    public IReadOnlyDictionary<string, string>? Headers
    {
        get => _headers;
        init => _headers = Redaction.DetachText(value);
    }

    public IReadOnlyDictionary<string, string>? RequestInfoHeaders
    {
        get => _requestInfoHeaders;
        init => _requestInfoHeaders = Redaction.DetachText(value);
    }

    /// <summary>An already-redacted body to record on the response's request info.</summary>
    public object? RequestInfoBody
    {
        get => Redaction.CopyBuffers(_requestInfoBody);
        init => _requestInfoBody = Redaction.Detach(Redaction.RedactValue(value));
    }

    /// <summary>Which form <c>Data</c> takes: <c>"map"</c>, <c>"json"</c> or <c>"dto"</c>.</summary>
    public string? ResponseFormat { get; init; }

    public Type? DtoType { get; init; }

    /// <summary>The <c>{placeholder}</c> path the call came from, for the progress line and the request record.</summary>
    public string? EndpointTemplate { get; init; }

    // Only the bearer token changes across a refresh replay.
    internal TransportRequest WithHeaders(
        IReadOnlyDictionary<string, string>? headers,
        IReadOnlyDictionary<string, string>? requestInfoHeaders) =>
        new(this, Redaction.DetachText(headers), Redaction.DetachText(requestInfoHeaders));

    // Copies what the wire needs and settles the body bytes, once; bounded by TimeoutSeconds.
    // Not safe to race: run it on the building thread, before the request is shared.
    internal async Task PrepareAsync(SdkConfig config, string method, CancellationToken cancellationToken)
    {
        if (_prepared)
            return;
        // Before any read: a part the encoder would refuse must not cost a byte of I/O first.
        JudgeFileParts();
        using var deadline = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        deadline.CancelAfter(TimeSpan.FromMilliseconds(config.TimeoutSeconds * 1000));
        try
        {
            // Summed from lengths across all parts, before any copy buffer is allocated.
            JudgeSourceCeiling(config);
            await CopyStreamPartsAsync(config.MaxRequestSpoolBytes, deadline.Token).ConfigureAwait(false);
            // Judged again on the frozen entries that will be framed.
            JudgeFileParts();
            await SettleWireBodyAsync(config, method, deadline.Token).ConfigureAwait(false);
        }
        // The deadline only: a caller's cancellation propagates unwrapped.
        catch (OperationCanceledException error) when (!cancellationToken.IsCancellationRequested)
        {
            throw new SdkError(
                Redaction.RedactMessageText(
                    "the request body could not be assembled within the timeoutSeconds ceiling of "
                    + config.TimeoutSeconds.ToString(CultureInfo.InvariantCulture)
                    + " second(s) - an upload stream did not yield its bytes in time. Nothing was "
                    + "sent"),
                null,
                ErrorType.Timeout,
                null,
                null,
                null,
                error);
        }
        _prepared = true;
    }

    // False only for a stream part too large to copy: its bytes cannot be reproduced.
    internal bool ReplaySafe => _replaySafe;

    // Null when there is no body, and for an unreplayable stream framed from the handle.
    internal byte[]? WireBody => _wireBody;

    internal string? WireContentType => _wireContentType;

    // The encoder's own judgement, so one mistake is described one way.
    private void JudgeFileParts()
    {
        if (_files is null)
            return;
        foreach (var (field, value) in _files)
            if (Transport.ProblemWithFilePart(field, value) is { } problem)
                throw problem;
    }

    // A stream past the ceiling is left alone and clears ReplaySafe.
    private async Task CopyStreamPartsAsync(long ceiling, CancellationToken cancellationToken)
    {
        if (_files is null || _files.Count == 0)
            return;
        var carriesAStream = false;
        foreach (var (_, value) in _files)
            if (value is Stream)
            {
                carriesAStream = true;
                break;
            }
        if (!carriesAStream)
            return;

        var frozen = new List<KeyValuePair<string, object?>>(_files.Count);
        foreach (var (field, value) in _files)
        {
            if (value is not Stream stream)
            {
                frozen.Add(new KeyValuePair<string, object?>(field, value));
                continue;
            }
            // Read off the handle once and never again: the entry below carries it.
            var filename = Transport.StreamPartFilename(field, stream);
            var copied = await CopyOnePartAsync(stream, ceiling, cancellationToken).ConfigureAwait(false);
            if (copied is null)
            {
                _replaySafe = false;
                frozen.Add(new KeyValuePair<string, object?>(field, value));
                continue;
            }
            // The [filename, byte[]] shape, so the encoder needs no arm for a copied stream.
            frozen.Add(new KeyValuePair<string, object?>(
                field, ImmutableArray.Create<object?>(filename, copied)));
        }
        _files = Redaction.DetachedMapOf(frozen);
    }

    // Null when not ownable; a byte past what it offered means its contents are still moving.
    private async Task<byte[]?> CopyOnePartAsync(
        Stream stream, long ceiling, CancellationToken cancellationToken)
    {
        // Backstop to JudgeFileParts. "Not ownable" rather than a read that cannot be undone.
        if (!stream.CanSeek)
            return null;
        var origin = StreamOriginOf(stream);
        stream.Position = origin;
        var offered = Math.Max(0L, stream.Length - origin);
        if (offered > ceiling || offered > Array.MaxLength)
            return null;

        var buffer = new byte[offered];
        var filled = 0;
        while (filled < buffer.Length)
        {
            var read = await stream.ReadAsync(buffer.AsMemory(filled), cancellationToken)
                .ConfigureAwait(false);
            if (read <= 0)
                break; // it had less than it said; the prefix it did give is what was offered
            filled += read;
        }
        var overflow = new byte[1];
        if (await stream.ReadAsync(overflow.AsMemory(0, 1), cancellationToken).ConfigureAwait(false) > 0)
        {
            stream.Position = origin;
            return null;
        }
        return filled == buffer.Length ? buffer : buffer[..filled];
    }

    private async Task SettleWireBodyAsync(
        SdkConfig config, string method, CancellationToken cancellationToken)
    {
        if (_jsonBodyBytes is { } encoded)
        {
            // No framing, so only the final ceiling applies.
            JudgeFinalCeiling(config, encoded.LongLength);
            _wireBody = encoded;
            _wireContentType = Transport.JsonContentType;
            return;
        }
        if (_files is { Count: > 0 })
        {
            // Chosen once, from the frozen parts, for the reason recorded on MultipartBoundary.
            _multipartBoundary = ChooseMultipartBoundary();
            using var multipart = Transport.BuildMultipartContent(this, _multipartBoundary);
            // Computed without writing a byte, so both ceilings apply before anything is materialised.
            var declared = multipart.Headers.ContentLength;
            if (declared is not long framed)
            {
                throw new SdkUsageError(Redaction.RedactMessageText(
                    "files: the multipart body's length could not be computed before it was "
                    + "assembled, so neither maxMultipartOverheadBytes nor maxRequestBytes could "
                    + "be applied to it, and it was not sent"));
            }
            JudgeFramingCeiling(config, framed - _sourceBytes);
            JudgeFinalCeiling(config, framed);
            _wireContentType = multipart.Headers.ContentType?.ToString();
            if (!_replaySafe)
                // Nothing to hold: framed per attempt from the handle, and sent once.
                return;
            if (framed > Array.MaxLength)
                throw RefuseCeiling("the request body", framed, Array.MaxLength,
                    "maxRequestBytes", exact: true);
            // Presized: ReadAsByteArrayAsync grows by doubling, so 16 MiB would cost 48 MiB.
            using var assembled = new MemoryStream((int)framed);
            await multipart.CopyToAsync(assembled, cancellationToken).ConfigureAwait(false);
            // The ceilings were applied to framed, so a different written length is refused.
            if (assembled.Length != framed)
            {
                throw new SdkUsageError(Redaction.RedactMessageText(
                    "files: the multipart body assembled to "
                    + assembled.Length.ToString(CultureInfo.InvariantCulture)
                    + " bytes where its own encoder computed "
                    + framed.ToString(CultureInfo.InvariantCulture)
                    + ", so the ceilings were applied to a length that was not sent. Nothing was "
                    + "sent"));
            }
            // The equality above makes the buffer exactly the body.
            _wireBody = assembled.GetBuffer();
            return;
        }
        if (_formFields is not null)
        {
            // Written with a running total: FormUrlEncodedContent allocates the whole array up front.
            _wireBody = EncodeFormBody(_formFields, config, out var written)
                ?? throw RefuseCeiling("the urlencoded body", written, config.MaxRequestBytes,
                    "maxRequestBytes", exact: false);
            _wireContentType = FormContentType;
            return;
        }
        // Methods that require a body get an empty one, under no content type.
        if (Transport.CarriesABody(method, _jsonBody, _formData, _files))
            _wireBody = Array.Empty<byte>();
    }

    private string ChooseMultipartBoundary() =>
        ChooseMultipartBoundary(Transport.NewMultipartBoundary);

    // Only so the loop terminates: each candidate is 128 random bits.
    private const int MaxBoundaryCandidates = 64;

    private string ChooseMultipartBoundary(Func<string> candidates)
    {
        for (var taken = 0; taken < MaxBoundaryCandidates; taken++)
        {
            var candidate = candidates();
            if (!AppearsInFrozenParts(candidate))
                return candidate;
        }
        throw new SdkUsageError(Redaction.RedactMessageText(
            "files: no multipart delimiter could be chosen that this request's own parts do not "
            + "already contain, after "
            + MaxBoundaryCandidates.ToString(CultureInfo.InvariantCulture)
            + " candidates - a body framed by a delimiter that appears inside it splits somewhere "
            + "the encoder did not intend, so nothing was sent"));
    }

    // Searched as itself, not "--" plus itself: stricter than the wire needs.
    // An uncopied upload stream cannot be searched and rests on the candidate's randomness.
    private bool AppearsInFrozenParts(string candidate)
    {
        if (_formFields is not null)
        {
            foreach (var (name, value) in _formFields)
                if (name.Contains(candidate, StringComparison.Ordinal)
                    || value.Contains(candidate, StringComparison.Ordinal))
                {
                    return true;
                }
        }
        if (_files is null)
            return false;
        var needle = Encoding.UTF8.GetBytes(candidate);
        foreach (var (field, value) in _files)
        {
            if (field.Contains(candidate, StringComparison.Ordinal))
                return true;
            if (PartLabelsContain(field, value, candidate))
                return true;
            if (PartContentContains(value, needle))
                return true;
        }
        return false;
    }

    // The two values besides the part name that reach the part's own header block.
    private static bool PartLabelsContain(string field, object? value, string candidate)
    {
        switch (value)
        {
            case IReadOnlyList<object?> { Count: >= 2 } tuple:
                if (tuple[0] is string filename && filename.Contains(candidate, StringComparison.Ordinal))
                    return true;
                return tuple.Count > 2 && tuple[2] is string declared
                    && declared.Contains(candidate, StringComparison.Ordinal);
            case Stream stream:
                return Transport.StreamPartFilename(field, stream)
                    .Contains(candidate, StringComparison.Ordinal);
            default:
                // A byte[] part is named after its field, which the caller already searched.
                return false;
        }
    }

    // Vectorised span search: the content may be the whole spool ceiling.
    private static bool PartContentContains(object? value, byte[] needle) => value switch
    {
        byte[] bytes => bytes.AsSpan().IndexOf(needle.AsSpan()) >= 0,
        IReadOnlyList<object?> { Count: >= 2 } tuple => tuple[1] switch
        {
            byte[] bytes => bytes.AsSpan().IndexOf(needle.AsSpan()) >= 0,
            string text => text.Contains(Encoding.ASCII.GetString(needle), StringComparison.Ordinal),
            _ => false,
        },
        // The stream this request declined to copy; see AppearsInFrozenParts.
        _ => false,
    };

    // What FormUrlEncodedContent declares, spelled here because this request writes the bytes.
    private const string FormContentType = "application/x-www-form-urlencoded";

    // Lengths only, so the total is known before a byte is copied.
    private void JudgeSourceCeiling(SdkConfig config)
    {
        var source = 0L;
        if (_jsonBodyBytes is { } encoded)
            source = Add(source, encoded.LongLength);
        if (_formFields is not null)
        {
            foreach (var (name, value) in _formFields)
                source = Add(source,
                    Encoding.UTF8.GetByteCount(name) + (long)Encoding.UTF8.GetByteCount(value));
        }
        if (_files is not null)
        {
            foreach (var (_, value) in _files)
                source = Add(source, PartSourceBytes(value));
        }
        if (source > config.MaxRequestSourceBytes)
            throw RefuseCeiling("the payload", source, config.MaxRequestSourceBytes,
                "maxRequestSourceBytes", exact: true);
        _sourceBytes = source;
    }

    private void JudgeFramingCeiling(SdkConfig config, long framing)
    {
        if (framing > config.MaxMultipartOverheadBytes)
            throw RefuseCeiling("the multipart framing", framing, config.MaxMultipartOverheadBytes,
                "maxMultipartOverheadBytes", exact: true);
    }

    private static void JudgeFinalCeiling(SdkConfig config, long body)
    {
        if (body > config.MaxRequestBytes)
            throw RefuseCeiling("the request body", body, config.MaxRequestBytes,
                "maxRequestBytes", exact: true);
    }

    // A shape this SDK cannot send contributes nothing: JudgeFileParts has already refused it.
    private long PartSourceBytes(object? value) => value switch
    {
        byte[] bytes => bytes.LongLength,
        IReadOnlyList<object?> { Count: >= 2 } tuple => tuple[1] switch
        {
            byte[] bytes => bytes.LongLength,
            string text => Encoding.UTF8.GetByteCount(text),
            _ => 0L,
        },
        Stream { CanSeek: true } stream => Math.Max(0L, stream.Length - StreamOriginOf(stream)),
        _ => 0L,
    };

    // Saturating: an overflowed negative total would pass every ceiling.
    private static long Add(long total, long more)
    {
        var sum = unchecked(total + more);
        return sum < total ? long.MaxValue : sum;
    }

    // Sizes and setting names only: the payload is caller data, and this message is logged.
    private static SdkUsageError RefuseCeiling(
        string what, long measured, long ceiling, string setting, bool exact) =>
        new(Redaction.RedactMessageText(
            what + (exact ? " is " : " had already reached ")
            + measured.ToString(CultureInfo.InvariantCulture)
            + " bytes, past the " + ceiling.ToString(CultureInfo.InvariantCulture)
            + "-byte " + setting + " ceiling, so nothing was sent - send less, or raise "
            + setting + " on the client"));

    // Null past MaxRequestBytes, with written how far the count got.
    private static byte[]? EncodeFormBody(
        IReadOnlyDictionary<string, string> fields, SdkConfig config, out long written)
    {
        var ceiling = config.MaxRequestBytes;
        var buffer = new MemoryStream();
        var first = true;
        foreach (var (name, value) in fields)
        {
            if (!first)
                buffer.WriteByte((byte)'&');
            first = false;
            WriteFormToken(buffer, name);
            if (buffer.Length > ceiling)
            {
                written = buffer.Length;
                return null;
            }
            buffer.WriteByte((byte)'=');
            WriteFormToken(buffer, value);
            if (buffer.Length > ceiling)
            {
                written = buffer.Length;
                return null;
            }
        }
        written = buffer.Length;
        return buffer.ToArray();
    }

    // The escaped text is ASCII by construction, so each character is its own byte.
    private static void WriteFormToken(MemoryStream into, string text)
    {
        if (text.Length == 0)
            return;
        var escaped = Uri.EscapeDataString(text).Replace("%20", "+", StringComparison.Ordinal);
        foreach (var character in escaped)
            into.WriteByte((byte)character);
    }

    // Memoised: the query arrives after the URL, and a racing read can only build the same text.
    internal string UrlWithQuery => _urlWithQuery ??= Transport.BuildUrl(Url, _queryParams);

    // Stored snapshots for the wire path, which should not pay the public getters' copies.
    internal IReadOnlyDictionary<string, object?>? QueryParamsAsSent => _queryParams;

    internal IReadOnlyDictionary<string, object?>? FormDataAsSent => _formData;

    // Normalised once when FormData was set, so neither encoder stringifies a value per attempt.
    internal IReadOnlyDictionary<string, string>? FormFieldsAsSent => _formFields;

    internal IReadOnlyDictionary<string, object?>? FilesAsSent => _files;

    internal object? RequestInfoBodyAsRecorded => _requestInfoBody;

    // The position the handle held when Files was set; zero would send more than was offered.
    internal long StreamOriginOf(Stream stream) =>
        _streamOrigins is not null && _streamOrigins.TryGetValue(stream, out var origin) ? origin : 0L;

    // A non-seekable stream is skipped: the encoder refuses it before any I/O.
    private static IReadOnlyDictionary<object, long>? RecordStreamOrigins(
        IReadOnlyDictionary<string, object?>? files)
    {
        if (files is null)
            return null;
        Dictionary<object, long>? origins = null;
        foreach (var (_, value) in files)
            if (value is Stream { CanSeek: true } stream)
                (origins ??= new Dictionary<object, long>(ReferenceEqualityComparer.Instance))[stream] =
                    stream.Position;
        return origins;
    }

    // The immutable record of what was set, and the same fields as the text the encoders write.
    private static (IReadOnlyDictionary<string, object?>? Recorded, IReadOnlyDictionary<string, string>? Sent)
        NormaliseFormData(IReadOnlyDictionary<string, object?>? source)
    {
        if (source is null)
            return (null, null);
        var recorded = new List<KeyValuePair<string, object?>>();
        var sent = new List<KeyValuePair<string, string>>();
        foreach (var (name, value) in source)
        {
            var text = FormFieldText(name, value);
            recorded.Add(new KeyValuePair<string, object?>(name, text));
            sent.Add(new KeyValuePair<string, string>(name, text));
        }
        return (Redaction.DetachedMapOf(recorded), Redaction.DetachedTextOf(sent));
    }

    // A list is refused: a string-keyed map cannot repeat a field, and ToString is a type name.
    private static string FormFieldText(string name, object? value)
    {
        if (value is null)
            return "";   // an unset field travels as the empty value
        if (WireText(value) is { } text)
            return text;
        if (value is IEnumerable)
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"formData '{name}': a form field holds one value, and this map can only name "
                + "each field once, so a list has no form-encoded spelling here. Send the one "
                + "value the field takes, or join the list yourself into the separated string "
                + "the endpoint documents"));
        throw new SdkUsageError(Redaction.RedactMessageText(RefuseValue("formData", name, value)));
    }

    private readonly IReadOnlyDictionary<string, object?>? _queryParams;
    private string? _urlWithQuery;
    private readonly object? _jsonBody;
    private readonly byte[]? _jsonBodyBytes;
    private readonly IReadOnlyDictionary<string, object?>? _formData;
    private readonly IReadOnlyDictionary<string, string>? _formFields;
    // Not readonly: PrepareAsync alone writes these, then latches.
    private IReadOnlyDictionary<string, object?>? _files;
    private string? _multipartBoundary;
    private bool _prepared;
    private bool _replaySafe = true;
    private byte[]? _wireBody;
    private long _sourceBytes;
    private string? _wireContentType;
    private readonly IReadOnlyDictionary<object, long>? _streamOrigins;
    private readonly IReadOnlyDictionary<string, string>? _headers;
    private readonly IReadOnlyDictionary<string, string>? _requestInfoHeaders;
    private readonly object? _requestInfoBody;
}
