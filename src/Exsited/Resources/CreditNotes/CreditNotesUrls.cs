namespace Exsited.Resources.CreditNotes;

/// <summary>Path templates and body keys for the v4 credit notes endpoints.</summary>
public static class CreditNotesUrls
{
    public const string CreditNotes = "/api/{api_version}/credit_notes";

    public const string CreditNote = "/api/{api_version}/credit_notes/{credit_note_id}";

    public const string CreditNoteApply = "/api/{api_version}/credit_notes/{credit_note_id}/apply";

    public const string CreditNoteItems = "/api/{api_version}/credit_notes/{credit_note_id}/items";

    public const string CreditNoteCreditNoteApplications = "/api/{api_version}/credit_notes/{credit_note_id}/credit_note_applications";

    public const string CreditNoteNotes = "/api/{api_version}/credit_notes/{credit_note_id}/notes";

    public const string CreditNoteNote = "/api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}";

    public const string CreditNoteNoteFiles = "/api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}/files";

    public const string CreditNoteNoteFile = "/api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}/files/{file_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/credit_notes/{credit_note_id}</c> and <c>PATCH /api/{api_version}/credit_notes/{credit_note_id}</c>.</summary>
    public const string CreditNoteKey = "credit_note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes</c> and <c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}</c>.</summary>
    public const string NoteKey = "note";
}
