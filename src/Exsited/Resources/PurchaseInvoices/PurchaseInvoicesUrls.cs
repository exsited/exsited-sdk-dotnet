namespace Exsited.Resources.PurchaseInvoices;

/// <summary>Path templates and body keys for the v4 purchase invoices endpoints.</summary>
public static class PurchaseInvoicesUrls
{
    public const string PurchaseInvoices = "/api/{api_version}/purchase_invoices";

    public const string PurchaseInvoicesNotes = "/api/{api_version}/purchase_invoices/notes";

    public const string PurchaseInvoice = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}";

    public const string PurchaseInvoiceAmend = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/amend";

    public const string PurchaseInvoiceCancel = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/cancel";

    public const string PurchaseInvoiceInformation = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/information";

    public const string PurchaseInvoiceLines = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines";

    public const string PurchaseInvoiceNotes = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes";

    public const string PurchaseInvoicePdf = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/pdf";

    public const string PurchaseInvoicePurchaseCreditNoteApplications = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_credit_note_applications";

    public const string PurchaseInvoicePurchasePayments = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments";

    public const string PurchaseInvoiceReactivate = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/reactivate";

    public const string PurchaseInvoiceLine = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines/{purchase_invoice_line_uuid}";

    public const string PurchaseInvoiceNote = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}";

    public const string PurchaseInvoiceNoteFiles = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files";

    public const string PurchaseInvoiceNoteFile = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files/{file_id}";

    public const string PurchaseInvoicePurchaseCreditNoteApplication = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_credit_note_applications/{application_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 12 endpoints its views were measured from.</summary>
    public const string PurchaseInvoiceKey = "purchase_invoice";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string WatcherListKey = "watcherList";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files</c> and <c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files/{file_id}</c>.</summary>
    public const string FileKey = "file";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_credit_note_applications/{purchase_credit_note_application_id}</c>.</summary>
    public const string PurchaseCreditNoteApplicationKey = "purchase_credit_note_application";
}
