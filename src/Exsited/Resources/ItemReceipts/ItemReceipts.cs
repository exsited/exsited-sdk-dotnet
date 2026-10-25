using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ItemReceipts.ItemReceiptsDto;

namespace Exsited.Resources.ItemReceipts;

/// <summary>The v4 item receipts endpoints, as a typed resource bound to one client.</summary>
public sealed class ItemReceipts : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ItemReceipts</c>.</summary>
    public ItemReceipts(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/item_receipts</c>.</summary>
    public Task<ApiResponse> GetItemReceiptsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemReceiptsUrls.ItemReceipts,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemReceiptList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/item_receipts</c>.</summary>
    public Task<ApiResponse> CreateItemReceiptAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemReceiptsUrls.ItemReceipts,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemReceiptsView),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/item_receipts/{item_receipt_id}</c>.</summary>
    public Task<ApiResponse> UpdateItemReceiptAsync(
        string itemReceiptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemReceiptsUrls.ItemReceipt,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_receipt_id"] = itemReceiptId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemReceiptUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/item_receipts/{item_receipt_id}</c>.</summary>
    public Task<ApiResponse> GetItemReceiptAsync(
        string itemReceiptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemReceiptsUrls.ItemReceipt,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_receipt_id"] = itemReceiptId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemReceipt),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/item_receipts</c>.</summary>
    public Task<ApiResponse> GetPurchaseOrderItemReceiptsAsync(
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemReceiptsUrls.PurchaseOrderItemReceipts,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_order_id"] = purchaseOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseOrderItemReceipts),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/item_receipts/{item_receipt_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemReceiptAsync(
        string itemReceiptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemReceiptsUrls.ItemReceipt,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_receipt_id"] = itemReceiptId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/item_receipts/{item_receipt_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemReceiptNoteAsync(
        string itemReceiptId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemReceiptsUrls.ItemReceiptNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["item_receipt_id"] = itemReceiptId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ItemReceipts.GetItemReceiptsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemReceiptsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.GetItemReceiptsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.CreateItemReceiptAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemReceiptAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.CreateItemReceiptAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.UpdateItemReceiptAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemReceiptAsync(
        ExsitedClient client,
        string itemReceiptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.UpdateItemReceiptAsync(
            itemReceiptId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.GetItemReceiptAsync</c>.</summary>
    public static Task<ApiResponse> GetItemReceiptAsync(
        ExsitedClient client,
        string itemReceiptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.GetItemReceiptAsync(
            itemReceiptId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.GetPurchaseOrderItemReceiptsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseOrderItemReceiptsAsync(
        ExsitedClient client,
        string purchaseOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.GetPurchaseOrderItemReceiptsAsync(
            purchaseOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.DeleteItemReceiptAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemReceiptAsync(
        ExsitedClient client,
        string itemReceiptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.DeleteItemReceiptAsync(
            itemReceiptId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemReceipts.DeleteItemReceiptNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemReceiptNoteAsync(
        ExsitedClient client,
        string itemReceiptId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemReceipts.DeleteItemReceiptNoteAsync(
            itemReceiptId, noteId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
