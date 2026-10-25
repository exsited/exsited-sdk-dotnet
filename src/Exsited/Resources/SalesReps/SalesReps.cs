using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.SalesReps.SalesRepsDto;

namespace Exsited.Resources.SalesReps;

/// <summary>The v4 sales reps endpoints, as a typed resource bound to one client.</summary>
public sealed class SalesReps : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.SalesReps</c>.</summary>
    public SalesReps(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/sales_reps</c>.</summary>
    public Task<ApiResponse> GetSettingsSalesRepsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SalesRepsUrls.SettingsSalesReps,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalesRepList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/sales_reps</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsSalesRepAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SalesRepsUrls.SettingsSalesReps,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/sales_reps/{sales_rep_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsSalesRepAsync(
        string salesRepId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SalesRepsUrls.SettingsSalesRep,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["sales_rep_id"] = salesRepId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalesRep),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/sales_reps/{sales_rep_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsSalesRepAsync(
        string salesRepId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SalesRepsUrls.SettingsSalesRep,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["sales_rep_id"] = salesRepId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/sales_reps/{sales_rep_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsSalesRepAsync(
        string salesRepId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SalesRepsUrls.SettingsSalesRep,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["sales_rep_id"] = salesRepId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.SalesReps.GetSettingsSalesRepsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSalesRepsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SalesReps.GetSettingsSalesRepsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SalesReps.CreateSettingsSalesRepAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsSalesRepAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SalesReps.CreateSettingsSalesRepAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SalesReps.GetSettingsSalesRepAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSalesRepAsync(
        ExsitedClient client,
        string salesRepId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SalesReps.GetSettingsSalesRepAsync(
            salesRepId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SalesReps.DeleteSettingsSalesRepAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsSalesRepAsync(
        ExsitedClient client,
        string salesRepId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SalesReps.DeleteSettingsSalesRepAsync(
            salesRepId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SalesReps.UpdateSettingsSalesRepAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsSalesRepAsync(
        ExsitedClient client,
        string salesRepId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SalesReps.UpdateSettingsSalesRepAsync(
            salesRepId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
