using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.FulfillmentProfiles.FulfillmentProfilesDto;

namespace Exsited.Resources.FulfillmentProfiles;

/// <summary>The v4 fulfillment profiles endpoints, as a typed resource bound to one client.</summary>
public sealed class FulfillmentProfiles : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.FulfillmentProfiles</c>.</summary>
    public FulfillmentProfiles(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/fulfillment_profiles</c>.</summary>
    public Task<ApiResponse> GetSettingsFulfillmentProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(FulfillmentProfilesUrls.SettingsFulfillmentProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentProfileList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/fulfillment_profiles</c>.</summary>
    public Task<ApiResponse> CreateSettingsFulfillmentProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(FulfillmentProfilesUrls.SettingsFulfillmentProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentProfile),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/fulfillment_profiles/{fulfillment_profile_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsFulfillmentProfileAsync(
        string fulfillmentProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(FulfillmentProfilesUrls.SettingsFulfillmentProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_profile_id"] = fulfillmentProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentProfile),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/fulfillment_profiles/{fulfillment_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsFulfillmentProfileAsync(
        string fulfillmentProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(FulfillmentProfilesUrls.SettingsFulfillmentProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_profile_id"] = fulfillmentProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/fulfillment_profiles/{fulfillment_profile_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsFulfillmentProfileAsync(
        string fulfillmentProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(FulfillmentProfilesUrls.SettingsFulfillmentProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_profile_id"] = fulfillmentProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentProfile),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.FulfillmentProfiles.GetSettingsFulfillmentProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFulfillmentProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentProfiles.GetSettingsFulfillmentProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentProfiles.CreateSettingsFulfillmentProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsFulfillmentProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentProfiles.CreateSettingsFulfillmentProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentProfiles.GetSettingsFulfillmentProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFulfillmentProfileAsync(
        ExsitedClient client,
        string fulfillmentProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentProfiles.GetSettingsFulfillmentProfileAsync(
            fulfillmentProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentProfiles.DeleteSettingsFulfillmentProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsFulfillmentProfileAsync(
        ExsitedClient client,
        string fulfillmentProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentProfiles.DeleteSettingsFulfillmentProfileAsync(
            fulfillmentProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentProfiles.UpdateSettingsFulfillmentProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsFulfillmentProfileAsync(
        ExsitedClient client,
        string fulfillmentProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentProfiles.UpdateSettingsFulfillmentProfileAsync(
            fulfillmentProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
