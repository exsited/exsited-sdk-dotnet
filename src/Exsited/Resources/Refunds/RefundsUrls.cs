namespace Exsited.Resources.Refunds;

/// <summary>Path templates and body keys for the v4 refunds endpoints.</summary>
public static class RefundsUrls
{
    public const string Refunds = "/api/{api_version}/refunds";

    public const string Refund = "/api/{api_version}/refunds/{refund_id}";

    public const string CreditNoteRefunds = "/api/{api_version}/credit_notes/{credit_note_id}/refunds";

    public const string RefundNotes = "/api/{api_version}/refunds/{refund_id}/notes";

    public const string RefundNote = "/api/{api_version}/refunds/{refund_id}/notes/{note_id}";

    public const string RefundNoteFiles = "/api/{api_version}/refunds/{refund_id}/notes/{note_id}/files";

    public const string RefundNoteFile = "/api/{api_version}/refunds/{refund_id}/notes/{note_id}/files/{file_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string RefundKey = "refund";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}/files/{file_id}</c>.</summary>
    public const string FileKey = "file";
}
