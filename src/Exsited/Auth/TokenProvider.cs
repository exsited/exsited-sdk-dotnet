using System.Globalization;

using Exsited.Client;
using Exsited.Config;
using Exsited.Errors;
using Exsited.Http;

namespace Exsited.Auth;

/// <summary>
/// Fetches, caches and renews the access token. The Exsited token endpoint answers
/// <b>201 Created</b>, so success means any 2xx; it issues a refresh token and honours the
/// <c>refresh_token</c> grant, so a renewal tries that first and falls back to a full
/// <c>client_credentials</c> request.
///
/// <para>Concurrency is double-checked locking: the store's refresh scope is both the
/// in-process and the cross-process lock, and the store is re-read inside it, so a worker that
/// waited usually finds a fresh token. The substitution seam is the <see cref="ITokenStore"/>
/// and the transport, both injectable, so there is no interface over the provider itself.</para>
///
/// <example>
/// <code>
/// using var transport = new Transport(config);
/// var provider = new TokenProvider(config, transport, new MemoryTokenStore());
/// var bearer = await provider.GetAccessTokenAsync();
/// </code>
/// </example>
/// </summary>
public sealed class TokenProvider
{
    /// <summary>
    /// The token endpoint path, <c>/api/v4/oauth2/token</c>. The refresh grant uses the same path.
    /// </summary>
    public const string TokenPath = "/api/v4/oauth2/token";

    /// <summary>The token endpoint path. Takes the resource version and returns
    /// <see cref="TokenPath"/> whatever it is.</summary>
    /// <param name="apiVersion">the resource version, which does not move this path.</param>
    /// <example>
    /// <code>
    /// TokenProvider.BuildTokenPath("v4");  // "/api/v4/oauth2/token"
    /// </code>
    /// </example>
    public static string BuildTokenPath(string apiVersion) => TokenPath;

    private const string RefreshGrantType = "refresh_token";

    private readonly SdkConfig _config;
    private readonly Transport _transport;
    private readonly ITokenStore _tokenStore;
    private readonly string _tokenPath;

    /// <summary>Build a provider; <paramref name="tokenPath"/> overrides the default endpoint path.</summary>
    public TokenProvider(SdkConfig config, Transport transport, ITokenStore tokenStore, string? tokenPath = null)
    {
        _config = config;
        _transport = transport;
        _tokenStore = tokenStore;
        _tokenPath = tokenPath ?? BuildTokenPath(config.ApiVersion ?? SdkConfig.DefaultApiVersion);
    }

    /// <summary>The absolute token endpoint URL.</summary>
    public string TokenUrl => _config.BaseUrl + _tokenPath;

