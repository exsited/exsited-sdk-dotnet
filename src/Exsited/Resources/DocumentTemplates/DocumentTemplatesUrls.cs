namespace Exsited.Resources.DocumentTemplates;

/// <summary>Path templates and body keys for the v4 document templates endpoints.</summary>
public static class DocumentTemplatesUrls
{
    public const string SettingsDocumentTemplates = "/api/{api_version}/settings/document_templates";

    public const string SettingsDocumentTemplate = "/api/{api_version}/settings/document_templates/{document_template_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string DocumentTemplateKey = "document_template";
}
