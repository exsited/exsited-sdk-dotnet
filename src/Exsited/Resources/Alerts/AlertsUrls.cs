namespace Exsited.Resources.Alerts;

/// <summary>Path templates for the v4 alerts endpoints.</summary>
public static class AlertsUrls
{
    public const string Alerts = "/api/{api_version}/alerts";

    public const string Alert = "/api/{api_version}/alerts/{alert_id}";

    public const string AlertsAccountById = "/api/{api_version}/alerts/account/{account_id}";

    public const string AlertsEmployeeById = "/api/{api_version}/alerts/employee/{employee_id}";

    public const string AlertsLabourById = "/api/{api_version}/alerts/labour/{labour_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
