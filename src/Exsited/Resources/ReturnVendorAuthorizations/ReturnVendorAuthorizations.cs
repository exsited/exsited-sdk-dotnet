using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ReturnVendorAuthorizations.ReturnVendorAuthorizationsDto;

namespace Exsited.Resources.ReturnVendorAuthorizations;

/// <summary>The v4 return vendor authorizations endpoints, as a typed resource bound to one client.</summary>
public sealed class ReturnVendorAuthorizations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ReturnVendorAuthorizations</c>.</summary>
    public ReturnVendorAuthorizations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/return_vendor_authorizations</c>.</summary>
    public Task<ApiResponse> GetReturnVendorAuthorizationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorizations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnVendorAuthorizationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_vendor_authorizations</c>.</summary>
    public Task<ApiResponse> CreateReturnVendorAuthorizationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorizations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnVendorAuthorizationView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/return_vendor_authorizations/{rva_id}</c>.</summary>
    public Task<ApiResponse> GetReturnVendorAuthorizationAsync(
        string rvaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorization,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rva_id"] = rvaId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnVendorAuthorizationView),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/return_vendor_authorizations/{rva_id}</c>.</summary>
    public Task<ApiResponse> UpdateReturnVendorAuthorizationAsync(
        string rvaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorization,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rva_id"] = rvaId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnVendorAuthorizationView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/return_vendor_authorizations/{rva_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnVendorAuthorizationAsync(
        string rvaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorization,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rva_id"] = rvaId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/return_vendor_authorizations/{rva_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnVendorAuthorizationNoteAsync(
        string rvaId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorizationNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rva_id"] = rvaId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/return_vendor_authorizations/{rva_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnVendorAuthorizationNoteFileAsync(
        string rvaId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnVendorAuthorizationsUrls.ReturnVendorAuthorizationNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rva_id"] = rvaId, ["note_id"] = noteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.GetReturnVendorAuthorizationsAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnVendorAuthorizationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.GetReturnVendorAuthorizationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.CreateReturnVendorAuthorizationAsync</c>.</summary>
    public static Task<ApiResponse> CreateReturnVendorAuthorizationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.CreateReturnVendorAuthorizationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.GetReturnVendorAuthorizationAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnVendorAuthorizationAsync(
        ExsitedClient client,
        string rvaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.GetReturnVendorAuthorizationAsync(
            rvaId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.UpdateReturnVendorAuthorizationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateReturnVendorAuthorizationAsync(
        ExsitedClient client,
        string rvaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.UpdateReturnVendorAuthorizationAsync(
            rvaId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnVendorAuthorizationAsync(
        ExsitedClient client,
        string rvaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationAsync(
            rvaId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnVendorAuthorizationNoteAsync(
        ExsitedClient client,
        string rvaId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationNoteAsync(
            rvaId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnVendorAuthorizationNoteFileAsync(
        ExsitedClient client,
        string rvaId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnVendorAuthorizations.DeleteReturnVendorAuthorizationNoteFileAsync(
            rvaId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
