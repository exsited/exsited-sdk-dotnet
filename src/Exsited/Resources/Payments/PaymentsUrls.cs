namespace Exsited.Resources.Payments;

/// <summary>Path templates and body keys for the v4 payments endpoints.</summary>
public static class PaymentsUrls
{
    public const string Payments = "/api/{api_version}/payments";

    public const string PaymentsNotes = "/api/{api_version}/payments/notes";

    public const string Payment = "/api/{api_version}/payments/{payment_id}";

    public const string InvoicePayments = "/api/{api_version}/invoices/{invoice_id}/payments";

    public const string OrderPayments = "/api/{api_version}/orders/{order_id}/payments";

    public const string PaymentNotes = "/api/{api_version}/payments/{payment_id}/notes";

    public const string PaymentNote = "/api/{api_version}/payments/{payment_id}/notes/{payment_note_id}";

    public const string PaymentNoteFile = "/api/{api_version}/payments/{payment_id}/notes/{payment_note_id}/files/{payment_file_id}";

    public const string InvoicePayment = "/api/{api_version}/invoices/{invoice_id}/payments/{payment_id}";

    public const string PaymentNoteFiles = "/api/{api_version}/payments/{payment_id}/notes/{payment_note_id}/files";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/payments/{payment_id}</c> and <c>PATCH /api/{api_version}/payments/{payment_id}</c>.</summary>
    public const string PaymentKey = "payment";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/payments/{payment_id}/notes</c> and <c>GET /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}</c>.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}/files/{payment_file_id}</c>.</summary>
    public const string FileKey = "file";
}
