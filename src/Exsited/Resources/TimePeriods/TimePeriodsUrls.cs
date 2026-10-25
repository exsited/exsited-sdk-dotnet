namespace Exsited.Resources.TimePeriods;

/// <summary>Path templates and body keys for the v4 time periods endpoints.</summary>
public static class TimePeriodsUrls
{
    public const string SettingsTimePeriods = "/api/{api_version}/settings/time_periods";

    public const string SettingsTimePeriod = "/api/{api_version}/settings/time_periods/{time_period_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string TimePeriodKey = "time_period";
}
