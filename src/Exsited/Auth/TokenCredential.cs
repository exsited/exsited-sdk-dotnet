using System.Text.Json;
using System.Text.RegularExpressions;

using Exsited.Errors;

namespace Exsited.Auth;

/// <summary>
/// The two grammars a token credential has to satisfy, and the one place either is judged.
///
/// <para>They are <b>different grammars, deliberately</b>, not one relaxed for the other. An
/// access token becomes the value after <c>Bearer</c> in an <c>Authorization</c> header, so it
/// must be an RFC 6750 section 2.1 <c>b64token</c>. A refresh token is a field of a token
/// request, RFC 6749 section 5.1 with Appendix A.17 <c>1*VSCHAR</c>, which keeps punctuation
/// Bearer has no room for; checking it against the Bearer grammar would refuse values the
/// standard allows and the server issued.</para>
///
/// <para>Both are <b>validated, never coerced</b>: a JSON number turned into decimal text would
/// be a Bearer credential no server ever issued. Nothing here converts, and a
/// <see cref="JsonElement"/> is refused by type rather than read for its raw text, which for a
/// number is that decimal string.</para>
/// </summary>
public static partial class TokenCredential
{
    // Written out rather than assembled from \w, which is Unicode-aware in .NET and would
    // accept a Cyrillic lookalike.
    [GeneratedRegex(@"^[A-Za-z0-9\-._~+/]+=*$")]
    private static partial Regex BearerCredential();

    [GeneratedRegex(@"^[\x20-\x7e]+$")]
    private static partial Regex RefreshCredential();

    /// <summary>Whether this value can be put in an <c>Authorization: Bearer</c> header as it
    /// stands: text, and RFC 6750 section 2.1 <c>b64token</c>.</summary>
    /// <example>
    /// <code>
    /// TokenCredential.IsAccessCredential("abc.123_x~y+z/w==");  // true
    /// TokenCredential.IsAccessCredential(1234567890);           // false - a number is not a token
    /// </code>
    /// </example>
    public static bool IsAccessCredential(object? value) =>
        value is string text && text.Length > 0 && BearerCredential().IsMatch(text);

    /// <summary>Whether this value can be sent as the <c>refresh_token</c> field of a token
    /// request: text, and RFC 6749 section 5.1 visible ASCII.</summary>
    public static bool IsRefreshCredential(object? value) =>
        value is string text && text.Length > 0 && RefreshCredential().IsMatch(text);

    /// <summary>Check a credential that will be put in an <c>Authorization: Bearer</c> header.
    /// The value itself is never shown: it is a credential, and this message reaches a log.</summary>
    /// <param name="value">the value as the token response or the cache carried it.</param>
    /// <returns>the value unchanged, so this reads as a conversion at a call site.</returns>
    /// <exception cref="SdkUsageError">it is not text, or not that grammar.</exception>
    public static string CheckAccessCredential(object? value)
    {
        if (value is not string text)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "access_token: expected the credential as text, got "
                + (value is null ? "null" : value.GetType().Name)
                + ". A token is not converted from another type: what would be sent is that "
                + "type's rendering, which is not a credential"));
        if (!IsAccessCredential(text))
            throw new SdkUsageError(
                "access_token: is not a Bearer credential. RFC 6750 allows letters, digits and "
                + "- . _ ~ + / with optional = padding at the end, and this SDK puts the value "
                + "straight into an Authorization header; the value itself is not shown");
        return text;
    }

    /// <summary>Check a credential that will be sent as a field of a token request.</summary>
    /// <param name="value">the value as the token response or the cache carried it.</param>
    /// <returns>the value unchanged.</returns>
    /// <exception cref="SdkUsageError">it is not text, or carries something outside RFC 6749
    /// section 5.1's visible range. The value itself is never shown.</exception>
    public static string CheckRefreshCredential(object? value)
    {
        if (value is not string text)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "refresh_token: expected the credential as text, got "
                + (value is null ? "null" : value.GetType().Name)));
        if (!IsRefreshCredential(text))
            throw new SdkUsageError(
                "refresh_token: is not a token-response value. RFC 6749 allows the visible "
                + "ASCII range and a space, and this one carries something outside it - a "
                + "control character, or a character with no defined encoding on this request; "
                + "the value itself is not shown");
        return text;
    }
}
