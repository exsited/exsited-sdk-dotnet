namespace Exsited.Client;

/// <summary>The request behind a response, redacted at construction and safe to log while held.</summary>
public sealed class RequestInfo
{
    // The snapshots, kept behind getters that copy every buffer they hand out.
    private readonly IReadOnlyDictionary<string, object?> _queryParams;
    private readonly object? _body;

    public RequestInfo(
        string? clientName,
        string? apiVersion,
        string? httpMethod,
        string? url,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        object? body = null,
        IReadOnlyDictionary<string, string>? headers = null,
        int attemptCount = 1,
        int maxAttempts = 1,
        double elapsedSeconds = 0.0,
        string? endpointTemplate = null)
    {
        ClientName = clientName;
        ApiVersion = apiVersion;
        HttpMethod = httpMethod;
        Url = url is null ? null : Redaction.RedactText(url);
        _queryParams = RedactQueryParams(queryParams);
        _body = Redaction.Detach(Redaction.RedactValue(body));
        Headers = Redaction.DetachText(Redaction.RedactMapping(headers)) ?? Redaction.EmptyText;
        AttemptCount = attemptCount;
        MaxAttempts = maxAttempts;
        ElapsedSeconds = elapsedSeconds;
        EndpointTemplate = string.IsNullOrEmpty(endpointTemplate) ? PathOf(Url) : endpointTemplate;
    }

    public string? ClientName { get; }

    public string? ApiVersion { get; }

    public string? HttpMethod { get; }

    public string? Url { get; }

    /// <summary>The query parameters, redacted and recursively immutable.</summary>
    public IReadOnlyDictionary<string, object?> QueryParams =>
        Redaction.CopyBuffersInMap(_queryParams)!;

    /// <summary>The request body, redacted at construction and recursively immutable.</summary>
    public object? Body => Redaction.CopyBuffers(_body);

    public IReadOnlyDictionary<string, string> Headers { get; }

    /// <summary>Which attempt produced the response (1-based).</summary>
    public int AttemptCount { get; }

    public int MaxAttempts { get; }

    public double ElapsedSeconds { get; }

    /// <summary>The <c>{placeholder}</c> path the call named, or the URL's path when none was given.</summary>
    public string EndpointTemplate { get; }

    // A second redaction boundary, read off the snapshots since a render never writes.
    internal IReadOnlyDictionary<string, object?> QueryParamsForDisplay() =>
        RedactQueryParams(_queryParams);

    // Host and query dropped: the path is the most a hand-written call can be named by.
    private static string PathOf(string? url)
    {
        if (string.IsNullOrEmpty(url))
            return "";
        if (Uri.TryCreate(url, UriKind.Absolute, out var parsed))
            return parsed.AbsolutePath;
        var cut = url.IndexOfAny(new[] { '?', '#' });
        return cut < 0 ? url : url[..cut];
    }

    private static IReadOnlyDictionary<string, object?> RedactQueryParams(
        IReadOnlyDictionary<string, object?>? queryParams)
    {
        if (queryParams is null)
            return Redaction.EmptyMap;
        // Detached as a whole, so entries keep the order the query was sent in.
        var shown = new Dictionary<string, object?>();
        foreach (var (key, value) in queryParams)
            shown[key] = Redaction.ShouldRedact(key) ? Redaction.Redacted : Redaction.RedactValue(value);
        return Redaction.DetachMap(shown)!;
    }
}
