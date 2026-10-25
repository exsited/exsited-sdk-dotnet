namespace Exsited.Resources.InvoiceTerms;

/// <summary>Path templates and body keys for the v4 invoice terms endpoints.</summary>
public static class InvoiceTermsUrls
{
    public const string SettingsInvoiceTerms = "/api/{api_version}/settings/invoice_terms";

    public const string SettingsInvoiceTerm = "/api/{api_version}/settings/invoice_terms/{invoice_term_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string InvoiceTermKey = "invoice_term";
}
