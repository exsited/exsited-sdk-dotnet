namespace Exsited.Resources.NoteAttachments.NoteAttachmentsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class NoteAttachment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
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
