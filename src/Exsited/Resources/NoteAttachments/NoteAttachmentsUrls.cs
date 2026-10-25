namespace Exsited.Resources.NoteAttachments;

/// <summary>Path templates and body keys for the v4 note attachments endpoints.</summary>
public static class NoteAttachmentsUrls
{
    public const string NoteAttachment = "/api/{api_version}/note_attachment/{attachment_uuid}";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/note_attachment/{attachment_uuid}</c>.</summary>
    public const string NoteAttachmentKey = "note_attachment";
}
