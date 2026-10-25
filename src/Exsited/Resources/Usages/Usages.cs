using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Usages.UsagesDto;

namespace Exsited.Resources.Usages;

/// <summary>The v4 usages endpoints, as a typed resource bound to one client.</summary>
public sealed class Usages : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Usages</c>.</summary>
    public Usages(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/usages</c>.</summary>
    public Task<ApiResponse> GetUsagesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UsagesUrls.Usages,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UsageList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/usages</c>.</summary>
    public Task<ApiResponse> CreateUsageAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(UsagesUrls.Usages,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UsagesView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/usages/{usage_id}</c>.</summary>
    public Task<ApiResponse> GetUsageAsync(
        string usageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UsagesUrls.Usage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["usage_id"] = usageId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Usage),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/usages/{usage_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteUsageAsync(
        string usageId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(UsagesUrls.Usage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["usage_id"] = usageId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/usages/{usage_id}</c>.</summary>
    public Task<ApiResponse> UpdateUsageAsync(
        string usageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(UsagesUrls.Usage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["usage_id"] = usageId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UsageUpdated),
            }, cancellationToken);
    }

    /// <summary><c>PUT /api/{api_version}/usages/{usage_id}</c>.</summary>
    public Task<ApiResponse> ReplaceUsageAsync(
        string usageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPutRequestAsync(UsagesUrls.Usage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["usage_id"] = usageId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UsageUpdated),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Usages.GetUsagesAsync</c>.</summary>
    public static Task<ApiResponse> GetUsagesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.GetUsagesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Usages.CreateUsageAsync</c>.</summary>
    public static Task<ApiResponse> CreateUsageAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.CreateUsageAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Usages.GetUsageAsync</c>.</summary>
    public static Task<ApiResponse> GetUsageAsync(
        ExsitedClient client,
        string usageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.GetUsageAsync(
            usageId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Usages.DeleteUsageAsync</c>.</summary>
    public static Task<ApiResponse> DeleteUsageAsync(
        ExsitedClient client,
        string usageId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.DeleteUsageAsync(
            usageId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Usages.UpdateUsageAsync</c>.</summary>
    public static Task<ApiResponse> UpdateUsageAsync(
        ExsitedClient client,
        string usageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.UpdateUsageAsync(
            usageId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Usages.ReplaceUsageAsync</c>.</summary>
    public static Task<ApiResponse> ReplaceUsageAsync(
        ExsitedClient client,
        string usageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Usages.ReplaceUsageAsync(
            usageId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
