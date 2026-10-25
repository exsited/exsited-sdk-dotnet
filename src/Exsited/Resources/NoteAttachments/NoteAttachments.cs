using Exsited.Client;
using Exsited.Resources.NoteAttachments.NoteAttachmentsDto;

namespace Exsited.Resources.NoteAttachments;

/// <summary>The v4 note attachments endpoints, as a typed resource bound to one client.</summary>
public sealed class NoteAttachments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.NoteAttachments</c>.</summary>
    public NoteAttachments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/note_attachment/{attachment_uuid}</c>.</summary>
    public Task<ApiResponse> GetNoteAttachmentAsync(
        string attachmentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(NoteAttachmentsUrls.NoteAttachment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["attachment_uuid"] = attachmentUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteAttachment),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.NoteAttachments.GetNoteAttachmentAsync</c>.</summary>
    public static Task<ApiResponse> GetNoteAttachmentAsync(
        ExsitedClient client,
        string attachmentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteAttachments.GetNoteAttachmentAsync(
            attachmentUuid, queryParams, raiseOnError, cancellationToken, responseFormat);
}
