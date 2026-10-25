namespace Exsited.Resources.EmailTemplates;

/// <summary>Path templates and body keys for the v4 email templates endpoints.</summary>
public static class EmailTemplatesUrls
{
    public const string SettingsEmailTemplates = "/api/{api_version}/settings/email_templates";

    public const string SettingsEmailTemplate = "/api/{api_version}/settings/email_templates/{email_template_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string EmailTemplateKey = "email_template";
}
