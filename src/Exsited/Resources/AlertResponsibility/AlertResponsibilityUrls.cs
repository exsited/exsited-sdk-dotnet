namespace Exsited.Resources.AlertResponsibility;

/// <summary>Path templates and body keys for the v4 alert responsibility endpoints.</summary>
public static class AlertResponsibilityUrls
{
    public const string AlertResponsibilities = "/api/{api_version}/alert_responsibility";

    public const string AlertResponsibility = "/api/{api_version}/alert_responsibility/{alert_responsibility_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string AlertResponsibilityKey = "alert_responsibility";
}
