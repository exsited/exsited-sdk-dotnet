using Exsited.Client;
using Exsited.Resources.Milestones.MilestonesDto;

namespace Exsited.Resources.Milestones;

/// <summary>The v4 milestones endpoints, as a typed resource bound to one client.</summary>
public sealed class Milestones : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Milestones</c>.</summary>
    public Milestones(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/milestones</c>.</summary>
    public Task<ApiResponse> GetMilestonesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(MilestonesUrls.Milestones,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(MilestonesView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/milestones/account/{account_id}</c>.</summary>
    public Task<ApiResponse> GetMilestonesAccountByIdAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(MilestonesUrls.MilestonesAccountById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(MilestonesView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/milestones/labour/{labour_id}</c>.</summary>
    public Task<ApiResponse> GetMilestonesLabourByIdAsync(
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(MilestonesUrls.MilestonesLabourById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_id"] = labourId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(MilestonesLabourList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/milestones/employee/{employee_code}</c>.</summary>
    public Task<ApiResponse> GetMilestonesEmployeeByCodeAsync(
        string employeeCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(MilestonesUrls.MilestonesEmployeeByCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["employee_code"] = employeeCode },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(MilestonesView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/milestones/{milestone_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetMilestoneAsync(
        string milestoneUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(MilestonesUrls.Milestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["milestone_uuid"] = milestoneUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Milestones.GetMilestonesAsync</c>.</summary>
    public static Task<ApiResponse> GetMilestonesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Milestones.GetMilestonesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Milestones.GetMilestonesAccountByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetMilestonesAccountByIdAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Milestones.GetMilestonesAccountByIdAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Milestones.GetMilestonesLabourByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetMilestonesLabourByIdAsync(
        ExsitedClient client,
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Milestones.GetMilestonesLabourByIdAsync(
            labourId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Milestones.GetMilestonesEmployeeByCodeAsync</c>.</summary>
    public static Task<ApiResponse> GetMilestonesEmployeeByCodeAsync(
        ExsitedClient client,
        string employeeCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Milestones.GetMilestonesEmployeeByCodeAsync(
            employeeCode, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Milestones.GetMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> GetMilestoneAsync(
        ExsitedClient client,
        string milestoneUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Milestones.GetMilestoneAsync(
            milestoneUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

}
