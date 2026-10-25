
namespace Exsited.Auth;

/// <summary>
/// An access token and when it stops being usable. The stored mapping is the on-disk cache
/// format - <c>{access_token, refresh_token, expires_at (epoch seconds, double),
/// skew_seconds}</c> - so changing a key or a type orphans every cache file already written. A
/// sealed class with a redacting <see cref="ToString"/>, not a <c>record</c>; see
/// <see cref="Config.AuthConfig"/>.
/// </summary>
public sealed class TokenRecord
{
    /// <summary>Assumed lifetime when the token endpoint gives none.</summary>
    public const double DefaultTokenTtlSeconds = 3600;

    /// <summary>How early a token is treated as expired, by default.</summary>
    public const double ExpirySkewSeconds = 60;

    /// <summary>
    /// The furthest ahead a cached expiry is believed, one day: the stamp is another machine's
    /// clock, and further ahead than any accepted lifetime means refresh rather than believe it.
    /// </summary>
    public const double MaxTokenTtlSeconds = 24 * 60 * 60;

    /// <summary>Construct a record; callers usually go through <see cref="FromMap"/>.
    ///
    /// <para>Both credentials are checked against their own grammar here - see
    /// <see cref="TokenCredential"/> - because this constructor is the one door into a record,
    /// and a value that cannot be a Bearer credential must not become one further down where
    /// the only report is a 401 from the application.</para></summary>
    /// <exception cref="Errors.SdkUsageError">either credential fails its grammar.</exception>
    public TokenRecord(string accessToken, string? refreshToken, double expiresAt, double skewSeconds)
    {
        AccessToken = TokenCredential.CheckAccessCredential(accessToken);
        RefreshToken = refreshToken is null ? null : TokenCredential.CheckRefreshCredential(refreshToken);
        ExpiresAt = expiresAt;
        SkewSeconds = skewSeconds;
    }

    /// <summary>The bearer token.</summary>
    public string AccessToken { get; }

    /// <summary>The refresh token, or <c>null</c>.</summary>
    public string? RefreshToken { get; }

    /// <summary>Epoch seconds when the token expires.</summary>
    public double ExpiresAt { get; }

    /// <summary>How early to treat it as expired; carried per record, because one standing skew
    /// cannot suit every lifetime.</summary>
    public double SkewSeconds { get; }

    /// <summary>
    /// Whether the token should be treated as expired. The skew expires it early on purpose:
    /// two seconds left passes a naive check and then fails in flight.
    /// </summary>
    public bool NeedsRefresh()
    {
        var now = UnixSecondsNow();
        if (ExpiresAt - now > MaxTokenTtlSeconds)
            return true; // a wild clock's stamp is not believed
        return now >= ExpiresAt - SkewSeconds;
    }

    /// <summary>The plain mapping a token store persists.</summary>
    public IReadOnlyDictionary<string, object?> ToMap() => new Dictionary<string, object?>
    {
        ["access_token"] = AccessToken,
        ["refresh_token"] = RefreshToken,
        ["expires_at"] = ExpiresAt,
        ["skew_seconds"] = SkewSeconds,
    };

    /// <summary>
    /// Rebuild from a stored mapping; <c>null</c> when absent or malformed, so a hand-edited or
    /// corrupt cache costs one extra authentication rather than an exception. A non-string
    /// token, a non-numeric or non-finite expiry (NaN would make every comparison in
    /// <see cref="NeedsRefresh"/> false, a token fresh forever) and a boolean-typed skew are
    /// all rejected.
    ///
    /// <para>The cache is also where <b>either credential's grammar</b> is checked a second
    /// time, on the way in rather than only on the way out of a grant. The file is a
    /// well-known per-user path: whatever wrote it last decides what is read, and a value that
    /// is not a Bearer credential must not reach an <c>Authorization</c> header just because it
    /// arrived from disk instead of from the application. A refused credential reads as no cached
    /// token, which costs one authentication.</para>
    /// </summary>
    public static TokenRecord? FromMap(IReadOnlyDictionary<string, object?>? record)
    {
        if (record is null)
            return null;
        var accessToken = Get(record, "access_token");
        var expiresAt = FiniteNumber(Get(record, "expires_at"));
        if (accessToken is not string token || token.Length == 0 || expiresAt is null)
            return null;
        // Grammar, not merely "is a string": see TokenCredential. Checked before the
        // constructor, which throws, because a corrupt cache is an ordinary state here.
        if (!TokenCredential.IsAccessCredential(token))
            return null;
        var skew = FiniteNumber(Get(record, "skew_seconds"));
        if (skew is null || skew < 0)
            skew = ExpirySkewSeconds;
        // Cap a hostile cached skew at the max token TTL: a larger one would make
        // NeedsRefresh() always true.
        skew = Math.Min(skew.Value, MaxTokenTtlSeconds);
        var refresh = Get(record, "refresh_token");
        // A refresh credential that fails its own grammar drops out rather than taking the
        // whole record with it: the access token is still usable, and the next renewal falls
        // back to the full credentials grant.
        return new TokenRecord(
            token,
            TokenCredential.IsRefreshCredential(refresh) ? (string)refresh! : null,
            expiresAt.Value,
            skew.Value);
    }

    /// <summary>
    /// Both tokens redacted; a refresh token outlives the access token by a long way. An absent
    /// refresh token renders as an unquoted <c>null</c>, because <c>'null'</c> would read as a
    /// token whose value is the text "null".
    /// </summary>
    public override string ToString() =>
        $"TokenRecord(accessToken='{Redaction.Redacted}'"
        + $", refreshToken={(RefreshToken is null ? "null" : $"'{Redaction.Redacted}'")}"
        + $", expiresAt={ExpiresAt}, skewSeconds={SkewSeconds})";

    private static object? Get(IReadOnlyDictionary<string, object?> record, string key) =>
        record.TryGetValue(key, out var value) ? value : null;

    private static double? FiniteNumber(object? value)
    {
        // Boolean first: true would read as a 1-second value.
        if (value is bool || value is null)
            return null;
        double number;
        switch (value)
        {
            case double doubleValue: number = doubleValue; break;
            case float floatValue: number = floatValue; break;
            case long longValue: number = longValue; break;
            case int intValue: number = intValue; break;
            case short shortValue: number = shortValue; break;
            case decimal decimalValue: number = (double)decimalValue; break;
            default: return null;
        }
        return double.IsNaN(number) || double.IsInfinity(number) ? null : number;
    }

    private static double UnixSecondsNow() =>
        DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000.0;
}
