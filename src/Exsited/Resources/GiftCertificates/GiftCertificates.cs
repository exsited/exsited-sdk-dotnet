using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.GiftCertificates.GiftCertificatesDto;

namespace Exsited.Resources.GiftCertificates;

/// <summary>The v4 gift certificates endpoints, as a typed resource bound to one client.</summary>
public sealed class GiftCertificates : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.GiftCertificates</c>.</summary>
    public GiftCertificates(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/gift_certificates</c>.</summary>
    public Task<ApiResponse> GetGiftCertificatesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificates,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/gift_certificates</c>.</summary>
    public Task<ApiResponse> CreateGiftCertificateAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(GiftCertificatesUrls.GiftCertificates,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificatesView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/gift_certificates/{gc_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteGiftCertificateAsync(
        string gcId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(GiftCertificatesUrls.GiftCertificate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/gift_certificates/{gc_id}</c>.</summary>
    public Task<ApiResponse> GetGiftCertificateAsync(
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificate),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/gift_certificates/{gc_id}</c>.</summary>
    public Task<ApiResponse> UpdateGiftCertificateAsync(
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(GiftCertificatesUrls.GiftCertificate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/gift_certificates/{gc_id}/allocations</c>.</summary>
    public Task<ApiResponse> GetGiftCertificateAllocationsAsync(
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificateAllocations,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateAllocations),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/gift_certificates/{gc_id}/transactions</c>.</summary>
    public Task<ApiResponse> GetGiftCertificateTransactionsAsync(
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificateTransactions,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateTransactionList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/gift_certificates/{gc_id}/amend</c>.</summary>
    public Task<ApiResponse> AmendGiftCertificateAsync(
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(GiftCertificatesUrls.GiftCertificateAmend,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificate),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/gift_certificates/{gc_id}/allocations</c>.</summary>
    public Task<ApiResponse> AllocateGiftCertificateAsync(
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(GiftCertificatesUrls.GiftCertificateAllocations,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificate),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/gift_certificates/{gc_id}/deallocations</c>.</summary>
    public Task<ApiResponse> DeallocateGiftCertificateAsync(
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(GiftCertificatesUrls.GiftCertificateDeallocations,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/gift_certificates/{gc_id}/allocations/{allocation_id}</c>.</summary>
    public Task<ApiResponse> GetGiftCertificateAllocationAsync(
        string gcId, string allocationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificateAllocation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId, ["allocation_id"] = allocationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateAllocationRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/gift_certificates/{gc_id}/transactions/{transaction_id}</c>.</summary>
    public Task<ApiResponse> GetGiftCertificateTransactionAsync(
        string gcId, string transactionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(GiftCertificatesUrls.GiftCertificateTransaction,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["gc_id"] = gcId, ["transaction_id"] = transactionId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(GiftCertificateTransactionRead),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificatesAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificatesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificatesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.CreateGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> CreateGiftCertificateAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.CreateGiftCertificateAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.DeleteGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> DeleteGiftCertificateAsync(
        ExsitedClient client,
        string gcId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.DeleteGiftCertificateAsync(
            gcId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificateAsync(
        ExsitedClient client,
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificateAsync(
            gcId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.UpdateGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> UpdateGiftCertificateAsync(
        ExsitedClient client,
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.UpdateGiftCertificateAsync(
            gcId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificateAllocationsAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificateAllocationsAsync(
        ExsitedClient client,
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificateAllocationsAsync(
            gcId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificateTransactionsAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificateTransactionsAsync(
        ExsitedClient client,
        string gcId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificateTransactionsAsync(
            gcId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.AmendGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> AmendGiftCertificateAsync(
        ExsitedClient client,
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.AmendGiftCertificateAsync(
            gcId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.AllocateGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> AllocateGiftCertificateAsync(
        ExsitedClient client,
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.AllocateGiftCertificateAsync(
            gcId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.DeallocateGiftCertificateAsync</c>.</summary>
    public static Task<ApiResponse> DeallocateGiftCertificateAsync(
        ExsitedClient client,
        string gcId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.DeallocateGiftCertificateAsync(
            gcId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificateAllocationAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificateAllocationAsync(
        ExsitedClient client,
        string gcId, string allocationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificateAllocationAsync(
            gcId, allocationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.GiftCertificates.GetGiftCertificateTransactionAsync</c>.</summary>
    public static Task<ApiResponse> GetGiftCertificateTransactionAsync(
        ExsitedClient client,
        string gcId, string transactionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.GiftCertificates.GetGiftCertificateTransactionAsync(
            gcId, transactionId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
