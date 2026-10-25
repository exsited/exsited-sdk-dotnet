using System.Globalization;

using Exsited.Auth;
using Exsited.Config;
using Exsited.Errors;
using Exsited.Http;

namespace Exsited.Client;

/// <summary>Authenticated access to one Exsited instance: config in, <see cref="ApiResponse"/> out.</summary>
public sealed partial class ExsitedClient : IAsyncDisposable, IDisposable
{
    /// <summary>The SDK's logger name, prefixed to every log line by <see cref="FileLogger"/>.</summary>
    public const string LoggerName = "exsited";

    private const string ApiVersionParam = "api_version";

    /// <summary>The header v4 uses to collapse a repeated create into one; the API refuses a <c>POST</c> without it.</summary>
    public const string IdempotencyHeader = "X-Idempotency-Key";
    // Read independently: a marker under any one of these is a token failure.
    private static readonly string[] TokenFailureKeys = { "code", "error", "message" };

    // The bare word "expired" is absent: it turns up in business rejections the application answers 401 for.
    private static readonly IReadOnlySet<string> TokenFailureMarkers =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[]
        {
            "unauthorized",
            "invalid_access_token",
            "invalid_token",
            "expired_token",
            "invalid_request",
        });

    private readonly SdkConfig _config;
    private readonly Transport _transport;
    // A caller-supplied transport is shared, so only one this client built is disposed with it.
    private readonly bool _ownsTransport;
    private readonly TokenProvider _tokenProvider;
    private readonly Action<string>? _log;
    private readonly FileLogger? _fileLog;
    private readonly int _logThreshold;

    public ExsitedClient(SdkConfig config, Action<string>? onLog = null)
        : this(config, null, null, null, null, onLog)
    {
    }

    /// <summary>Build a client with injected collaborators; a null one is built from the config.</summary>
    public ExsitedClient(
        SdkConfig config,
        ITokenStore? tokenStore,
        Transport? transport,
        RetryPolicy? retryPolicy,
        TokenProvider? tokenProvider,
        Action<string>? onLog = null)
    {
        if (transport is not null && retryPolicy is not null)
            throw new SdkUsageError("pass transport or retryPolicy, not both - an injected "
                + "transport already carries its own policy, so this one would be discarded "
                + "unused; build it into the transport instead, as new Transport(config, "
                + "retryPolicy)");
        if (tokenProvider is not null && tokenStore is not null)
            throw new SdkUsageError("pass tokenProvider or tokenStore, not both - an injected "
                + "token provider already owns the store it reads and writes, so this one would "
                + "be discarded unused; build it into the provider instead, as new "
                + "TokenProvider(config, transport, tokenStore)");
        _config = config;
        _log = onLog;
        _logThreshold = FileLogger.RankOf(config.LogLevel);
        // Attached first and released on any construction failure, so no file handle is left behind.
        _fileLog = FileLogger.Attach(config);
        try
        {
            if (!config.VerifySsl)
                EmitInsecureTransportWarning(InsecureTransportWarning.ForDisabledVerification().Message);
            WarnAboutPlaintextTransport();
            _ownsTransport = transport is null;
            _transport = transport ?? new Transport(config, retryPolicy, ReportProgress);
            var store = tokenStore ?? BuildTokenStore(config);
            _tokenProvider = tokenProvider ?? new TokenProvider(config, _transport, store);
        }
        catch
        {
            _fileLog?.Dispose();
            throw;
        }
    }

    private static ITokenStore BuildTokenStore(SdkConfig config)
    {
        var auth = config.Auth;
        return auth.TokenCachePath is null
            ? new MemoryTokenStore()
            // FileTokenStore is auth and reads its own fixed cap; SdkConfig refuses any other MaxTokenCacheBytes.
            : new FileTokenStore(auth.TokenCachePath, Fingerprint(auth));
    }

    private static readonly IReadOnlySet<string> LoopbackHostnames =
        new HashSet<string> { "localhost", "localhost.localdomain" };

    /// <summary>Warn when the base URL is plain <c>http://</c> to another machine; never thrown.</summary>
    private void WarnAboutPlaintextTransport()
    {
        if (!Uri.TryCreate(_config.BaseUrl, UriKind.Absolute, out var parsed)
            || parsed.Scheme != "http" || IsLoopbackHost(parsed.Host))
            return;
        var warning = new InsecureTransportWarning(parsed.Host);
        EmitInsecureTransportWarning(warning.Message);
    }

    /// <summary>Warn on stderr as well as the log sinks, which shipped defaults leave unattached.</summary>
    private void EmitInsecureTransportWarning(string message)
    {
        if (InsecureTransportWarning.ClaimStandardErrorDelivery(message))
            Console.Error.WriteLine(message);
        EmitLog("WARNING", message);
    }

    private static bool IsLoopbackHost(string? host)
    {
        if (string.IsNullOrEmpty(host))
            return false;
        if (LoopbackHostnames.Contains(host.ToLowerInvariant()))
            return true;
        return System.Net.IPAddress.TryParse(host.Trim('[', ']'), out var address)
            && System.Net.IPAddress.IsLoopback(address);
    }

    private static string Fingerprint(AuthConfig auth) =>
        FileTokenStore.BuildCredentialsNamespace(
            auth.BaseUrl, auth.ClientId, auth.ClientSecret, auth.GrantType);

    /// <summary>Build a client for one instance: null for the first, an <c>int</c> position or a <c>clientName</c>.</summary>
    public static ExsitedClient BuildClient(
        object? instance = null,
        Func<SdkConfig, SdkConfig>? configure = null,
        IEnumerable<object>? credentials = null)
    {
        IEnumerable<object> blocks;
        if (credentials is not null)
        {
            blocks = credentials as IReadOnlyCollection<object> ?? credentials.ToList();
        }
        else
        {
            blocks = ClientRegistry.GetRegisteredInstances();
        }
        var config = SdkConfig.FromCredentials(blocks, instance);
        if (configure is not null)
            config = configure(config)
                ?? throw new SdkUsageError("configure returned null; return the config "
                    + "(or one derived with WithOverrides) instead");
        return new ExsitedClient(config);
    }

    public SdkConfig Config => _config;

    public string Name => _config.ClientName;

    public IReadOnlyList<string> ListResourceNames() =>
        ResourceBinding.RegisteredResourceNames();

    /// <summary>Send one request and return the response; every argument is on the options.</summary>
    public async Task<ApiResponse> SendApiRequestAsync(
        string httpMethod, string path, RequestOptions? options = null, CancellationToken cancellationToken = default)
    {
        RefuseIfClosed();
        var resolvedOptions = options ?? RequestOptions.None;
        // Every check down to the grant runs first, so a mistake costs no OAuth2 round trip.
        var method = Transport.NormaliseMethod(httpMethod);
        ValidatePath(path);
        // The one encoding of the body, so the printout, the curl line and the wire all agree.
        var (jsonBody, jsonBodyBytes) = ValidatePayload(resolvedOptions);
        var responseFormat = ResolveResponseFormat(resolvedOptions.ResponseFormat);

        var resolvedPath = UrlBuilder.SubstitutePathParams(path, SeedApiVersion(path, resolvedOptions.PathParamsAsSent));
        var url = UrlBuilder.BuildUrl(_config.BaseUrl, resolvedPath);
        var queryParams = QueryParams.BuildQueryParams(resolvedOptions.QueryParamsAsSent);
        RejectDuplicatedQueryParams(url, queryParams);

        // One snapshot, reused by the refresh replay, so only the bearer token differs.
        var reportedBody = Redaction.Detach(
            ReportableBody(jsonBody, jsonBodyBytes) ?? resolvedOptions.FormDataAsSent);
        var canonical = new TransportRequest(method, url)
        {
            QueryParams = queryParams,
            EncodedJsonBody = (jsonBody, jsonBodyBytes),
            FormData = resolvedOptions.FormDataAsSent,
            Files = resolvedOptions.FilesAsSent,
            RequestInfoBody = Redaction.RedactValue(
                ExchangeConsole.SummarisePayload(reportedBody, resolvedOptions.FilesAsSent)),
            ResponseFormat = responseFormat,
            DtoType = resolvedOptions.DtoType,
            EndpointTemplate = EndpointTemplateOf(path),
        };
        Transport.CheckAssembledUrl(canonical);
        ValidateCallerHeaders(resolvedOptions.Headers);
        // Once per call, so a retry and the 401 replay collapse into the first create.
        var callerHeaders = WithIdempotencyKey(method, resolvedOptions.Headers);
        RefuseContentHeadersWithNoBody(method, resolvedOptions, jsonBody);
        RefuseContentTypeOnMultipart(resolvedOptions);

        // Still before the grant: upload streams are copied into the request's own storage.
        await canonical.PrepareAsync(_config, method, cancellationToken).ConfigureAwait(false);

        var accessToken = resolvedOptions.Authenticated
            ? await _tokenProvider.GetAccessTokenAsync(cancellationToken).ConfigureAwait(false)
            : null;

        var response = await SendOnceAsync(canonical, resolvedOptions, callerHeaders, accessToken, reportedBody, cancellationToken)
            .ConfigureAwait(false);

        if (resolvedOptions.Authenticated && MeansExpiredToken(response, method))
        {
            if (canonical.ReplaySafe)
            {
                // Reported before the replay, so a 401 -> refresh -> 200 sequence shows the 401 too.
                ReportExchange(response, reportedBody, resolvedOptions, warning: true);
                string fresh;
                try
                {
                    fresh = await _tokenProvider.RefreshAccessTokenAsync(accessToken, cancellationToken).ConfigureAwait(false);
                }
                catch (Exception)
                {
                    // The refused token must not outlive a failed refresh in a cache other processes read.
                    await InvalidateRefusedTokenAsync(accessToken).ConfigureAwait(false);
                    throw;
                }
                response = await SendOnceAsync(canonical, resolvedOptions, callerHeaders, fresh, reportedBody, cancellationToken)
                    .ConfigureAwait(false);
            }
            else
            {
                EmitLog("WARNING", Redaction.RedactMessageText(
                    $"{method} {Redaction.UrlForLog(url)} -> 401 with an expired token, and the "
                    + "request was not replayed: it carries an upload stream larger than "
                    + "maxRequestSpoolBytes, so this SDK does not hold its bytes and cannot send "
                    + "the same request twice"));
                // Not replayed, but the refused token still must not stay in the shared cache.
                await InvalidateRefusedTokenAsync(accessToken).ConfigureAwait(false);
            }
        }
        ReportExchange(response, reportedBody, resolvedOptions, warning: false);

        var shouldRaise = resolvedOptions.RaiseOnError ?? _config.RaiseOnError;
        return shouldRaise ? response.RaiseForStatus() : response;
    }

    /// <summary>Send a <c>GET</c>, with no options. <paramref name="path"/> may be a template.</summary>
    public Task<ApiResponse> SendGetRequestAsync(string path, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("GET", path, null, cancellationToken);

    public Task<ApiResponse> SendGetRequestAsync(string path, RequestOptions? options, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("GET", path, options, cancellationToken);

    public Task<ApiResponse> SendPostRequestAsync(string path, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("POST", path, options, cancellationToken);

    public Task<ApiResponse> SendPutRequestAsync(string path, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("PUT", path, options, cancellationToken);

    public Task<ApiResponse> SendPatchRequestAsync(string path, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("PATCH", path, options, cancellationToken);

    public Task<ApiResponse> SendDeleteRequestAsync(string path, RequestOptions? options = null, CancellationToken cancellationToken = default) =>
        SendApiRequestAsync("DELETE", path, options, cancellationToken);

    // volatile: a client is documented as safe to share across workers.
    private volatile bool _closed;

    /// <summary>Refuse a call on a closed client before a token grant is spent on it.</summary>
    private void RefuseIfClosed()
    {
        if (_closed)
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"client '{_config.ClientName}' is closed: CloseClient() released its log file and "
                + "any connection pool it owned, so this request was not sent - scope it with `await using` "
                + "around the work that needs it, and build a new client rather than reusing a "
                + "closed one"));
    }

    /// <summary>An alias for <see cref="Dispose"/>, not a second teardown path.</summary>
    public void CloseClient() => Dispose();

    /// <summary>Release what this client built; an injected transport is the caller's and stays open.</summary>
    public void Dispose()
    {
        // Set first, so a racing send is refused rather than reaching a half-torn-down transport.
        _closed = true;
        if (_ownsTransport)
            _transport.Dispose();
        _fileLog?.Dispose();
    }

    /// <summary>Release pooled connections; the transport teardown is synchronous.</summary>
    public ValueTask DisposeAsync()
    {
        Dispose();
        return default;
    }

    /// <summary>Drop the token the application just refused, if it is still the cached one; best effort.</summary>
    private async Task InvalidateRefusedTokenAsync(string? refusedAccessToken)
    {
        try
        {
            // CancellationToken.None: a cancelled caller is the case that most needs the cleanup.
            await _tokenProvider.InvalidateAccessTokenAsync(refusedAccessToken, CancellationToken.None)
                .ConfigureAwait(false);
        }
        catch (Exception)
        {
            // Swallowed: the caller is owed the refresh error, not a second one from the filesystem.
        }
    }

    /// <summary>One attempt at the snapshotted request; only the headers differ on a replay.</summary>
    private async Task<ApiResponse> SendOnceAsync(
        TransportRequest canonical, RequestOptions options, IReadOnlyDictionary<string, string>? callerHeaders,
        string? accessToken, object? reportedBody, CancellationToken cancellationToken)
    {
        var headers = BuildRequestHeaders(callerHeaders, accessToken);
        try
        {
            return await _transport.SendHttpRequestAsync(
                    canonical.WithHeaders(headers, Redaction.RedactMapping(headers)), cancellationToken)
                .ConfigureAwait(false);
        }
        catch (SdkError error) when (error.RequestInfo is RequestInfo info)
        {
            // No ApiResponse on a connection failure, so the print is rendered from RequestInfo.
            ReportFailedExchange(info, reportedBody, options);
            throw;
        }
    }

    /// <summary>The caller's headers with a fresh <see cref="IdempotencyHeader"/> on a <c>POST</c>; a caller's own
    /// key, in any spelling, wins, and the caller's map is never changed.</summary>
    internal static IReadOnlyDictionary<string, string>? WithIdempotencyKey(
        string method, IReadOnlyDictionary<string, string>? callerHeaders)
    {
        if (method != "POST")
            return callerHeaders;
        if (callerHeaders is not null
            && callerHeaders.Keys.Any(name => string.Equals(name, IdempotencyHeader, StringComparison.OrdinalIgnoreCase)))
            return callerHeaders;
        var merged = callerHeaders is null
            ? new Dictionary<string, string>()
            : new Dictionary<string, string>(callerHeaders);
        merged[IdempotencyHeader] = Guid.NewGuid().ToString();
        return merged;
    }

    /// <summary>Merge headers case-insensitively; the bearer token is applied last and cannot be displaced.</summary>
    internal Dictionary<string, string> BuildRequestHeaders(
        IReadOnlyDictionary<string, string>? callerHeaders, string? accessToken)
    {
        var canonical = new Dictionary<string, string>(); // lower -> canonical spelling
        var byLowerName = new Dictionary<string, string>(); // lower -> value

        PutHeader(canonical, byLowerName, "Accept", "application/json");
        PutHeader(canonical, byLowerName, "User-Agent", _config.UserAgent);
        foreach (var (name, value) in _config.DefaultHeaders)
            PutHeader(canonical, byLowerName, name, value);
        if (callerHeaders is not null)
            foreach (var (name, value) in callerHeaders)
            {
                ValidateCallerHeader(name, value);
                PutHeader(canonical, byLowerName, name, value);
            }
        if (accessToken is not null)
        {
            byLowerName.Remove("authorization");
            PutHeader(canonical, byLowerName, "Authorization", "Bearer " + accessToken);
        }
        var merged = new Dictionary<string, string>();
        foreach (var (lower, value) in byLowerName)
            merged[canonical[lower]] = value;
        return merged;
    }

    /// <summary>Refuse, before the token grant, a caller header that would inject or be mangled.</summary>
    private static void ValidateCallerHeaders(IReadOnlyDictionary<string, string>? callerHeaders)
    {
        if (callerHeaders is null)
            return;
        foreach (var (name, value) in callerHeaders)
            ValidateCallerHeader(name, value);
    }

    /// <summary>The name is shown, neutralised; the value never is, as it is routinely a credential.</summary>
    private static void ValidateCallerHeader(string name, string value)
    {
        if (Transport.IsSendableHeader(name, value))
            return;
        throw new SdkUsageError(Redaction.RedactMessageText(
            $"headers: '{ExchangeConsole.NeutraliseOneLine(name)}' cannot be sent - "
            + Transport.HeaderGrammar
            + ". The value is not shown: it may be a credential"));
    }

    /// <summary>Refuse a caller's <c>Content-*</c> header on a call that carries no body.</summary>
    private static void RefuseContentHeadersWithNoBody(
        string method, RequestOptions options, object? jsonBody)
    {
        if (options.Headers is null || options.Headers.Count == 0)
            return;
        // The transport's own rule, not a second copy of it.
        if (Transport.CarriesABody(method, jsonBody, options.FormDataAsSent, options.FilesAsSent))
            return;
        var named = options.Headers.Keys
            .Where(Transport.IsContentHeader)
            .OrderBy(name => name, StringComparer.OrdinalIgnoreCase)
            .Select(ExchangeConsole.NeutraliseOneLine)
            .ToList();
        if (named.Count == 0)
            return;
        throw new SdkUsageError(Redaction.RedactMessageText(
            $"headers: {string.Join(", ", named)} describe a body, and this {method} carries none, "
            + "so nothing would be sent under them. Send the body the header describes - jsonBody, "
            + "formData or files - or drop the header; a Content-Type on a request with no content "
            + "has no meaning to the application"));
    }

    /// <summary>Refuse a caller's <c>Content-Type</c> on multipart: it carries the encoder's boundary.</summary>
    private static void RefuseContentTypeOnMultipart(RequestOptions options)
    {
        if (options.FilesAsSent is not { Count: > 0 } || options.Headers is null)
            return;
        var named = options.Headers.Keys
            .Where(name => string.Equals(name, "Content-Type", StringComparison.OrdinalIgnoreCase))
            .Select(ExchangeConsole.NeutraliseOneLine)
            .ToList();
        if (named.Count == 0)
            return;
        throw new SdkUsageError(Redaction.RedactMessageText(
            $"headers: {string.Join(", ", named)} cannot be set on a call that sends files - a "
            + "multipart body's Content-Type carries the boundary its parts are delimited by, "
            + "which this SDK chooses when the request is built, so a replacement would describe "
            + "a framing the body does not have. Drop the header; the encoder sets "
            + "multipart/form-data with the right boundary. To send a body under a content type "
            + "of your own, send it as jsonBody or formData instead of files"));
    }

    private static void PutHeader(
        Dictionary<string, string> canonical, Dictionary<string, string> byLowerName, string name, string value)
    {
        var lower = name.ToLowerInvariant();
        // The SDK's own spellings are restored; a caller's first spelling stands elsewhere.
        if (!canonical.ContainsKey(lower))
            canonical[lower] = name;
        if (lower is "authorization" or "accept" or "user-agent")
            canonical[lower] = lower switch { "authorization" => "Authorization", "accept" => "Accept", _ => "User-Agent" };
        byLowerName[lower] = value;
    }

    /// <summary>The endpoint a call names, slots unfilled and no query: what the progress line prints.</summary>
    private static string EndpointTemplateOf(string path)
    {
        if (Uri.TryCreate(path, UriKind.Absolute, out var parsed))
            return parsed.AbsolutePath;
        var cut = path.IndexOfAny(new[] { '?', '#' });
        return cut < 0 ? path : path[..cut];
    }

    private IReadOnlyDictionary<string, object?> SeedApiVersion(
        string path, IReadOnlyDictionary<string, object?>? pathParams)
    {
        var resolved = pathParams is null
            ? new Dictionary<string, object?>()
            : new Dictionary<string, object?>(pathParams);
        if (UrlBuilder.FindPathParamNames(path).Contains(ApiVersionParam) && !resolved.ContainsKey(ApiVersionParam))
            resolved[ApiVersionParam] = _config.ApiVersion;
        return resolved;
    }

    private static void ValidatePath(string? path)
    {
        if (string.IsNullOrWhiteSpace(path))
            throw new SdkUsageError("path must name an endpoint - an empty path requests the "
                + "application's root, which answers 200 with a web page");
    }

    /// <summary>Refuse an unsendable payload before any I/O; returns the body and its one encoding.</summary>
    private static (object? Body, byte[]? Bytes) ValidatePayload(RequestOptions options)
    {
        if (options.JsonBody is not null && options.FormDataAsSent is not null)
            throw new SdkUsageError("pass jsonBody or formData, not both - they are different "
                + "content types and only one can be sent");
        if (options.JsonBody is not null && options.FilesAsSent is not null)
            throw new SdkUsageError("pass jsonBody or files, not both - a multipart body "
                + "replaces the JSON one, so the JSON would be discarded unsent");
        // After the "not both" checks, so a conflicting pair is reported before a bad part.
        ValidateFiles(options.FilesAsSent);
        ValidateMultipartFieldNames(options);
        if (options.JsonBody is null)
            return (null, null);
        // JSON text, not a value: serialising would make any string a JSON string literal.
        if (options.JsonBody is string jsonText)
        {
            ValidateJsonText(jsonText);
            return (jsonText, Transport.EncodeJsonBody(jsonText));
        }
        // A DTO takes the same checks as its map, so both forms send the same bytes.
        var body = options.JsonBody;
        if (body is Dto payload)
        {
            body = payload.ToMap()
                ?? throw new SdkUsageError(Redaction.RedactMessageText(
                    $"jsonBody: {payload.GetType().Name}.ToMap() returned null; return the "
                    + "payload map, or pass no body at all"));
        }
        // Refused by name: serialising a stream throws from Stream.ReadTimeout.
        if (body is System.IO.Stream)
            throw new SdkUsageError(Redaction.RedactMessageText("jsonBody must be a JSON object or array - got "
                + body.GetType().Name + ". A raw stream cannot be replayed on a "
                + "retry, so read it and pass the value it holds"));
        // The wire bytes; EncodeJsonBody owns the refusal wording.
        var encoded = Transport.EncodeJsonBody(body)!;
        // An allow-list on the bytes: byte[], Uri and TimeSpan all render as bare JSON strings.
        var head = 0;
        while (head < encoded.Length && encoded[head] is 0x20 or 0x09 or 0x0A or 0x0D)
            head++;
        if (head >= encoded.Length || (encoded[head] != (byte)'{' && encoded[head] != (byte)'['))
            throw new SdkUsageError(Redaction.RedactMessageText("jsonBody must be a JSON object or array - got "
                + body.GetType().Name + ", which would be sent as a bare JSON scalar. "
                + "Wrap it in the payload structure the endpoint expects"));
        return (body, encoded);
    }

    /// <summary>The body as the record and printout describe it, read back from the wire bytes.</summary>
    private static object? ReportableBody(object? jsonBody, byte[]? jsonBodyBytes)
    {
        if (jsonBody is null || jsonBodyBytes is null)
            return null;
        if (jsonBody is string)
            return jsonBody;
        try
        {
            using var document = System.Text.Json.JsonDocument.Parse(jsonBodyBytes, Redaction.DeepParse);
            return Redaction.Materialise(document.RootElement);
        }
        catch (System.Text.Json.JsonException)
        {
            // Reached only through a custom converter writing invalid raw JSON; the text is handed on
            // because the redactor withholds what it cannot read.
            return System.Text.Encoding.UTF8.GetString(jsonBodyBytes);
        }
    }

    /// <summary>Settle one call's <c>Data</c> form, refusing an unknown value before any I/O.</summary>
    private string ResolveResponseFormat(string? responseFormat)
    {
        if (responseFormat is null)
            // Already normalised: the config normalises on construction.
            return _config.ResponseFormat;
        var resolved = SdkConfig.NormaliseResponseFormat(responseFormat);
        // A blank per-call value is refused: somebody wrote it, unlike an empty shell variable.
        if (resolved is null || !SdkConfig.IsResponseFormat(resolved))
            throw new SdkUsageError(Redaction.RedactMessageText(
                "responseFormat: expected one of " + string.Join(", ", SdkConfig.ResponseFormatValues)
                + $", got '{ExchangeConsole.NeutraliseOneLine(responseFormat)}'"));
        return resolved;
    }

    /// <summary>Verify raw JSON text holds an object or array; parsed only to verify, never rewritten.</summary>
    private static void ValidateJsonText(string jsonText)
    {
        System.Text.Json.JsonValueKind kind;
        try
        {
            using var parsed = System.Text.Json.JsonDocument.Parse(jsonText, Redaction.DeepParse);
            kind = parsed.RootElement.ValueKind;
        }
        catch (System.Text.Json.JsonException error)
        {
            // The parser's own message names the line and the offset.
            throw new SdkUsageError(Redaction.RedactMessageText(
                "jsonBody: not valid JSON: " + error.Message), error);
        }
        if (kind is System.Text.Json.JsonValueKind.Object or System.Text.Json.JsonValueKind.Array)
            return;
        throw new SdkUsageError(Redaction.RedactMessageText(
            "jsonBody: a JSON string must hold an object or an array, got " + DescribeJsonKind(kind)
            + " - wrap it in the payload structure the endpoint expects"));
    }

    /// <summary>A refused root value named in JSON's vocabulary, since the caller wrote JSON text.</summary>
    private static string DescribeJsonKind(System.Text.Json.JsonValueKind kind) => kind switch
    {
        System.Text.Json.JsonValueKind.String => "a JSON string",
        System.Text.Json.JsonValueKind.Number => "a JSON number",
        System.Text.Json.JsonValueKind.True or System.Text.Json.JsonValueKind.False => "a JSON boolean",
        System.Text.Json.JsonValueKind.Null => "JSON null",
        _ => "a bare JSON value",
    };


    /// <summary>Refuse an unsendable <c>files</c> value by the encoder's own judgement.</summary>
    private static void ValidateFiles(IReadOnlyDictionary<string, object?>? files)
    {
        if (files is null)
            return;
        foreach (var (field, value) in files)
            if (Transport.ProblemWithFilePart(field, value) is { } problem)
                throw problem;
    }

    /// <summary>Refuse a <c>formData</c> name a multipart part could not carry.</summary>
    private static void ValidateMultipartFieldNames(RequestOptions options)
    {
        if (options.FilesAsSent is not { Count: > 0 } || options.FormDataAsSent is null)
            return;
        foreach (var name in options.FormDataAsSent.Keys)
            if (Transport.ProblemWithMultipartFieldName(name) is { } problem)
                throw problem;
    }

    /// <summary>Refuse a query name the URL already carries, as an absolute <c>next_page</c> does.</summary>
    private static void RejectDuplicatedQueryParams(string url, IReadOnlyDictionary<string, object?> queryParams)
    {
        var mark = url.IndexOf('?');
        if (queryParams.Count == 0 || mark < 0)
            return;
        var existing = new HashSet<string>();
        foreach (var chunk in url[(mark + 1)..].Split('&'))
        {
            var equals = chunk.IndexOf('=');
            existing.Add(equals < 0 ? chunk : chunk[..equals]);
        }
        var clash = queryParams.Keys.Where(existing.Contains).OrderBy(key => key, StringComparer.Ordinal).ToList();
        if (clash.Count > 0)
            throw new SdkUsageError(Redaction.RedactMessageText("query params " + string.Join(", ", clash)
                + " already appear in the path's own query string, so each would be sent twice with "
                + "two values and the application chooses - pass them once, in one place"));
    }

    /// <summary>Whether a 401 means the token; this API also answers 401 to a business rejection.</summary>
    internal static bool MeansExpiredToken(ApiResponse response, string method)
    {
        if (response.StatusCode != 401)
            return false;
        // Map, never Data: the caller's response format must not decide staleness.
        if (response.Map is not IReadOnlyDictionary<string, object?> body)
            return !RetryPolicy.IsUnsafeMethod(method);
        foreach (var key in TokenFailureKeys)
            if (IsTokenFailureReason(body.GetValueOrDefault(key)))
                return true;
        return false;
    }

    // Only a string counts, whole or by whole word: "Unauthorized access" matches, a number never does.
    private static bool IsTokenFailureReason(object? value)
    {
        if (value is not string text)
            return false;
        var normalised = text.Trim().ToLowerInvariant();
        if (normalised.Length == 0)
            return false;
        if (TokenFailureMarkers.Contains(normalised))
            return true;
        foreach (var word in normalised.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries))
            if (TokenFailureMarkers.Contains(word))
                return true;
        return false;
    }

    /// <summary>One record to every sink, gated by <c>logLevel</c> first.</summary>
    private void EmitLog(string level, string message)
    {
        if (FileLogger.RankOf(level) < _logThreshold)
            return;
        // A log file read back in a terminal is still a terminal, and a bare newline forges a record.
        var safe = ExchangeConsole.NeutraliseOneLine(message);
        _log?.Invoke(level + " " + safe);
        _fileLog?.Log(level, safe);
    }

    /// <summary>Redact and serialise a body for a <c>logBodies</c> record; ToString is a type name.</summary>
    private static string RenderForLog(object? body)
    {
        var redacted = Redaction.RedactValue(body);
        if (redacted is null)
            return "";
        if (redacted is string text)
            return text;
        if (redacted is byte[] bytes)
            return $"<{bytes.Length.ToString(CultureInfo.InvariantCulture)} bytes>";
        try
        {
            return System.Text.Json.JsonSerializer.Serialize(redacted, Redaction.DisplayJson);
        }
        catch (Exception error) when (error is System.Text.Json.JsonException or NotSupportedException)
        {
            return Convert.ToString(redacted, CultureInfo.InvariantCulture) ?? "";
        }
    }

    private void ReportProgress(string message)
    {
        if (_config.PrintApiInfo && !_config.PrintOnlyOnError)
            Console.WriteLine(message);
        EmitLog("INFO", message);
    }

    /// <summary>Print and log a send that got no response, whatever <c>printOnlyOnError</c> says.</summary>
    private void ReportFailedExchange(RequestInfo info, object? reportedBody, RequestOptions options)
    {
        if (WantsPrint())
            Console.WriteLine(ExchangeConsole.RenderFailedExchange(
                info, reportedBody, _config, options.FilesAsSent, IsFormEncoded(options)));
        EmitLog("ERROR",
            $"{info.HttpMethod} {Redaction.UrlForLog(info.Url)} -> {ExchangeConsole.NoResponseStatus} in "
            + $"{Display.Seconds(info.ElapsedSeconds)}s "
            + $"(attempt {info.AttemptCount}/{info.MaxAttempts})");
        if (_config.LogBodies)
            EmitLog("DEBUG", $"payload={RenderForLog(reportedBody)} response=");
    }

    private bool WantsPrint() =>
        _config.PrintApiInfo || _config.PrintRequestPayload
        || _config.PrintResponseBody || _config.PrintHeaders || _config.PrintCurl;

    /// <summary>Whether the body went as form data; the curl line cannot tell from the headers.</summary>
    private static bool IsFormEncoded(RequestOptions options) =>
        options.JsonBody is null && options.FormDataAsSent is not null;

    private void ReportExchange(ApiResponse response, object? reportedBody, RequestOptions options, bool warning)
    {
        // Gated on a request record: a diagnostic must not fail on a hand-built ApiResponse.
        var info = response.RequestInfo;
        if (info is not null && WantsPrint() && !(_config.PrintOnlyOnError && response.Succeeded))
            Console.WriteLine(ExchangeConsole.RenderExchange(
                response, reportedBody, _config, options.FilesAsSent, IsFormEncoded(options)));

        if (info is not null)
            EmitLog(warning ? "WARNING" : "INFO",
                // Invariant: a log record is grepped, so the decimal point must not move.
                $"{info.HttpMethod} {Redaction.UrlForLog(info.Url)} -> {response.StatusCode} in "
                + $"{Display.Seconds(info.ElapsedSeconds)}s "
                + $"(attempt {info.AttemptCount}/{info.MaxAttempts})");
        // Outside the record guard: the bodies do not come from it.
        if (_config.LogBodies)
            EmitLog("DEBUG",
                $"payload={RenderForLog(reportedBody)} response={RenderForLog(response.Map)}");
    }
}
