namespace Exsited.Resources.PurchasePayments;

/// <summary>Path templates and body keys for the v4 purchase payments endpoints.</summary>
public static class PurchasePaymentsUrls
{
    public const string PurchasePayments = "/api/{api_version}/purchase_payments";

    public const string PurchasePayment = "/api/{api_version}/purchase_payments/{purchase_payment_id}";

    public const string PurchaseInvoicePurchasePayments = "/api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments";

    public const string PurchasePaymentNotes = "/api/{api_version}/purchase_payments/{purchase_payment_id}/notes";

    public const string PurchasePaymentNote = "/api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}";

    public const string PurchasePaymentNoteFiles = "/api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files";

    public const string PurchasePaymentNoteFile = "/api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files/{file_id}";

    public const string PurchasePaymentPurchaseCreditNotes = "/api/{api_version}/purchase_payments/{purchase_payment_id}/purchase_credit_notes";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 6 endpoints its views were measured from.</summary>
    public const string PurchasePaymentKey = "purchase_payment";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string FilesKey = "files";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/purchase_payments/{purchase_payment_id}/notes</c> and <c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}</c>.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files</c> and <c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files/{file_id}</c>.</summary>
    public const string FileKey = "file";
}
