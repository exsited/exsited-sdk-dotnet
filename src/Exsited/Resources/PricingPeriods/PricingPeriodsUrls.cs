namespace Exsited.Resources.PricingPeriods;

/// <summary>Path templates and body keys for the v4 pricing periods endpoints.</summary>
public static class PricingPeriodsUrls
{
    public const string SettingsPricingPeriods = "/api/{api_version}/settings/pricing_periods";

    public const string SettingsPricingPeriod = "/api/{api_version}/settings/pricing_periods/{pricing_period_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string PricingPeriodKey = "pricing_period";
}
