namespace Exsited.Resources.ReceiveTerms;

/// <summary>Path templates and body keys for the v4 receive terms endpoints.</summary>
public static class ReceiveTermsUrls
{
    public const string SettingsReceiveTerms = "/api/{api_version}/settings/receive_terms";

    public const string SettingsReceiveTerm = "/api/{api_version}/settings/receive_terms/{receive_term_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ReceiveTermKey = "receive_term";
}
