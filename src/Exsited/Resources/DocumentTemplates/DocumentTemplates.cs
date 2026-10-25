using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.DocumentTemplates.DocumentTemplatesDto;

namespace Exsited.Resources.DocumentTemplates;

/// <summary>The v4 document templates endpoints, as a typed resource bound to one client.</summary>
public sealed class DocumentTemplates : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.DocumentTemplates</c>.</summary>
    public DocumentTemplates(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/document_templates</c>.</summary>
    public Task<ApiResponse> GetSettingsDocumentTemplatesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DocumentTemplatesUrls.SettingsDocumentTemplates,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDocumentTemplateList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/document_templates</c>.</summary>
    public Task<ApiResponse> CreateSettingsDocumentTemplateAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(DocumentTemplatesUrls.SettingsDocumentTemplates,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDocumentTemplate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/document_templates/{document_template_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsDocumentTemplateAsync(
        string documentTemplateId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DocumentTemplatesUrls.SettingsDocumentTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["document_template_id"] = documentTemplateId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDocumentTemplate),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/document_templates/{document_template_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsDocumentTemplateAsync(
        string documentTemplateId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(DocumentTemplatesUrls.SettingsDocumentTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["document_template_id"] = documentTemplateId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/document_templates/{document_template_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsDocumentTemplateAsync(
        string documentTemplateId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(DocumentTemplatesUrls.SettingsDocumentTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["document_template_id"] = documentTemplateId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDocumentTemplate),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.DocumentTemplates.GetSettingsDocumentTemplatesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDocumentTemplatesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DocumentTemplates.GetSettingsDocumentTemplatesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.DocumentTemplates.CreateSettingsDocumentTemplateAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsDocumentTemplateAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DocumentTemplates.CreateSettingsDocumentTemplateAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.DocumentTemplates.GetSettingsDocumentTemplateAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDocumentTemplateAsync(
        ExsitedClient client,
        string documentTemplateId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DocumentTemplates.GetSettingsDocumentTemplateAsync(
            documentTemplateId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.DocumentTemplates.DeleteSettingsDocumentTemplateAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsDocumentTemplateAsync(
        ExsitedClient client,
        string documentTemplateId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DocumentTemplates.DeleteSettingsDocumentTemplateAsync(
            documentTemplateId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.DocumentTemplates.UpdateSettingsDocumentTemplateAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsDocumentTemplateAsync(
        ExsitedClient client,
        string documentTemplateId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DocumentTemplates.UpdateSettingsDocumentTemplateAsync(
            documentTemplateId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
