using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ReturnMerchandiseAuthorisations.ReturnMerchandiseAuthorisationsDto;

namespace Exsited.Resources.ReturnMerchandiseAuthorisations;

/// <summary>The v4 return merchandise authorisations endpoints, as a typed resource bound to one client.</summary>
public sealed class ReturnMerchandiseAuthorisations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ReturnMerchandiseAuthorisations</c>.</summary>
    public ReturnMerchandiseAuthorisations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_merchandise_authorisations</c>.</summary>
    public Task<ApiResponse> CreateReturnMerchandiseAuthorisationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationsView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_id}</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationAsync(
        string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive</c>.</summary>
    public Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationReceiveAsync(
        string invoiceId, string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.InvoiceReturnMerchandiseAuthorisationReceive,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["rma_code"] = rmaId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReturnMerchandiseAuthorisationReceiveList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}</c>.</summary>
    public Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationReceiveByUuidAsync(
        string invoiceId, string rmaId, string receiveUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.InvoiceReturnMerchandiseAuthorisationReceiveByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["rma_code"] = rmaId, ["receive_uuid"] = receiveUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReturnMerchandiseAuthorisationReceive),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/return_merchandise_authorisations/{rma_id}</c>.</summary>
    public Task<ApiResponse> UpdateReturnMerchandiseAuthorisationAsync(
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationRead),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/return_merchandise_authorisations/{rma_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnMerchandiseAuthorisationAsync(
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_merchandise_authorisations/{rma_id}/approve</c>.</summary>
    public Task<ApiResponse> ApproveReturnMerchandiseAuthorisationAsync(
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationApprove,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_merchandise_authorisations/{rma_id}/reject</c>.</summary>
    public Task<ApiResponse> RejectReturnMerchandiseAuthorisationAsync(
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationReject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_merchandise_authorisations/{rma_id}/receive</c>.</summary>
    public Task<ApiResponse> ReceiveReturnMerchandiseAuthorisationAsync(
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationReceive,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReturnMerchandiseAuthorisationRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/receive</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationReceiveAsync(
        string rmaCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationReceive,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaCode },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReturnMerchandiseAuthorisationReceiveList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationReceiveByUuidAsync(
        string rmaCode, string receiveUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationReceiveByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaCode, ["receive_uuid"] = receiveUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReturnMerchandiseAuthorisationReceive),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/return_merchandise_authorisations/{rma_id}/notes</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateReturnMerchandiseAuthorisationNoteAsync(
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/notes</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationNotesAsync(
        string rmaCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_id"] = rmaCode },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteAsync(
        string rmaCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNoteByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaCode, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/return_merchandise_authorisations/{rma_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnMerchandiseAuthorisationNoteAsync(
        string rmaId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNoteByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}/files</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteFilesAsync(
        string rmaCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNoteFilesByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaCode, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteFileAsync(
        string rmaCode, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNoteFileByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaCode, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/return_merchandise_authorisations/{rma_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteReturnMerchandiseAuthorisationNoteFileAsync(
        string rmaId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReturnMerchandiseAuthorisationsUrls.ReturnMerchandiseAuthorisationNoteFileByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rma_code"] = rmaId, ["note_id"] = noteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationsAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.CreateReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> CreateReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.CreateReturnMerchandiseAuthorisationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationAsync(
            rmaId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetInvoiceReturnMerchandiseAuthorisationReceiveAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationReceiveAsync(
        ExsitedClient client,
        string invoiceId, string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetInvoiceReturnMerchandiseAuthorisationReceiveAsync(
            invoiceId, rmaId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetInvoiceReturnMerchandiseAuthorisationReceiveByUuidAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationReceiveByUuidAsync(
        ExsitedClient client,
        string invoiceId, string rmaId, string receiveUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetInvoiceReturnMerchandiseAuthorisationReceiveByUuidAsync(
            invoiceId, rmaId, receiveUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.UpdateReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.UpdateReturnMerchandiseAuthorisationAsync(
            rmaId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationAsync(
            rmaId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.ApproveReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> ApproveReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.ApproveReturnMerchandiseAuthorisationAsync(
            rmaId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.RejectReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> RejectReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.RejectReturnMerchandiseAuthorisationAsync(
            rmaId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.ReceiveReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> ReceiveReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.ReceiveReturnMerchandiseAuthorisationAsync(
            rmaId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationReceiveAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationReceiveAsync(
        ExsitedClient client,
        string rmaCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationReceiveAsync(
            rmaCode, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationReceiveByUuidAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationReceiveByUuidAsync(
        ExsitedClient client,
        string rmaCode, string receiveUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationReceiveByUuidAsync(
            rmaCode, receiveUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.CreateReturnMerchandiseAuthorisationNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateReturnMerchandiseAuthorisationNoteAsync(
        ExsitedClient client,
        string rmaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.CreateReturnMerchandiseAuthorisationNoteAsync(
            rmaId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationNotesAsync(
        ExsitedClient client,
        string rmaCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNotesAsync(
            rmaCode, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteAsync(
        ExsitedClient client,
        string rmaCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteAsync(
            rmaCode, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnMerchandiseAuthorisationNoteAsync(
        ExsitedClient client,
        string rmaId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationNoteAsync(
            rmaId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteFilesAsync(
        ExsitedClient client,
        string rmaCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteFilesAsync(
            rmaCode, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetReturnMerchandiseAuthorisationNoteFileAsync(
        ExsitedClient client,
        string rmaCode, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.GetReturnMerchandiseAuthorisationNoteFileAsync(
            rmaCode, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteReturnMerchandiseAuthorisationNoteFileAsync(
        ExsitedClient client,
        string rmaId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReturnMerchandiseAuthorisations.DeleteReturnMerchandiseAuthorisationNoteFileAsync(
            rmaId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
