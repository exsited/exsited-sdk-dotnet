namespace Exsited.Resources.DayOfMonth;

/// <summary>Path templates and body keys for the v4 day of month endpoints.</summary>
public static class DayOfMonthUrls
{
    public const string SettingsDaysOfMonth = "/api/{api_version}/settings/day_of_month";

    public const string SettingsDayOfMonth = "/api/{api_version}/settings/day_of_month/{day_of_month_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/day_of_month</c> and <c>GET /api/{api_version}/settings/day_of_month/{day_of_month_id}</c>.</summary>
    public const string DayOfMonthKey = "day_of_month";
}
