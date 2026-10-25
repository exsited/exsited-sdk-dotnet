namespace Exsited.Resources.ProformaInvoices;

/// <summary>Path templates and body keys for the v4 proforma invoices endpoints.</summary>
public static class ProformaInvoicesUrls
{
    public const string ProformaInvoices = "/api/{api_version}/proforma_invoices";

    public const string ProformaInvoice = "/api/{api_version}/proforma_invoices/{proforma_id}";

    public const string ProformaInvoicePayments = "/api/{api_version}/proforma_invoices/{proforma_id}/payments";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string ProformaInvoiceKey = "proforma_invoice";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string PaymentKey = "payment";
}