    /// <summary>A usable access token, fetching one only if needed and good for at least the
    /// configured skew.</summary>
    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken = default)
    {
        var record = TokenRecord.FromMap(await _tokenStore.ReadTokenRecordAsync(cancellationToken).ConfigureAwait(false));
        if (record is not null && !record.NeedsRefresh())
            return record.AccessToken;
        return await RenewAccessTokenAsync(null, anyCachedTokenWillDo: true, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>Replace a token the API has just rejected; a different cached token means
    /// another worker already renewed, and that one is returned instead of a second grant.
    /// <c>staleAccessToken</c> may be <c>null</c>.</summary>
    /// <returns>a token that is not <paramref name="staleAccessToken"/>.</returns>
    public Task<string> RefreshAccessTokenAsync(string? staleAccessToken, CancellationToken cancellationToken = default) =>
        RenewAccessTokenAsync(staleAccessToken, anyCachedTokenWillDo: false, cancellationToken);

    /// <summary>Discard the cached token, forcing a fetch on the next call.</summary>
    public Task ClearAccessTokenAsync(CancellationToken cancellationToken = default) =>
        _tokenStore.ClearTokenRecordAsync(cancellationToken);

    /// <summary>Discard the cached token <b>only if it is still exactly
    /// <paramref name="deadAccessToken"/></b>: the compare-and-clear a caller needs after the
    /// application has refused a token and the replacement grant then failed.
    ///
    /// <para><b>Why not a bare clear.</b> The token cache is shared - a file, by default, read
    /// by every process on the machine using these credentials - and between the 401 arriving
    /// here and this call running, another worker may already have minted a good token and
    /// written it. A bare clear would throw that one away, and on these credentials a grant
    /// invalidates the token before it, so the discarded worker's next call 401s, clears again,
    /// and grants again: a herd of grants each killing the last. Reading the record under the
    /// same lock a refresh takes and clearing only on an exact match makes that impossible.</para>
    ///
    /// <para>The token is compared, never logged, printed or returned.</para></summary>
    /// <param name="deadAccessToken">the token the API refused; <c>null</c> or blank is a no-op.</param>
    /// <param name="cancellationToken">cancels waiting on the refresh lock and the store's own I/O.</param>
    /// <returns><c>true</c> when the cached token was this one and has been cleared;
    /// <c>false</c> when there was nothing to clear or the cache had moved on.</returns>
    public async Task<bool> InvalidateAccessTokenAsync(
        string? deadAccessToken, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(deadAccessToken))
            return false;
        // The refresh lock, not a bare read: without it the read-compare-clear straddles
        // another worker's write and clears a token that was never the dead one.
        await using var scope = await _tokenStore.AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);
        var record = TokenRecord.FromMap(await scope.ReadTokenRecordAsync(cancellationToken).ConfigureAwait(false));
        // Ordinal: a credential is a byte string, and a culture-aware comparison could call two
        // different tokens equal.
        if (record is null || !string.Equals(record.AccessToken, deadAccessToken, StringComparison.Ordinal))
            return false;
        await scope.ClearTokenRecordAsync(cancellationToken).ConfigureAwait(false);
        return true;
    }

    private async Task<string> RenewAccessTokenAsync(
        string? staleAccessToken, bool anyCachedTokenWillDo, CancellationToken cancellationToken)
    {
        await using var scope = await _tokenStore.AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);

        var record = TokenRecord.FromMap(await scope.ReadTokenRecordAsync(cancellationToken).ConfigureAwait(false));
        if (record is not null && !record.NeedsRefresh())
        {
            // Any fresh token answers GetAccessToken; a refresh is replacing a token the API
            // rejected, so it accepts only a different one.
            if (anyCachedTokenWillDo
                || (staleAccessToken is not null && record.AccessToken != staleAccessToken))
            {
                return record.AccessToken;
            }
        }

        TokenRecord? renewed = null;
        if (record?.RefreshToken is not null)
            renewed = await RequestTokenWithRefreshGrantAsync(record.RefreshToken, cancellationToken).ConfigureAwait(false);
        renewed ??= await RequestTokenWithCredentialsAsync(cancellationToken).ConfigureAwait(false);

        try
        {
            await scope.WriteTokenRecordAsync(renewed.ToMap(), cancellationToken).ConfigureAwait(false);
        }
        catch (Exception)
        {
            // Caching is best effort: a token already paid for is not discarded because the
            // filesystem refused the write.
        }
        return renewed.AccessToken;
    }

    private async Task<TokenRecord> RequestTokenWithCredentialsAsync(CancellationToken cancellationToken)
    {
        var response = await _transport.SendHttpRequestAsync(
            new TransportRequest("POST", TokenUrl)
            {
                JsonBody = CredentialsPayload(),
                Headers = TokenHeaders(),
            },
            cancellationToken).ConfigureAwait(false);

        if (RefusedWithSignInPage(response) is { } refusal)
        {
            throw new SdkAuthError(
                refusal,
                response.StatusCode,
                response.ErrorType,
                Redaction.RedactValue(response.Map),
                Redaction.RedactMapping(response.Headers),
                response.RequestInfo);
        }
        if (!response.Succeeded)
        {
            var messages = response.GetErrorMessages();
            var error = new SdkAuthError(Redaction.RedactMessageText(
                // The application's own words go in raw and the whole message is redacted below:
                // this is the one request carrying the client secret, so the application rejecting it
                // by echoing what it received is echoing the secret.
                $"token request failed with {response.StatusCode}: "
                    + (messages.Count == 0 ? "no detail" : messages[0])),
                response.StatusCode,
                response.ErrorType,
                // Redacted here so the credentials this request carried can never ride out on
                // the error.
                Redaction.RedactValue(response.Map),
                Redaction.RedactMapping(response.Headers),
                response.RequestInfo);
            foreach (var message in messages)
                error.AddError(Redaction.RedactMessageText(message));
            throw error;
        }
        return BuildTokenRecord(response, null);
    }

    private const string RefusedCredentialsMessage =
        "the token request was refused: check ClientId, ClientSecret and RedirectUri ";

    /// <summary>The message for a token request the API refused by sending the caller to its
    /// sign-in page instead of answering 401: a 3xx, or, through a handler that follows
    /// redirects, a success status carrying an HTML page. <c>null</c> for any other answer.
    /// The Location is never quoted, because its query string can carry what was sent.</summary>
    private static string? RefusedWithSignInPage(ApiResponse response)
    {
        var status = response.StatusCode.ToString(CultureInfo.InvariantCulture);
        if (response.StatusCode is >= 300 and < 400)
            return RefusedCredentialsMessage + $"(the API answered {status}, redirecting to its sign-in page)";
        if (response.StatusCode is >= 200 and < 300
            && response.Map is string
            && response.ContentType?.Contains("html", StringComparison.OrdinalIgnoreCase) == true)
            return RefusedCredentialsMessage + $"(the API answered {status} with its sign-in page, not a token)";
        return null;
    }

    private Dictionary<string, object?> CredentialsPayload() => new()
    {
        ["grant_type"] = _config.Auth.GrantType,
        ["redirect_uri"] = _config.Auth.RedirectUri,
        ["client_id"] = _config.Auth.ClientId,
        ["client_secret"] = _config.Auth.ClientSecret,
    };

    /// <summary>The cheap grant; any failure falls back to full credentials, never propagates.</summary>
    private async Task<TokenRecord?> RequestTokenWithRefreshGrantAsync(
        string refreshToken, CancellationToken cancellationToken)
    {
        var payload = new Dictionary<string, object?>
        {
            ["grant_type"] = RefreshGrantType,
            ["refresh_token"] = refreshToken,
            ["redirect_uri"] = _config.Auth.RedirectUri,
            ["client_id"] = _config.Auth.ClientId,
            ["client_secret"] = _config.Auth.ClientSecret,
        };
        try
        {
            var response = await _transport.SendHttpRequestAsync(
                new TransportRequest("POST", TokenUrl) { JsonBody = payload, Headers = TokenHeaders() },
                cancellationToken).ConfigureAwait(false);
            return response.Succeeded ? BuildTokenRecord(response, refreshToken) : null;
        }
        catch (Exception)
        {
            return null;
        }
    }

    private Dictionary<string, string> TokenHeaders() => new()
    {
        ["Content-Type"] = "application/json",
        ["Accept"] = "application/json",
        ["User-Agent"] = _config.UserAgent,
    };

    /// <summary>Decode one token response into a record, <b>validating</b> both credentials
    /// against their own grammar rather than converting either.
    ///
    /// <para>A JSON number under <c>access_token</c> is refused as a type: rendered to decimal
    /// text it would be a Bearer credential no server ever issued. The two grammars are
    /// different on purpose: see <see cref="TokenCredential"/>.</para></summary>
    private static TokenRecord BuildTokenRecord(ApiResponse response, string? previousRefreshToken)
    {
        if (response.Map is not IReadOnlyDictionary<string, object?> envelope
            || envelope.GetValueOrDefault("access_token") is not string token
            || token.Length == 0)
        {
            throw new SdkAuthError(
                "token response did not contain an access_token",
                response.StatusCode, response.ErrorType,
                Redaction.RedactValue(response.Map), new Dictionary<string, string>(), response.RequestInfo);
        }
        // Ahead of the record's own check, so the application answering with something that is not a
        // Bearer credential reads as an authentication failure rather than a usage error.
        if (!TokenCredential.IsAccessCredential(token))
        {
            throw new SdkAuthError(
                "the token response's access_token is not a Bearer credential. RFC 6750 allows "
                + "letters, digits and - . _ ~ + / with optional = padding at the end, and this "
                + "SDK puts the value straight into an Authorization header; the value itself "
                + "is not shown",
                response.StatusCode, response.ErrorType,
                Redaction.RedactValue(response.Map), new Dictionary<string, string>(), response.RequestInfo);
        }
        var timeToLiveSeconds = ReadTtlSeconds(envelope.GetValueOrDefault("expires_in"));
        var refresh = envelope.GetValueOrDefault("refresh_token");
        return new TokenRecord(
            token,
            // RFC 6749 6: answered with only an access token, the server means keep the
            // refresh token already held. A value that is present and fails the refresh
            // grammar is treated the same way, because a credential this SDK cannot send is
            // not a credential it was given.
            TokenCredential.IsRefreshCredential(refresh) ? (string)refresh! : previousRefreshToken,
            UnixSecondsNow() + timeToLiveSeconds,
            // A lifetime shorter than the standing skew would leave no usable window.
            Math.Min(TokenRecord.ExpirySkewSeconds, timeToLiveSeconds / 2));
    }

    /// <summary>NaN, infinity, non-positive and unparseable lifetimes all take the default.</summary>
    private static double ReadTtlSeconds(object? expiresIn)
    {
        var timeToLiveSeconds = TokenRecord.DefaultTokenTtlSeconds;
        switch (expiresIn)
        {
            case double doubleValue: timeToLiveSeconds = doubleValue; break;
            case long longValue: timeToLiveSeconds = longValue; break;
            case int intValue: timeToLiveSeconds = intValue; break;
            case decimal decimalValue: timeToLiveSeconds = (double)decimalValue; break;
            // The body decoder materialises an integer literal wider than Int64 as a
            // BigInteger, so without this arm a huge `expires_in` silently takes the default
            // while the same value quoted as a string clamps to the ceiling. Compared rather
            // than cast: the BigInteger -> double conversion throws past double's range.
            case System.Numerics.BigInteger bigValue:
                timeToLiveSeconds =
                    bigValue > new System.Numerics.BigInteger(TokenRecord.MaxTokenTtlSeconds)
                        ? TokenRecord.MaxTokenTtlSeconds
                        : bigValue <= System.Numerics.BigInteger.Zero
                            ? 0.0
                            : (double)bigValue;
                break;
            case string text when double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var parsed):
                timeToLiveSeconds = parsed; break;
        }
        if (double.IsNaN(timeToLiveSeconds) || double.IsInfinity(timeToLiveSeconds) || timeToLiveSeconds <= 0)
            timeToLiveSeconds = TokenRecord.DefaultTokenTtlSeconds;
        return Math.Min(timeToLiveSeconds, TokenRecord.MaxTokenTtlSeconds);
    }

    private static double UnixSecondsNow() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000.0;
}
