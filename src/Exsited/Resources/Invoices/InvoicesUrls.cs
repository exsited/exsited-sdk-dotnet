namespace Exsited.Resources.Invoices;

/// <summary>Path templates and body keys for the v4 invoices endpoints.</summary>
public static class InvoicesUrls
{
    public const string Invoices = "/api/{api_version}/invoices";

    public const string Invoice = "/api/{api_version}/invoices/{invoice_id}";

    public const string InvoiceAmend = "/api/{api_version}/invoices/{invoice_id}/amend";

    public const string InvoiceCancel = "/api/{api_version}/invoices/{invoice_id}/cancel";

    public const string InvoiceInformation = "/api/{api_version}/invoices/{invoice_id}/information";

    public const string InvoiceItemFulfillments = "/api/{api_version}/invoices/{invoice_id}/item_fulfillments";

    public const string InvoiceNotes = "/api/{api_version}/invoices/{invoice_id}/notes";

    public const string InvoicePdf = "/api/{api_version}/invoices/{invoice_id}/pdf";

    public const string InvoiceReactivate = "/api/{api_version}/invoices/{invoice_id}/reactivate";

    public const string InvoiceReturnMerchandiseAuthorisations = "/api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations";

    public const string OrderInvoices = "/api/{api_version}/orders/{order_id}/invoices";

    public const string InvoiceItemFulfillment = "/api/{api_version}/invoices/{invoice_id}/item_fulfillments/{fulfillment_id}";

    public const string InvoiceNote = "/api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}";

    public const string InvoiceReturnMerchandiseAuthorisation = "/api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_id}";

    public const string InvoiceNoteFiles = "/api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files";

    public const string InvoiceNoteFile = "/api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files/{invoice_file_id}";

    public const string InvoiceKpis = "/api/{api_version}/invoices/{invoice_id}/kpis";

    public const string InvoiceLines = "/api/{api_version}/invoices/{invoice_id}/lines";

    public const string InvoiceLine = "/api/{api_version}/invoices/{invoice_id}/lines/{line_id}";

    public const string InvoiceCreditNoteApplication = "/api/{api_version}/invoices/{invoice_id}/credit_note_applications/{credit_note_application_id}";

    public const string InvoiceCustomObjects = "/api/{api_version}/invoices/{invoice_id}/custom_objects";

    public const string InvoiceCustomObject = "/api/{api_version}/invoices/{invoice_id}/custom_objects/{custom_object_id}";

    public const string InvoiceCustomObjectInstance = "/api/{api_version}/invoices/{invoice_id}/custom_objects/{custom_object_id}/instances/{instance_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments</c> and <c>GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public const string ItemFulfillmentKey = "item_fulfillment";

    /// <summary>The key one record arrives under, on the 10 endpoints its views were measured from.</summary>
    public const string InvoiceKey = "invoice";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_id}</c>.</summary>
    public const string ReturnMerchandiseAuthorisationKey = "return_merchandise_authorisation";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/invoices/{invoice_id}/notes</c> and <c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}</c>.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files</c> and <c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files/{invoice_file_id}</c>.</summary>
    public const string FileKey = "file";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string InvoiceKpisKey = "invoice_kpis";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/credit_note_applications/{credit_note_application_id}</c>.</summary>
    public const string CreditNoteApplicationKey = "credit_note_application";
}
