namespace Exsited.Resources.BillingPeriods;

/// <summary>Path templates and body keys for the v4 billing periods endpoints.</summary>
public static class BillingPeriodsUrls
{
    public const string SettingsBillingPeriods = "/api/{api_version}/settings/billing_periods";

    public const string SettingsBillingPeriod = "/api/{api_version}/settings/billing_periods/{billing_period_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string BillingPeriodKey = "billing_period";
}
