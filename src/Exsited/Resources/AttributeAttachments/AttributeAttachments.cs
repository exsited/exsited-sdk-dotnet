using Exsited.Client;

namespace Exsited.Resources.AttributeAttachments;

/// <summary>The v4 attribute attachments endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class AttributeAttachments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AttributeAttachments</c>.</summary>
    public AttributeAttachments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/attribute_attachment/{file_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetAttributeAttachmentAsync(
        string fileUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AttributeAttachmentsUrls.AttributeAttachment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["file_uuid"] = fileUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.AttributeAttachments.GetAttributeAttachmentAsync</c>.</summary>
    public static Task<ApiResponse> GetAttributeAttachmentAsync(
        ExsitedClient client,
        string fileUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AttributeAttachments.GetAttributeAttachmentAsync(
            fileUuid, queryParams, raiseOnError, cancellationToken, responseFormat);
}
