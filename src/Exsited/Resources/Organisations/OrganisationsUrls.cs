namespace Exsited.Resources.Organisations;

/// <summary>Path templates and body keys for the v4 organisations endpoints.</summary>
public static class OrganisationsUrls
{
    public const string SettingsOrganisations = "/api/{api_version}/settings/organisations";

    public const string SettingsOrganisation = "/api/{api_version}/settings/organisations/{organisation_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string OrganizationKey = "organization";
}
