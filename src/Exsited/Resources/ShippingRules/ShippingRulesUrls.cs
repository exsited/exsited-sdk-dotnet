namespace Exsited.Resources.ShippingRules;

/// <summary>Path templates and body keys for the v4 shipping rules endpoints.</summary>
public static class ShippingRulesUrls
{
    public const string SettingsShippingRules = "/api/{api_version}/settings/shipping_rules";

    public const string SettingsShippingRule = "/api/{api_version}/settings/shipping_rules/{shipping_rule_id}";

    public const string SettingsShippingRuleConfiguration = "/api/{api_version}/settings/shipping_rules/{shipping_rule_id}/configuration";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ShippingRuleKey = "shipping_rule";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string ConfigurationKey = "configuration";
}
