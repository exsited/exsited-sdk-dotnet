using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchaseOrders.PurchaseOrdersDto;

namespace Exsited.Resources.PurchaseOrders;

/// <summary>The v4 purchase orders endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseOrders : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseOrders</c>.</summary>
    public PurchaseOrders(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrdersAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrders,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_orders</c>.</summary>
    public Task<ApiResponse> CreatePurchaseOrderAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrders,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrdersView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders/notes</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrdersNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrdersNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrdersNoteList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_orders/{purchase_order_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseOrderAsync(
        string purchaseOrderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseOrdersUrls.PurchaseOrder,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_orders/{purchase_order_id}</c>.</summary>
    public Task<ApiResponse> UpdatePurchaseOrderAsync(
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PurchaseOrdersUrls.PurchaseOrder,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrder,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelPurchaseOrderAsync(
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrderCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderCancel),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/change</c>.</summary>
    public Task<ApiResponse> ChangePurchaseOrderAsync(
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrderChange,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderChange),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/information</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderInformationAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderInformation),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderLinesAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderLines,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderLineList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderNotesAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreatePurchaseOrderNoteAsync(
        string purchaseOrderId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrderNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderNotesCreated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices</c>.</summary>
    public Task<ApiResponse> CreatePurchaseOrderPurchaseInvoiceAsync(
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrderPurchaseInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderPurchaseInvoices),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderPurchaseInvoicesAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderPurchaseInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderPurchaseInvoiceList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_payments</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderPurchasePaymentsAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderPurchasePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderPurchasePaymentList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivatePurchaseOrderAsync(
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseOrdersUrls.PurchaseOrderReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderReactivate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines/{purchase_order_line _uuid}</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderLineAsync(
        string purchaseOrderId, string purchaseOrderLineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_line_uuid"] = purchaseOrderLineUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderLineRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_n ote_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseOrderNoteAsync(
        string purchaseOrderId, string purchaseOrderNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseOrdersUrls.PurchaseOrderNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_note_id"] = purchaseOrderNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note _id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderNoteAsync(
        string purchaseOrderId, string purchaseOrderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_note_id"] = purchaseOrderNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderNote),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note _id}/files</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderNoteFilesAsync(
        string purchaseOrderId, string purchaseOrderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_note_id"] = purchaseOrderNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note _id}/files/{purchase_order_file_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderNoteFileAsync(
        string purchaseOrderId, string purchaseOrderNoteId, string purchaseOrderFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_note_id"] = purchaseOrderNoteId, ["purchase_order_file_id"] = purchaseOrderFileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/kpis</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderKpisAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseOrdersUrls.PurchaseOrderKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderKpis),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files/{purchase_order_file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseOrderNoteFileAsync(
        string purchaseOrderId, string purchaseOrderNoteId, string purchaseOrderFileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseOrdersUrls.PurchaseOrderNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId, ["purchase_order_note_id"] = purchaseOrderNoteId, ["purchase_order_file_id"] = purchaseOrderFileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrdersAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrdersAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrdersAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.CreatePurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseOrderAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.CreatePurchaseOrderAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrdersNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrdersNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrdersNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.DeletePurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.DeletePurchaseOrderAsync(
            purchaseOrderId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.UpdatePurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.UpdatePurchaseOrderAsync(
            purchaseOrderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.CancelPurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> CancelPurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.CancelPurchaseOrderAsync(
            purchaseOrderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.ChangePurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> ChangePurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.ChangePurchaseOrderAsync(
            purchaseOrderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderInformationAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderInformationAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderLinesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderLinesAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderLinesAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderNotesAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderNotesAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.CreatePurchaseOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseOrderNoteAsync(
        ExsitedClient client,
        string purchaseOrderId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.CreatePurchaseOrderNoteAsync(
            purchaseOrderId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.CreatePurchaseOrderPurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseOrderPurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.CreatePurchaseOrderPurchaseInvoiceAsync(
            purchaseOrderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderPurchaseInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderPurchaseInvoicesAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderPurchaseInvoicesAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderPurchasePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderPurchasePaymentsAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderPurchasePaymentsAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.ReactivatePurchaseOrderAsync</c>.</summary>
    public static Task<ApiResponse> ReactivatePurchaseOrderAsync(
        ExsitedClient client,
        string purchaseOrderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.ReactivatePurchaseOrderAsync(
            purchaseOrderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderLineAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderLineAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderLineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderLineAsync(
            purchaseOrderId, purchaseOrderLineUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.DeletePurchaseOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseOrderNoteAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.DeletePurchaseOrderNoteAsync(
            purchaseOrderId, purchaseOrderNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderNoteAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderNoteAsync(
            purchaseOrderId, purchaseOrderNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderNoteFilesAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderNoteFilesAsync(
            purchaseOrderId, purchaseOrderNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderNoteFileAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderNoteId, string purchaseOrderFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderNoteFileAsync(
            purchaseOrderId, purchaseOrderNoteId, purchaseOrderFileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.PurchaseOrders.GetPurchaseOrderKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderKpisAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.GetPurchaseOrderKpisAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseOrders.DeletePurchaseOrderNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseOrderNoteFileAsync(
        ExsitedClient client,
        string purchaseOrderId, string purchaseOrderNoteId, string purchaseOrderFileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseOrders.DeletePurchaseOrderNoteFileAsync(
            purchaseOrderId, purchaseOrderNoteId, purchaseOrderFileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
