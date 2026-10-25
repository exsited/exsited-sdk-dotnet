using Exsited.Errors;

namespace Exsited.Config;

/// <summary>
/// Who you are and which instance you are talking to; how the SDK <i>behaves</i> is
/// <see cref="SdkConfig"/>. Immutable and validated at construction, with every problem
/// reported at once, and <see cref="ClientSecret"/> is redacted
/// by <see cref="ToString"/>, so an instance is safe to log.
///
/// <para>A sealed class with a validating constructor rather than a <c>record</c>, and the type
/// that explains why for all of them: a record's <c>with</c> expression mints an instance
/// nobody validated, and its synthesised <c>ToString</c> prints both secrets.</para>
/// </summary>
public sealed class AuthConfig
{
    /// <summary>The implicit name of a credentials mapping block that declares no
    /// <c>clientName</c> key. Not a constructor default: an <see cref="AuthConfig"/> built in
    /// code has to say which instance it is.</summary>
    public const string DefaultClientName = "default";

    /// <summary>The only grant type Exsited's token endpoint accepts.</summary>
    public const string DefaultGrantType = "client_credentials";

    /// <summary>
    /// The default for <c>tokenCachePath</c>. <see cref="TokenCachePath"/> is three-way: this
    /// sentinel resolves the platform's per-user cache directory, <c>null</c> keeps the token in
    /// memory, and any other string is that file. The NUL wrapping makes the sentinel
    /// unreachable by accident.
    ///
    /// <example>
    /// <code>
    /// new AuthConfig(..., tokenCachePath: AuthConfig.UseDefaultTokenCache); // platform path
    /// new AuthConfig(..., tokenCachePath: null);                            // memory only
    /// new AuthConfig(..., tokenCachePath: "/var/cache/exsited/token.json");      // that file
    /// </code>
    /// </example>
    /// </summary>
    public const string UseDefaultTokenCache = "\0__EXSITED_USE_DEFAULT_TOKEN_CACHE__\0";

    // "Not supplied" for WithOverrides, which needs a marker distinct from both null (memory
    // only) and UseDefaultTokenCache (the platform path). Private, so it never becomes
    // something a caller can pass.
    private const string KeepTokenCachePath = "\0__EXSITED_KEEP_TOKEN_CACHE_PATH__\0";

    // Name paired with its reader, so the public name list below and the validation loop
    // cannot drift apart: adding a field here adds it to both.
    private static readonly (string Name, Func<AuthConfig, string> Read)[] RequiredFieldReaders =
    {
        ("baseUrl", self => self.BaseUrl),
        ("clientId", self => self.ClientId),
        ("clientSecret", self => self.ClientSecret),
        ("redirectUri", self => self.RedirectUri),
    };

    /// <summary>The credentials that must be present and non-blank, in declaration order so the
    /// batched report reads top to bottom, spelled as the .NET parameter names.</summary>
    public static readonly IReadOnlyList<string> RequiredFields =
        Array.ConvertAll(RequiredFieldReaders, field => field.Name);

    /// <summary>Construct and validate; every problem is reported in one exception.
    /// <c>clientName</c> is required; <c>tokenCachePath</c> is three-way (see
    /// <see cref="UseDefaultTokenCache"/>) and its sentinel is resolved to a real path
    /// <b>after</b> validation, so a config with no credentials leaves no cache directory
    /// behind.</summary>
    public AuthConfig(
        string baseUrl,
        string clientId,
        string clientSecret,
        string redirectUri,
        string clientName,
        string grantType = DefaultGrantType,
        string? tokenCachePath = UseDefaultTokenCache)
    {
        BaseUrl = NormaliseBaseUrl(baseUrl);
        ClientId = clientId;
        ClientSecret = clientSecret;
        RedirectUri = redirectUri;
        ClientName = clientName;
        GrantType = grantType;

        Validate(tokenCachePath);

        TokenCachePath = tokenCachePath == UseDefaultTokenCache
            ? ResolveDefaultTokenCachePath(clientName)
            : tokenCachePath;
    }

    private static string ResolveDefaultTokenCachePath(string clientName)
    {
        try
        {
            return Auth.FileTokenStore.BuildDefaultTokenCachePath();
        }
        catch (SdkConfigError error)
        {
            // Relabelled so the report names the instance, as every other refusal from this
            // constructor does.
            throw new SdkConfigError(Redaction.RedactMessageText(
                $"instance {clientName}: tokenCachePath: {error.Message}"), error);
        }
    }

    /// <summary>The instance origin, trailing slashes stripped.</summary>
    public string BaseUrl { get; }

    /// <summary>The OAuth client id.</summary>
    public string ClientId { get; }

    /// <summary>The OAuth client secret; redacted by <see cref="ToString"/>.</summary>
    public string ClientSecret { get; }

    /// <summary>The registered redirect URI.</summary>
    public string RedirectUri { get; }


    /// <summary>Required label for this instance: shown in logs and printed output, and how the
    /// instance is selected by name.</summary>
    public string ClientName { get; }

    /// <summary>The OAuth grant type.</summary>
    public string GrantType { get; }

    /// <summary>The token cache file, already resolved: the platform per-user path for
    /// <see cref="UseDefaultTokenCache"/>, the caller's path when one was given, and
    /// <c>null</c> for memory only.</summary>
    public string? TokenCachePath { get; }

