using System.Collections;
using System.Text;
using System.Text.Json;

using Exsited.Errors;

namespace Exsited.Client;

/// <summary>What every SDK call returns: one HTTP exchange, what was sent and what came back.</summary>
public sealed class ApiResponse
{
    private const int MaxReportedMessages = 50;

    private const int MaxMessageDepth = 4;

    /// <summary>Build a response from an already-redacted request and a normalised format.</summary>
    public ApiResponse(
        int statusCode,
        object? data,
        IReadOnlyDictionary<string, string>? headers,
        string? contentType,
        RequestInfo? requestInfo,
        ErrorType errorType = ErrorType.None,
        byte[]? rawBody = null,
        string? responseFormat = null,
        Type? dtoType = null)
    {
        StatusCode = statusCode;
        Map = data;
        Headers = Redaction.DetachText(headers) ?? Redaction.EmptyText;
        ContentType = contentType;
        _rawBody = rawBody;
        ResponseFormat = responseFormat ?? Config.SdkConfig.ResponseFormatMap;
        _dtoType = dtoType;
        // Gated on Succeeded, which reads StatusCode and Map, both assigned above.
        ErrorType = errorType == ErrorType.None && !Succeeded
            ? ErrorTypes.Classify(statusCode, BodyDeniesSuccess(Map))
            : errorType;
        RequestInfo = requestInfo;
        // Built after every field they read; ExecutionAndPublication runs each factory once.
        _json = new Lazy<string?>(RenderBodyText, LazyThreadSafetyMode.ExecutionAndPublication);
        _dto = new Lazy<object?>(BuildDto, LazyThreadSafetyMode.ExecutionAndPublication);
    }

    public int StatusCode { get; }

    /// <summary>The body in the resolved <see cref="ResponseFormat"/>, or <c>null</c> when it has none.</summary>
    public object? Data => ResponseFormat switch
    {
        Config.SdkConfig.ResponseFormatJson => Json,
        Config.SdkConfig.ResponseFormatDto => Dto,
        // Only a hand-built response reaches here: the client refuses an unknown format.
        _ => Map,
    };

    /// <summary>The decoded body: map or list for JSON, string for <c>text/*</c>, bytes otherwise.</summary>
    public object? Map { get; }

    /// <summary>The server's own body text as it arrived; <c>null</c> for a binary or empty body.</summary>
    public string? Json => _json.Value;

    /// <summary>The typed view of the body; <see cref="Map"/> holds the whole body.</summary>
    public object? Dto => _dto.Value;

    /// <summary>Which form <see cref="Data"/> took: <c>map</c>, <c>json</c> or <c>dto</c>.</summary>
    public string ResponseFormat { get; }

    /// <summary>The body's own bytes for <see cref="Json"/>; a binary body shares Map's array.</summary>
    private readonly byte[]? _rawBody;

    private readonly Type? _dtoType;
    private readonly Lazy<string?> _json;
    private readonly Lazy<object?> _dto;

    /// <summary>The body as text; a <c>text/*</c> body keeps its declared-charset decoding.</summary>
    private string? RenderBodyText()
    {
        if (Map is byte[])
            return null;
        if (Map is string decoded)
            return decoded;
        if (_rawBody is null || _rawBody.Length == 0)
            return null;
        return Encoding.UTF8.GetString(_rawBody);
    }

    /// <summary>The DTO the endpoint named, or <c>null</c> when the body is not a record or the call failed.</summary>
    // Succeeded gates it: an error envelope built into the named type reads as a record of nulls.
    private object? BuildDto() =>
        _dtoType is null || !Succeeded
            || Map is not IReadOnlyDictionary<string, object?> envelope
            ? null
            // Qualified: the simple name resolves to this class's own Dto property first.
            : Exsited.Dto.Build(_dtoType, envelope);

    /// <summary>The response headers, immutable; names compare ordinally, as the application spelled them.</summary>
    public IReadOnlyDictionary<string, string> Headers { get; }

    public string? ContentType { get; }

    public ErrorType ErrorType { get; }

    public RequestInfo? RequestInfo { get; }

    /// <summary>A 2xx status and a body that does not name itself <c>"object": "error"</c>, which a 200 can carry.</summary>
    public bool Succeeded => StatusCode is >= 200 and < 300 && !BodyDeniesSuccess(Map);

    /// <summary>The key every v4 body names itself with, and the only one allowed to contradict a 2xx status.</summary>
    private const string ObjectKey = "object";

    private const string ErrorObject = "error";

