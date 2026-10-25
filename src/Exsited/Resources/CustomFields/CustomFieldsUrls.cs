namespace Exsited.Resources.CustomFields;

/// <summary>Path templates and body keys for the v4 custom fields endpoints.</summary>
public static class CustomFieldsUrls
{
    public const string SettingsCustomFields = "/api/{api_version}/settings/custom_fields";

    public const string SettingsCustomField = "/api/{api_version}/settings/custom_fields/{custom_field_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/custom_fields</c> and <c>GET /api/{api_version}/settings/custom_fields/{custom_field_id}</c>.</summary>
    public const string CustomFieldKey = "custom_field";
}
