using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Invoices.InvoicesDto;

namespace Exsited.Resources.Invoices;

/// <summary>The v4 invoices endpoints, as a typed resource bound to one client.</summary>
public sealed class Invoices : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Invoices</c>.</summary>
    public Invoices(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/invoices</c>.</summary>
    public Task<ApiResponse> GetInvoicesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.Invoices,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/invoices</c>.</summary>
    public Task<ApiResponse> CreateInvoiceAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoicesUrls.Invoices,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoicesView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/invoices/{invoice_id}</c>.</summary>
    public Task<ApiResponse> DeleteInvoiceAsync(
        string invoiceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(InvoicesUrls.Invoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceDeleted),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.Invoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/invoices/{invoice_id}/amend</c>.</summary>
    public Task<ApiResponse> AmendInvoiceAsync(
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoicesUrls.InvoiceAmend,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoicesView),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/invoices/{invoice_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelInvoiceAsync(
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoicesUrls.InvoiceCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoicesView),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/invoices/{invoice_id}/information</c>.</summary>
    public Task<ApiResponse> UpdateInvoiceInformationAsync(
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(InvoicesUrls.InvoiceInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceInformation),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/information</c>.</summary>
    public Task<ApiResponse> GetInvoiceInformationAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceInformationRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments</c>.</summary>
    public Task<ApiResponse> GetInvoiceItemFulfillmentsAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceItemFulfillments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceItemFulfillmentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/notes</c>.</summary>
    public Task<ApiResponse> GetInvoiceNotesAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/invoices/{invoice_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateInvoiceNoteAsync(
        string invoiceId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(InvoicesUrls.InvoiceNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/pdf</c>.</summary>
    public Task<ApiResponse> GetInvoicePdfAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoicePdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoicePdf),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/invoices/{invoice_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivateInvoiceAsync(
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoicesUrls.InvoiceReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReactivate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations</c>.</summary>
    public Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationsAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceReturnMerchandiseAuthorisations,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountInvoices),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/invoices</c>.</summary>
    public Task<ApiResponse> GetOrderInvoicesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.OrderInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/invoices</c>.</summary>
    public Task<ApiResponse> CreateOrderInvoiceAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoicesUrls.OrderInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoicesView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceItemFulfillmentAsync(
        string invoiceId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["fulfillment_id"] = fulfillmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceItemFulfillment),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceNoteAsync(
        string invoiceId, string invoiceNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["invoice_note_id"] = invoiceNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceNoteRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteInvoiceNoteAsync(
        string invoiceId, string invoiceNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(InvoicesUrls.InvoiceNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["invoice_note_id"] = invoiceNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationAsync(
        string invoiceId, string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceReturnMerchandiseAuthorisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["rma_id"] = rmaId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceReturnMerchandiseAuthorisation),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files</c>.</summary>
    public Task<ApiResponse> GetInvoiceNoteFilesAsync(
        string invoiceId, string invoiceNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["invoice_note_id"] = invoiceNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files/{invoice_f ile_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceNoteFileAsync(
        string invoiceId, string invoiceNoteId, string invoiceFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["invoice_note_id"] = invoiceNoteId, ["invoice_file_id"] = invoiceFileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/kpis</c>.</summary>
    public Task<ApiResponse> GetInvoiceKpisAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceKpisRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/lines</c>.</summary>
    public Task<ApiResponse> GetInvoiceLinesAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceLines,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceLines),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/lines/{line_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceLineAsync(
        string invoiceId, string lineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["line_id"] = lineId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceLineRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/credit_note_applications/{credit_note_application_id}</c>.</summary>
    public Task<ApiResponse> GetInvoiceCreditNoteApplicationAsync(
        string invoiceId, string creditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceCreditNoteApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["credit_note_application_id"] = creditNoteApplicationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteApplicationRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/custom_objects</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetInvoiceCustomObjectsAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceCustomObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetInvoiceCustomObjectAsync(
        string invoiceId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetInvoiceCustomObjectInstanceAsync(
        string invoiceId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoicesUrls.InvoiceCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/invoices/{invoice_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteInvoiceNoteFileAsync(
        string invoiceId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(InvoicesUrls.InvoiceNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["invoice_note_id"] = noteId, ["invoice_file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoicesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoicesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.CreateInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CreateInvoiceAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.CreateInvoiceAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.DeleteInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> DeleteInvoiceAsync(
        ExsitedClient client,
        string invoiceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.DeleteInvoiceAsync(
            invoiceId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.AmendInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> AmendInvoiceAsync(
        ExsitedClient client,
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.AmendInvoiceAsync(
            invoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.CancelInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CancelInvoiceAsync(
        ExsitedClient client,
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.CancelInvoiceAsync(
            invoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.UpdateInvoiceInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateInvoiceInformationAsync(
        ExsitedClient client,
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.UpdateInvoiceInformationAsync(
            invoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceInformationAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceInformationAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceItemFulfillmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceItemFulfillmentsAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceItemFulfillmentsAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceNotesAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceNotesAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.CreateInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateInvoiceNoteAsync(
        ExsitedClient client,
        string invoiceId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.CreateInvoiceNoteAsync(
            invoiceId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoicePdfAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoicePdfAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoicePdfAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.ReactivateInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateInvoiceAsync(
        ExsitedClient client,
        string invoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.ReactivateInvoiceAsync(
            invoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceReturnMerchandiseAuthorisationsAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationsAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceReturnMerchandiseAuthorisationsAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetOrderInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderInvoicesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetOrderInvoicesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.CreateOrderInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderInvoiceAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.CreateOrderInvoiceAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceItemFulfillmentAsync(
        ExsitedClient client,
        string invoiceId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceItemFulfillmentAsync(
            invoiceId, fulfillmentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceNoteAsync(
        ExsitedClient client,
        string invoiceId, string invoiceNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceNoteAsync(
            invoiceId, invoiceNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.DeleteInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteInvoiceNoteAsync(
        ExsitedClient client,
        string invoiceId, string invoiceNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.DeleteInvoiceNoteAsync(
            invoiceId, invoiceNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceReturnMerchandiseAuthorisationAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceReturnMerchandiseAuthorisationAsync(
        ExsitedClient client,
        string invoiceId, string rmaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceReturnMerchandiseAuthorisationAsync(
            invoiceId, rmaId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceNoteFilesAsync(
        ExsitedClient client,
        string invoiceId, string invoiceNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceNoteFilesAsync(
            invoiceId, invoiceNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceNoteFileAsync(
        ExsitedClient client,
        string invoiceId, string invoiceNoteId, string invoiceFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceNoteFileAsync(
            invoiceId, invoiceNoteId, invoiceFileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceKpisAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceKpisAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceLinesAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceLinesAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceLinesAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceLineAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceLineAsync(
        ExsitedClient client,
        string invoiceId, string lineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceLineAsync(
            invoiceId, lineId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceCreditNoteApplicationAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceCreditNoteApplicationAsync(
        ExsitedClient client,
        string invoiceId, string creditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceCreditNoteApplicationAsync(
            invoiceId, creditNoteApplicationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceCustomObjectsAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceCustomObjectsAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceCustomObjectAsync(
        ExsitedClient client,
        string invoiceId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceCustomObjectAsync(
            invoiceId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.GetInvoiceCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceCustomObjectInstanceAsync(
        ExsitedClient client,
        string invoiceId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.GetInvoiceCustomObjectInstanceAsync(
            invoiceId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Invoices.DeleteInvoiceNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteInvoiceNoteFileAsync(
        ExsitedClient client,
        string invoiceId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Invoices.DeleteInvoiceNoteFileAsync(
            invoiceId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