    /// <summary>Derive a new set of credentials from this one, back through the validating
    /// constructor; this instance is untouched. <c>null</c> means "not supplied" for every field
    /// but the cache path, where it is one of three meanings, so leaving
    /// <paramref name="tokenCachePath"/> out keeps the current value.</summary>
    public AuthConfig WithOverrides(
        string? baseUrl = null,
        string? clientId = null,
        string? clientSecret = null,
        string? redirectUri = null,
        string? clientName = null,
        string? grantType = null,
        string? tokenCachePath = KeepTokenCachePath)
    {
        return new AuthConfig(
            baseUrl ?? BaseUrl,
            clientId ?? ClientId,
            clientSecret ?? ClientSecret,
            redirectUri ?? RedirectUri,
            clientName ?? ClientName,
            grantType ?? GrantType,
            tokenCachePath == KeepTokenCachePath ? TokenCachePath : tokenCachePath);
    }

    /// <summary>Credentials redacted, so safe to log. The two secrets are masked by name and
    /// every other text field passes through <see cref="Redaction.RedactText"/>, so a secret
    /// embedded in a value is rewritten too.</summary>
    public override string ToString()
    {
        // Driven from Redaction.RedactFields, so what counts as a secret is decided by
        // ShouldRedact rather than by which fields this method happens to hard-code.
        var shown = Redaction.RedactFields(this, FieldOrder);
        return $"AuthConfig({string.Join(", ", shown)})";
    }

    /// <summary>The token cache file this SDK writes, aliased here because a caller configuring
    /// a cache path reads this class first.</summary>
    public const string DefaultTokenCacheFilename = Auth.FileTokenStore.DefaultTokenCacheFilename;

    /// <summary>The fields <see cref="ToString"/> renders, in order; every one is listed, so a
    /// field added later cannot be silently left out.</summary>
    private static readonly string[] FieldOrder =
    {
        nameof(BaseUrl), nameof(ClientId), nameof(ClientSecret), nameof(RedirectUri),
        nameof(ClientName), nameof(GrantType), nameof(TokenCachePath),
    };

    private void Validate(string? tokenCachePath)
    {
        var problems = new List<string>();

        // One line naming every missing credential rather than one line each, so the reader
        // fixes them in one pass.
        var missing = new List<string>();
        foreach (var (name, read) in RequiredFieldReaders)
        {
            if (IsBlank(read(this)))
                missing.Add(name);
        }
        if (missing.Count > 0)
            problems.Add("missing required values: " + string.Join(", ", missing));

        if (!IsBlank(BaseUrl))
            problems.AddRange(ProblemsWithTheBaseUrl(BaseUrl));

        if (IsBlank(ClientName))
            problems.Add("clientName: must not be blank");
        if (IsBlank(GrantType))
            problems.Add("grantType: must not be blank");

        if (tokenCachePath is not null && tokenCachePath != UseDefaultTokenCache)
        {
            if (IsBlank(tokenCachePath))
                // A blank path is how an unset environment variable arrives: refused rather
                // than silently read as memory-only.
                problems.Add("tokenCachePath: must not be blank - pass null to keep the token "
                    + "in memory, or name the file to write");
            else if (Directory.Exists(tokenCachePath))
                // Truthy-looking, so the file store would be chosen and every write would
                // then fail: one authentication per call.
                problems.Add($"tokenCachePath: '{tokenCachePath}' is an existing directory, so "
                    + "nothing could be written to it - name the file to write, or pass null to "
                    + "keep the token in memory");
        }

        if (problems.Count > 0)
        {
            // Trimmed, not just blank-checked: a whitespace-only name would label the report
            // "instance    :".
            var label = IsBlank(ClientName) ? "<unnamed>" : ClientName.Trim();
            throw new SdkConfigError(Redaction.RedactMessageText($"instance {label}: " + string.Join("; ", problems)));
        }
    }

    private static string NormaliseBaseUrl(string? raw)
    {
        if (raw is null) return "";
        return raw.Trim().TrimEnd('/');
    }

    /// <summary>Every way a syntactically-present base URL is still unusable, batched.</summary>
    private static List<string> ProblemsWithTheBaseUrl(string baseUrl)
    {
        var problems = new List<string>();
        if (!Uri.TryCreate(baseUrl, UriKind.Absolute, out var parsed))
        {
            problems.Add($"baseUrl: is not a URL, got '{baseUrl}'");
            return problems;
        }

        var scheme = parsed.Scheme.ToLowerInvariant();
        if ((scheme != "http" && scheme != "https") || string.IsNullOrEmpty(parsed.Host))
        {
            problems.Add("baseUrl: must start with http:// or https:// and include a host, "
                + $"got '{baseUrl}'");
            return problems;
        }
        if (!string.IsNullOrEmpty(parsed.UserInfo))
            // The HTTP layer would turn userinfo into a Basic header that replaces the bearer
            // token. The value is not echoed: it holds a password.
            problems.Add($"baseUrl: host {parsed.Host} carries embedded credentials, which would "
                + "replace the bearer token; strip the userinfo");
        // A query string or a fragment only. Paths are appended by concatenation, so anything
        // after the host puts the path inside the query and every call 404s. An RFC 3986 path
        // parameter (`https://host/store;jsessionid=1`) is deliberately not refused: it is a
        // legal path segment and the application treats it as one.
        if (!string.IsNullOrEmpty(parsed.Query) || !string.IsNullOrEmpty(parsed.Fragment))
            problems.Add("baseUrl: must be the instance origin only, with no query string or "
                + $"fragment, got '{baseUrl}'");
        return problems;
    }

    private static bool IsBlank(string? value) => string.IsNullOrEmpty(value?.Trim());
}
