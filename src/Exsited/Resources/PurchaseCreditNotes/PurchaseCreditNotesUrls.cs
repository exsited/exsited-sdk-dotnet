namespace Exsited.Resources.PurchaseCreditNotes;

/// <summary>Path templates and body keys for the v4 purchase credit notes endpoints.</summary>
public static class PurchaseCreditNotesUrls
{
    public const string PurchaseCreditNotes = "/api/{api_version}/purchase_credit_notes";

    public const string PurchaseCreditNote = "/api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}";

    public const string PurchaseCreditNoteApply = "/api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/apply";

    public const string PurchaseCreditNoteNotes = "/api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/notes";

    public const string PurchaseCreditNoteNote = "/api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/notes/{note_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}</c> and <c>PATCH /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}</c>.</summary>
    public const string PurchaseCreditNoteKey = "purchase_credit_note";
}
