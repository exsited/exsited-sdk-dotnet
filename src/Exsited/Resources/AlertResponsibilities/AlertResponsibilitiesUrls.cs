namespace Exsited.Resources.AlertResponsibilities;

/// <summary>Path templates and body keys for the v4 alert responsibilities endpoints.</summary>
public static class AlertResponsibilitiesUrls
{
    public const string SettingsAlertResponsibilities = "/api/{api_version}/settings/alert_responsibilities";

    public const string SettingsAlertResponsibility = "/api/{api_version}/settings/alert_responsibilities/{alert_responsibility_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string AlertResponsibilityKey = "alert_responsibility";
}
