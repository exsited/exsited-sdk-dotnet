namespace Exsited.Resources.NoteAttachments.NoteAttachmentsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class NoteAttachment : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/note_attachment/{attachment_uuid}",
    };

    protected override string? EnvelopeKey => "note_attachment";

    [WireName("base64")]
    public string? Base64 { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Size { get; set; }
}
