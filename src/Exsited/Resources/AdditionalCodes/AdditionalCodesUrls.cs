namespace Exsited.Resources.AdditionalCodes;

/// <summary>Path templates and body keys for the v4 additional codes endpoints.</summary>
public static class AdditionalCodesUrls
{
    public const string SettingsAdditionalCodes = "/api/{api_version}/settings/additional_codes";

    public const string SettingsAdditionalCode = "/api/{api_version}/settings/additional_codes/{additional_code_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string AdditionalCodeKey = "additional_code";
}
