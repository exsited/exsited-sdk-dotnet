using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Approvals.ApprovalsDto;

namespace Exsited.Resources.Approvals;

/// <summary>The v4 approvals endpoints, as a typed resource bound to one client.</summary>
public sealed class Approvals : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Approvals</c>.</summary>
    public Approvals(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/approvals/account</c>.</summary>
    public Task<ApiResponse> GetApprovalsAccountAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalsUrls.ApprovalsAccount,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ApprovalsAccountList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/approvals/saleOrder</c>.</summary>
    public Task<ApiResponse> GetApprovalsSaleorderAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalsUrls.ApprovalsSaleorder,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ApprovalsSaleorder),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/approvals/account/{account_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetApprovalsAccountByUuidAsync(
        string accountUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalsUrls.ApprovalsAccountByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_uuid"] = accountUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/approvals/approve</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ApproveApprovalAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ApprovalsUrls.ApprovalsApprove,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/approvals/reject</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> RejectApprovalAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ApprovalsUrls.ApprovalsReject,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Approvals.GetApprovalsAccountAsync</c>.</summary>
    public static Task<ApiResponse> GetApprovalsAccountAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Approvals.GetApprovalsAccountAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Approvals.GetApprovalsSaleorderAsync</c>.</summary>
    public static Task<ApiResponse> GetApprovalsSaleorderAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Approvals.GetApprovalsSaleorderAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Approvals.GetApprovalsAccountByUuidAsync</c>.</summary>
    public static Task<ApiResponse> GetApprovalsAccountByUuidAsync(
        ExsitedClient client,
        string accountUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Approvals.GetApprovalsAccountByUuidAsync(
            accountUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Approvals.ApproveApprovalAsync</c>.</summary>
    public static Task<ApiResponse> ApproveApprovalAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Approvals.ApproveApprovalAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Approvals.RejectApprovalAsync</c>.</summary>
    public static Task<ApiResponse> RejectApprovalAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Approvals.RejectApprovalAsync(
            payload, raiseOnError, cancellationToken, responseFormat);


    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
