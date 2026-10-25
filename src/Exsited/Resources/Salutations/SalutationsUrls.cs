namespace Exsited.Resources.Salutations;

/// <summary>Path templates and body keys for the v4 salutations endpoints.</summary>
public static class SalutationsUrls
{
    public const string SettingsSalutations = "/api/{api_version}/settings/salutations";

    public const string SettingsSalutation = "/api/{api_version}/settings/salutations/{salutation_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string SalutationKey = "salutation";
}
