using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Orders.OrdersDto;

namespace Exsited.Resources.Orders;

/// <summary>The v4 orders endpoints, as a typed resource bound to one client.</summary>
public sealed class Orders : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Orders</c>.</summary>
    public Orders(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/orders</c>.</summary>
    public Task<ApiResponse> GetOrdersAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.Orders,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders</c>; answered <c>201</c>. A contract needs a recurring or metered item on a line.</summary>
    public Task<ApiResponse> CreateOrderAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.Orders,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}</c>.</summary>
    public Task<ApiResponse> GetOrderAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.Order,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/orders/{order_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteOrderAsync(
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(OrdersUrls.Order,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/activate</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ActivateOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderActivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/activate_draft</c>.</summary>
    public Task<ApiResponse> CreateOrderActivateDraftAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderActivateDraft,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderActivateDraft),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> GetOrderBillingPreferencesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderBillingPreferences),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/orders/{order_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> UpdateOrderBillingPreferencesAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OrdersUrls.OrderBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderBillingPreferencesUpdated),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/orders/{order_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> ReplaceOrderBillingPreferencesAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(OrdersUrls.OrderBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderBillingPreferencesUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderCancel),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/change</c>.</summary>
    public Task<ApiResponse> ChangeOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderChange,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderChange),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/convert_to_order</c>.</summary>
    public Task<ApiResponse> CreateOrderConvertToOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderConvertToOrder,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderConvertToOrder),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectsAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects_instances</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectsInstancesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObjectsInstances,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/discard_draft</c>.</summary>
    public Task<ApiResponse> CreateOrderDiscardDraftAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderDiscardDraft,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderDiscardDraft),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/extend_trial</c>; the new trial window starts after the current one ends.</summary>
    public Task<ApiResponse> CreateOrderExtendTrialAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderExtendTrial,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderExtendTrial),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/information</c>.</summary>
    public Task<ApiResponse> GetOrderInformationAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderInformation),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/orders/{order_id}/information</c>.</summary>
    public Task<ApiResponse> UpdateOrderInformationAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OrdersUrls.OrderInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderInformationUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/item_fulfillments</c>.</summary>
    public Task<ApiResponse> GetOrderItemFulfillmentsAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderItemFulfillments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountOrders),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/lines</c>.</summary>
    public Task<ApiResponse> GetOrderLinesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderLines,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderLines),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/notes</c>.</summary>
    public Task<ApiResponse> GetOrderNotesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateOrderNoteAsync(
        string orderId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(OrdersUrls.OrderNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/payment_methods</c>.</summary>
    public Task<ApiResponse> GetOrderPaymentMethodsAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderPaymentMethods,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderPaymentMethods),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/pdf</c>.</summary>
    public Task<ApiResponse> GetOrderPdfAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderPdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderPdf),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivateOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderReactivate),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/relinquish</c>.</summary>
    public Task<ApiResponse> CreateOrderRelinquishAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderRelinquish,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderRelinquish),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/orders/{order_id}/lines/{line_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateOrderLineAsync(
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OrdersUrls.OrderLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["line_uuid"] = lineUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderLineUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/lines/{line_uuid}</c>.</summary>
    public Task<ApiResponse> GetOrderLineAsync(
        string orderId, string lineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["line_uuid"] = lineUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderLine),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/orders/{order_id}/notes/{order_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteOrderNoteAsync(
        string orderId, string orderNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(OrdersUrls.OrderNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}</c>.</summary>
    public Task<ApiResponse> GetOrderNoteAsync(
        string orderId, string orderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/orders/{order_id}/notes/{order_note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdateOrderNoteAsync(
        string orderId, string orderNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(OrdersUrls.OrderNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/payment_methods/{payment_method_ref}</c>.</summary>
    public Task<ApiResponse> GetOrderPaymentMethodAsync(
        string orderId, string paymentMethodRef, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["payment_method_ref"] = paymentMethodRef },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderPaymentMethod),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/orders/{order_id}/lines/{line_uuid}/billing_preferences</c>.</summary>
    public Task<ApiResponse> UpdateOrderLineBillingPreferencesAsync(
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OrdersUrls.OrderLineBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["line_uuid"] = lineUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderLineBillingPreferences),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/orders/{order_id}/lines/{line_uuid}/billing_preferences</c>.</summary>
    public Task<ApiResponse> ReplaceOrderLineBillingPreferencesAsync(
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(OrdersUrls.OrderLineBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["line_uuid"] = lineUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderLineBillingPreferences),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files</c>.</summary>
    public Task<ApiResponse> GetOrderNoteFilesAsync(
        string orderId, string orderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files/{order_file_id}</c>.</summary>
    public Task<ApiResponse> GetOrderNoteFileAsync(
        string orderId, string orderNoteId, string orderFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId, ["order_file_id"] = orderFileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/notes</c>.</summary>
    public Task<ApiResponse> GetOrdersNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrdersNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewOrderAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrdersPreview,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/express</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateOrderExpressAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrdersExpress,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/accept</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> AcceptOrderAsync(
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(OrdersUrls.OrderAccept,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/activate_invoice_from_dormant/{invoice_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ActivateOrderInvoiceFromDormantAsync(
        string orderId, string invoiceUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderActivateInvoiceFromDormant,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["invoice_uuid"] = invoiceUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/change/preview</c>.</summary>
    public Task<ApiResponse> PreviewOrderChangeAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderChangePreview,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderRead),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/change_status</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ChangeOrderStatusAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderChangeStatus,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/contract_adjustment</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> AdjustOrderContractAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderContractAdjustment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/contract_adjustment/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewOrderContractAdjustmentAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderContractAdjustmentPreview,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/downgrade</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DowngradeOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderDowngrade,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/downgrade/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewOrderDowngradeAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderDowngradePreview,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/upgrade</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpgradeOrderAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderUpgrade,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/upgrade/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewOrderUpgradeAsync(
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrdersUrls.OrderUpgradePreview,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/orders/{order_id}/terminate_trial</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> TerminateOrderTrialAsync(
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendPostRequestAsync(OrdersUrls.OrderTerminateTrial,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files/{order_file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteOrderNoteFileAsync(
        string orderId, string orderNoteId, string orderFileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(OrdersUrls.OrderNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["order_note_id"] = orderNoteId, ["order_file_id"] = orderFileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectAsync(
        string orderId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderCustomObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectInstanceAsync(
        string orderId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects_instances/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectsInstanceAsync(
        string orderId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObjectsInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderCustomObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/custom_objects_instances/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetOrderCustomObjectsInstanceInstanceAsync(
        string orderId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderCustomObjectsInstanceInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public Task<ApiResponse> GetOrderItemFulfillmentAsync(
        string orderId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["fulfillment_id"] = fulfillmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderItemFulfillment),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/kpis</c>.</summary>
    public Task<ApiResponse> GetOrderKpisAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderKpis),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/payments/{payment_id}</c>.</summary>
    public Task<ApiResponse> GetOrderPaymentAsync(
        string orderId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderPayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["payment_id"] = paymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderPayment),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/quote_partial_invoices</c>.</summary>
    public Task<ApiResponse> GetOrderQuotePartialInvoicesAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderQuotePartialInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(OrderQuotePartialInvoices),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/shipping_pdf/{shipping_line_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetOrderShippingPdfAsync(
        string orderId, string shippingLineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrdersUrls.OrderShippingPdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId, ["shipping_line_id"] = shippingLineId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Orders.GetOrdersAsync</c>.</summary>
    public static Task<ApiResponse> GetOrdersAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrdersAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.DeleteOrderAsync</c>.</summary>
    public static Task<ApiResponse> DeleteOrderAsync(
        ExsitedClient client,
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.DeleteOrderAsync(
            orderId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ActivateOrderAsync</c>.</summary>
    public static Task<ApiResponse> ActivateOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ActivateOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderActivateDraftAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderActivateDraftAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderActivateDraftAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderBillingPreferencesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderBillingPreferencesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpdateOrderBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> UpdateOrderBillingPreferencesAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpdateOrderBillingPreferencesAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ReplaceOrderBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceOrderBillingPreferencesAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ReplaceOrderBillingPreferencesAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CancelOrderAsync</c>.</summary>
    public static Task<ApiResponse> CancelOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CancelOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ChangeOrderAsync</c>.</summary>
    public static Task<ApiResponse> ChangeOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ChangeOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderConvertToOrderAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderConvertToOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderConvertToOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectsAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectsAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectsInstancesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectsInstancesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectsInstancesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderDiscardDraftAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderDiscardDraftAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderDiscardDraftAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderExtendTrialAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderExtendTrialAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderExtendTrialAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderInformationAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderInformationAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpdateOrderInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateOrderInformationAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpdateOrderInformationAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderItemFulfillmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderItemFulfillmentsAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderItemFulfillmentsAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderLinesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderLinesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderLinesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderNotesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderNotesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderNoteAsync(
        ExsitedClient client,
        string orderId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderNoteAsync(
            orderId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderPaymentMethodsAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderPaymentMethodsAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderPaymentMethodsAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderPdfAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderPdfAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderPdfAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ReactivateOrderAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ReactivateOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderRelinquishAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderRelinquishAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderRelinquishAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpdateOrderLineAsync</c>.</summary>
    public static Task<ApiResponse> UpdateOrderLineAsync(
        ExsitedClient client,
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpdateOrderLineAsync(
            orderId, lineUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderLineAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderLineAsync(
        ExsitedClient client,
        string orderId, string lineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderLineAsync(
            orderId, lineUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.DeleteOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteOrderNoteAsync(
        ExsitedClient client,
        string orderId, string orderNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.DeleteOrderNoteAsync(
            orderId, orderNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderNoteAsync(
        ExsitedClient client,
        string orderId, string orderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderNoteAsync(
            orderId, orderNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpdateOrderNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateOrderNoteAsync(
        ExsitedClient client,
        string orderId, string orderNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpdateOrderNoteAsync(
            orderId, orderNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderPaymentMethodAsync(
        ExsitedClient client,
        string orderId, string paymentMethodRef, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderPaymentMethodAsync(
            orderId, paymentMethodRef, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpdateOrderLineBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> UpdateOrderLineBillingPreferencesAsync(
        ExsitedClient client,
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpdateOrderLineBillingPreferencesAsync(
            orderId, lineUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ReplaceOrderLineBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceOrderLineBillingPreferencesAsync(
        ExsitedClient client,
        string orderId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ReplaceOrderLineBillingPreferencesAsync(
            orderId, lineUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderNoteFilesAsync(
        ExsitedClient client,
        string orderId, string orderNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderNoteFilesAsync(
            orderId, orderNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderNoteFileAsync(
        ExsitedClient client,
        string orderId, string orderNoteId, string orderFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderNoteFileAsync(
            orderId, orderNoteId, orderFileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Orders.GetOrdersNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrdersNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrdersNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.PreviewOrderAsync</c>.</summary>
    public static Task<ApiResponse> PreviewOrderAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.PreviewOrderAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.CreateOrderExpressAsync</c>.</summary>
    public static Task<ApiResponse> CreateOrderExpressAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.CreateOrderExpressAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.AcceptOrderAsync</c>.</summary>
    public static Task<ApiResponse> AcceptOrderAsync(
        ExsitedClient client,
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.AcceptOrderAsync(
            orderId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ActivateOrderInvoiceFromDormantAsync</c>.</summary>
    public static Task<ApiResponse> ActivateOrderInvoiceFromDormantAsync(
        ExsitedClient client,
        string orderId, string invoiceUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ActivateOrderInvoiceFromDormantAsync(
            orderId, invoiceUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.PreviewOrderChangeAsync</c>.</summary>
    public static Task<ApiResponse> PreviewOrderChangeAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.PreviewOrderChangeAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.ChangeOrderStatusAsync</c>.</summary>
    public static Task<ApiResponse> ChangeOrderStatusAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.ChangeOrderStatusAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.AdjustOrderContractAsync</c>.</summary>
    public static Task<ApiResponse> AdjustOrderContractAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.AdjustOrderContractAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.PreviewOrderContractAdjustmentAsync</c>.</summary>
    public static Task<ApiResponse> PreviewOrderContractAdjustmentAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.PreviewOrderContractAdjustmentAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.DowngradeOrderAsync</c>.</summary>
    public static Task<ApiResponse> DowngradeOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.DowngradeOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.PreviewOrderDowngradeAsync</c>.</summary>
    public static Task<ApiResponse> PreviewOrderDowngradeAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.PreviewOrderDowngradeAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.UpgradeOrderAsync</c>.</summary>
    public static Task<ApiResponse> UpgradeOrderAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.UpgradeOrderAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.PreviewOrderUpgradeAsync</c>.</summary>
    public static Task<ApiResponse> PreviewOrderUpgradeAsync(
        ExsitedClient client,
        string orderId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.PreviewOrderUpgradeAsync(
            orderId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.TerminateOrderTrialAsync</c>.</summary>
    public static Task<ApiResponse> TerminateOrderTrialAsync(
        ExsitedClient client,
        string orderId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.TerminateOrderTrialAsync(
            orderId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.DeleteOrderNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteOrderNoteFileAsync(
        ExsitedClient client,
        string orderId, string orderNoteId, string orderFileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.DeleteOrderNoteFileAsync(
            orderId, orderNoteId, orderFileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectAsync(
        ExsitedClient client,
        string orderId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectAsync(
            orderId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectInstanceAsync(
        ExsitedClient client,
        string orderId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectInstanceAsync(
            orderId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectsInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectsInstanceAsync(
        ExsitedClient client,
        string orderId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectsInstanceAsync(
            orderId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderCustomObjectsInstanceInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderCustomObjectsInstanceInstanceAsync(
        ExsitedClient client,
        string orderId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderCustomObjectsInstanceInstanceAsync(
            orderId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderItemFulfillmentAsync(
        ExsitedClient client,
        string orderId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderItemFulfillmentAsync(
            orderId, fulfillmentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderKpisAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderKpisAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderPaymentAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderPaymentAsync(
        ExsitedClient client,
        string orderId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderPaymentAsync(
            orderId, paymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderQuotePartialInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderQuotePartialInvoicesAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderQuotePartialInvoicesAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Orders.GetOrderShippingPdfAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderShippingPdfAsync(
        ExsitedClient client,
        string orderId, string shippingLineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Orders.GetOrderShippingPdfAsync(
            orderId, shippingLineId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