    /// <summary>An explicit <c>object == "error"</c> self-description; a message's presence denies nothing.</summary>
    private static bool BodyDeniesSuccess(object? data)
    {
        // The second arm covers a mapping of another shape, such as a hand-built response.
        object? name = data switch
        {
            IReadOnlyDictionary<string, object?> body => body.GetValueOrDefault(ObjectKey),
            IDictionary raw => raw.Contains(ObjectKey) ? raw[ObjectKey] : null,
            _ => null,
        };
        return name is string described
            && string.Equals(described.Trim(), ErrorObject, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>Human-readable problems from an error body, most specific tier first, capped.</summary>
    public IReadOnlyList<string> GetErrorMessages()
    {
        // Map, never Data: the caller's chosen format must not change what a failure says.
        var body = Map;
        if (!IsMapping(body))
            body = ParseJsonBody(body);
        if (body is not IReadOnlyDictionary<string, object?> envelope)
            return Array.Empty<string>();

        var messages = ReadErrorEntries(Get(envelope, "errors"));
        if (messages.Count == 0)
            messages = ReadMessageValue(Get(envelope, "message"), 0);
        if (messages.Count == 0)
        {
            // `code` first: v4's own key, reached only with no `errors` and no `message`.
            messages = ReadMessageValue(Get(envelope, "code"), 0);
            if (messages.Count == 0)
                messages = ReadMessageValue(Get(envelope, "error"), 0);
            if (messages.Count == 0)
                messages = ReadMessageValue(Get(envelope, "errorCode"), 0);
        }
        if (messages.Count == 0)
        {
            // RFC 7807, reached only when an intermediary rather than the application answers the error.
            messages = ReadMessageValue(Get(envelope, "detail"), 0);
            if (messages.Count == 0)
                messages = ReadMessageValue(Get(envelope, "title"), 0);
        }
        return CapMessages(messages);
    }

    /// <summary>Throw when the call failed, otherwise return this response for chaining.</summary>
    public ApiResponse RaiseForStatus()
    {
        if (Succeeded)
            return this;
        // Everything reachable from the exception is scrubbed: the application echoes back what it could not read.
        var messages = GetErrorMessages();
        var summary = messages.Count == 0 ? $"HTTP {StatusCode}" : messages[0];
        var redactedBody = Redaction.RedactValue(Map);
        var redactedHeaders = Redaction.RedactMapping(Headers);
        SdkError error = StatusCode is 401 or 403
            ? new SdkAuthError(Redaction.RedactMessageText(summary), StatusCode, ErrorType, redactedBody, redactedHeaders, RequestInfo)
            : new SdkError(Redaction.RedactMessageText(summary), StatusCode, ErrorType, redactedBody, redactedHeaders, RequestInfo);
        foreach (var message in messages)
            error.AddError(Redaction.RedactMessageText(message));
        throw error;
    }

    private static object? ParseJsonBody(object? body)
    {
        string text = body switch
        {
            byte[] bytes => Encoding.UTF8.GetString(bytes),
            string decoded => decoded,
            _ => "",
        };
        if (text.Length == 0)
            return null;
        // The BOM goes before the guard too, or a BOM'd body fails the '{' test.
        text = text.Trim().TrimStart('\uFEFF').Trim();
        if (!text.StartsWith('{') && !text.StartsWith('['))
            return null; // an XLSX export or a PNG never reaches the parser
        try
        {
            using var document = JsonDocument.Parse(text);
            return Redaction.Materialise(document.RootElement);
        }
        catch (JsonException)
        {
            return null;
        }
    }

    /// <summary>Read the <c>errors</c> tier, whichever of its three shapes arrived.</summary>
    private static List<string> ReadErrorEntries(object? entries)
    {
        var messages = new List<string>();
        if (entries is IReadOnlyDictionary<string, object?> byField)
        {
            foreach (var (field, value) in byField)
                PrefixField(field, ReadMessageValue(value, 0), messages);
            return messages;
        }
        if (IsSequence(entries, out var list))
        {
            foreach (var entry in list)
            {
                if (entry is IReadOnlyDictionary<string, object?> item)
                {
                    var text = Get(item, "message") ?? Get(item, "code");
                    PrefixField(Get(item, "field"), ReadMessageValue(text, 0), messages);
                }
                else
                {
                    messages.AddRange(ReadMessageValue(entry, 0));
                }
            }
            return messages;
        }
        if (entries is string single)
            return ReadMessageValue(single, 0);
        return messages;
    }

    /// <summary>Turn any value from an error body into messages; blanks dropped, depth-guarded.</summary>
    private static List<string> ReadMessageValue(object? value, int depth)
    {
        if (value is null || depth > MaxMessageDepth)
            return new List<string>();
        if (value is string message)
            return message.Trim().Length == 0
                ? new List<string>()
                : new List<string> { message };
        if (value is IReadOnlyDictionary<string, object?> nested)
        {
            var text = Get(nested, "message") ?? Get(nested, "code");
            return ReadMessageValue(text, depth + 1);
        }
        if (IsSequence(value, out var list))
        {
            var messages = new List<string>();
            foreach (var item in list)
                messages.AddRange(ReadMessageValue(item, depth + 1));
            return messages;
        }
        var scalar = Convert.ToString(value, System.Globalization.CultureInfo.InvariantCulture) ?? "";
        return scalar.Trim().Length == 0 ? new List<string>() : new List<string> { scalar };
    }

    /// <summary>Prefix each message with its field, tested for presence: a bulk import's row 0 is real.</summary>
    private static void PrefixField(object? fieldName, List<string> fieldMessages, List<string> output)
    {
        var name = fieldName is null
            ? ""
            : (Convert.ToString(fieldName, System.Globalization.CultureInfo.InvariantCulture) ?? "").Trim();
        foreach (var message in fieldMessages)
            output.Add(name.Length == 0 ? message : $"{name}: {message}");
    }

    private static IReadOnlyList<string> CapMessages(List<string> messages)
    {
        if (messages.Count <= MaxReportedMessages)
            return messages;
        var capped = messages.GetRange(0, MaxReportedMessages);
        capped.Add($"+{messages.Count - MaxReportedMessages} more problems");
        return capped;
    }

    private static object? Get(IReadOnlyDictionary<string, object?> map, string key) =>
        map.TryGetValue(key, out var value) ? value : null;

    private static bool IsMapping(object? value) => value is IReadOnlyDictionary<string, object?>;

    // A JSON array (List<object?>) but never a string, which is also IEnumerable.
    private static bool IsSequence(object? value, out IEnumerable<object?> sequence)
    {
        if (value is not string && value is IEnumerable raw)
        {
            sequence = raw.Cast<object?>();
            return true;
        }
        sequence = Array.Empty<object?>();
        return false;
    }
}
