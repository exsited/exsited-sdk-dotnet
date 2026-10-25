namespace Exsited.Resources.Settings;

/// <summary>Path templates and body keys for the v4 settings endpoints.</summary>
public static class SettingsUrls
{
    public const string CustomObjects = "/api/{api_version}/custom_objects";

    public const string Settings = "/api/{api_version}/settings";

    public const string CustomObject = "/api/{api_version}/custom_objects/{custom_object_id}";

    public const string SettingsCurrencies = "/api/{api_version}/settings/currencies";

    public const string SettingsCustomLogicScripts = "/api/{api_version}/settings/custom_logic_scripts";

    public const string SettingsCustomObjects = "/api/{api_version}/settings/custom_objects";

    public const string SettingsDiscountProfiles = "/api/{api_version}/settings/discount_profiles";

    public const string SettingsItemGroups = "/api/{api_version}/settings/item_groups";

    public const string SettingsPaymentProcessors = "/api/{api_version}/settings/payment_processors";

    public const string SettingsPaymentTerms = "/api/{api_version}/settings/payment_terms";

    public const string SettingsPricingLevels = "/api/{api_version}/settings/pricing_levels";

    public const string SettingsShippingProfiles = "/api/{api_version}/settings/shipping_profiles";

    public const string SettingsTaxes = "/api/{api_version}/settings/taxes";

    public const string SettingsTimeZones = "/api/{api_version}/settings/time_zones";

    public const string SettingsVariations = "/api/{api_version}/settings/variations";

    public const string SettingsWarehouses = "/api/{api_version}/settings/warehouses";

    public const string SettingsCurrency = "/api/{api_version}/settings/currencies/{currency_id}";

    public const string SettingsCustomLogicScript = "/api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}";

    public const string SettingsCustomObject = "/api/{api_version}/settings/custom_objects/{custom_object_id}";

    public const string SettingsFieldSettingsAccount = "/api/{api_version}/settings/field_settings/account";

    public const string SettingsFieldSettingsItem = "/api/{api_version}/settings/field_settings/item";

    public const string SettingsGeneralSettingsAccount = "/api/{api_version}/settings/general_settings/account";

    public const string SettingsGeneralSettingsItem = "/api/{api_version}/settings/general_settings/item";

    public const string SettingsItemGroup = "/api/{api_version}/settings/item_groups/{item_group_id}";

    public const string SettingsTimeZone = "/api/{api_version}/settings/time_zones/{time_zone_id}";

    public const string SettingsVariation = "/api/{api_version}/settings/variations/{variation_id}";

    public const string SettingsCustomObjectCustomize = "/api/{api_version}/settings/custom_objects/{custom_object_id}/customize";

    public const string SettingsItemGroupBillingPreferences = "/api/{api_version}/settings/item_groups/{item_group_id}/billing_preferences";

    public const string SettingsDiscountProfile = "/api/{api_version}/settings/discount_profiles/{discount_profile_id}";

    public const string SettingsFieldSettings = "/api/{api_version}/settings/field_settings";

    public const string SettingsFieldSetting = "/api/{api_version}/settings/field_settings/{field_setting_id}";

    public const string SettingsGeneralSettingsGroup = "/api/{api_version}/settings/general_settings/{group}";

    public const string SettingsGeneralSetting = "/api/{api_version}/settings/general_settings/{group}/{general_setting_id}";

    public const string SettingsGeneralSettingsDashboard = "/api/{api_version}/settings/general_settings/dashboard";

    public const string SettingsGeneralSettingsDateAndTime = "/api/{api_version}/settings/general_settings/date_and_time";

    public const string SettingsGeneralSettingsDisplay = "/api/{api_version}/settings/general_settings/display";

    public const string SettingsGeneralSettingsGeneral = "/api/{api_version}/settings/general_settings/general";

    public const string SettingsGeneralSettingsLabour = "/api/{api_version}/settings/general_settings/labour";

    public const string SettingsGeneralSettingsOrder = "/api/{api_version}/settings/general_settings/order";

    public const string SettingsGeneralSettingsPortal = "/api/{api_version}/settings/general_settings/portal";

    public const string SettingsGeneralSettingsPurchase = "/api/{api_version}/settings/general_settings/purchase";

    public const string SettingsGeneralSettingsSecurity = "/api/{api_version}/settings/general_settings/security";

    public const string SettingsGeneralSettingsTransaction = "/api/{api_version}/settings/general_settings/transaction";

    public const string SettingsPaymentProcessor = "/api/{api_version}/settings/payment_processors/{payment_processor_id}";

    public const string SettingsPaymentTerm = "/api/{api_version}/settings/payment_terms/{payment_term_id}";

    public const string SettingsPricingLevel = "/api/{api_version}/settings/pricing_levels/{pricing_level_id}";

    public const string SettingsShippingProfile = "/api/{api_version}/settings/shipping_profiles/{shipping_profile_id}";

    public const string SettingsWarehouse = "/api/{api_version}/settings/warehouses/{warehouse_id}";

    public const string SettingsTax = "/api/{api_version}/settings/taxes/{tax_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ItemGroupKey = "item_group";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}</c>.</summary>
    public const string CustomLogicScriptKey = "custom_logic_script";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/currencies/{currency_id}</c>.</summary>
    public const string CurrencyKey = "currency";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string CustomObjectKey = "custom_object";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string VariationKey = "variation";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/time_zones/{time_zone_id}</c>.</summary>
    public const string TimeZoneKey = "time_zone";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings</c>.</summary>
    public const string SettingsKey = "settings";

    /// <summary>The key one record arrives under, on <c>PATCH /api/{api_version}/settings/general_settings/account</c> and <c>PATCH /api/{api_version}/settings/general_settings/item</c>.</summary>
    public const string GeneralSettingsKey = "general_settings";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string DiscountProfileKey = "discount_profile";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/field_settings/{field_setting_id}</c>.</summary>
    public const string FieldSettingKey = "field_setting";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string PaymentProcessorKey = "payment_processor";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string PaymentTermKey = "payment_term";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string PricingLevelKey = "pricing_level";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/shipping_profiles/{shipping_profile_id}</c> and <c>POST /api/{api_version}/settings/shipping_profiles</c>.</summary>
    public const string ShippingProfileKey = "shipping_profile";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/taxes/{tax_id}</c>.</summary>
    public const string TaxKey = "tax";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string WarehouseKey = "warehouse";
}
