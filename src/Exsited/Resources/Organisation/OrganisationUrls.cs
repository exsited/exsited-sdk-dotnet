namespace Exsited.Resources.Organisation;

/// <summary>Path templates and body keys for the v4 organisation endpoints.</summary>
public static class OrganisationUrls
{
    public const string SettingsOrganisation = "/api/{api_version}/settings/organisation";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/organisation</c>.</summary>
    public const string OrganizationKey = "organization";
}
