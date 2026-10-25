namespace Exsited.Resources.CustomForms;

/// <summary>Path templates and body keys for the v4 custom forms endpoints.</summary>
public static class CustomFormsUrls
{
    public const string SettingsCustomForms = "/api/{api_version}/settings/custom_forms";

    public const string SettingsCustomForm = "/api/{api_version}/settings/custom_forms/{custom_form_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string CustomFormKey = "custom_form";
}
