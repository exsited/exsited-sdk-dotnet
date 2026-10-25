using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchaseRefunds.PurchaseRefundsDto;

namespace Exsited.Resources.PurchaseRefunds;

/// <summary>The v4 purchase refunds endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseRefunds : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseRefunds</c>.</summary>
    public PurchaseRefunds(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_refunds</c>.</summary>
    public Task<ApiResponse> GetPurchaseRefundsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseRefundsUrls.PurchaseRefunds,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseRefundsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_refunds/{purchase_refund_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseRefundAsync(
        string purchaseRefundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseRefundsUrls.PurchaseRefund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_refund_id"] = purchaseRefundId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseRefund),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/purchase_refunds</c>.</summary>
    public Task<ApiResponse> CreatePurchaseCreditNotePurchaseRefundAsync(
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseRefundsUrls.PurchaseCreditNotePurchaseRefunds,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseRefund),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/purchase_refunds/{purchase_refund_id}</c>.</summary>
    public Task<ApiResponse> UpdatePurchaseRefundAsync(
        string purchaseRefundId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PurchaseRefundsUrls.PurchaseRefund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_refund_id"] = purchaseRefundId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseRefund),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/purchase_refunds/{purchase_refund_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseRefundAsync(
        string purchaseRefundId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseRefundsUrls.PurchaseRefund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_refund_id"] = purchaseRefundId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchaseRefunds.GetPurchaseRefundsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseRefundsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseRefunds.GetPurchaseRefundsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseRefunds.GetPurchaseRefundAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseRefundAsync(
        ExsitedClient client,
        string purchaseRefundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseRefunds.GetPurchaseRefundAsync(
            purchaseRefundId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseRefunds.CreatePurchaseCreditNotePurchaseRefundAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseCreditNotePurchaseRefundAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseRefunds.CreatePurchaseCreditNotePurchaseRefundAsync(
            purchaseCreditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseRefunds.UpdatePurchaseRefundAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchaseRefundAsync(
        ExsitedClient client,
        string purchaseRefundId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseRefunds.UpdatePurchaseRefundAsync(
            purchaseRefundId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseRefunds.DeletePurchaseRefundAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseRefundAsync(
        ExsitedClient client,
        string purchaseRefundId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseRefunds.DeletePurchaseRefundAsync(
            purchaseRefundId, raiseOnError, cancellationToken, responseFormat);


    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
