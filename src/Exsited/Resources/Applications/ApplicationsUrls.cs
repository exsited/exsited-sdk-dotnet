namespace Exsited.Resources.Applications;

/// <summary>Path templates and body keys for the v4 applications endpoints.</summary>
public static class ApplicationsUrls
{
    public const string SettingsApplications = "/api/{api_version}/settings/applications";

    public const string SettingsApplication = "/api/{api_version}/settings/applications/{application_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ApplicationKey = "application";
}
