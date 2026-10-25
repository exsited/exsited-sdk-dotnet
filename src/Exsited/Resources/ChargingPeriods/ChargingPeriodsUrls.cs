namespace Exsited.Resources.ChargingPeriods;

/// <summary>Path templates and body keys for the v4 charging periods endpoints.</summary>
public static class ChargingPeriodsUrls
{
    public const string SettingsChargingPeriods = "/api/{api_version}/settings/charging_periods";

    public const string SettingsChargingPeriod = "/api/{api_version}/settings/charging_periods/{charging_period_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ChargingPeriodKey = "charging_period";
}
