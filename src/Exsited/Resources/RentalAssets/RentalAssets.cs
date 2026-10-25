using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.RentalAssets.RentalAssetsDto;

namespace Exsited.Resources.RentalAssets;

/// <summary>The v4 rental assets endpoints, as a typed resource bound to one client.</summary>
public sealed class RentalAssets : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.RentalAssets</c>.</summary>
    public RentalAssets(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/rental_asset_availability</c>.</summary>
    public Task<ApiResponse> GetRentalAssetAvailabilityAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RentalAssetsUrls.RentalAssetAvailability,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetAvailabilityList),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/rental_asset_availability</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateRentalAssetAvailabilityAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(RentalAssetsUrls.RentalAssetAvailability,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/rental_asset_profiles</c>.</summary>
    public Task<ApiResponse> GetRentalAssetProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RentalAssetsUrls.RentalAssetProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetProfileList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/rental_asset_profiles</c>.</summary>
    public Task<ApiResponse> CreateRentalAssetProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RentalAssetsUrls.RentalAssetProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetProfiles),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/rental_assets</c>.</summary>
    public Task<ApiResponse> GetRentalAssetsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RentalAssetsUrls.RentalAssets,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/rental_assets</c>.</summary>
    public Task<ApiResponse> CreateRentalAssetAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RentalAssetsUrls.RentalAssets,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetsView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}</c>.</summary>
    public Task<ApiResponse> GetRentalAssetProfileAsync(
        string rentalAssetProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RentalAssetsUrls.RentalAssetProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_profile_id"] = rentalAssetProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetProfileRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateRentalAssetProfileAsync(
        string rentalAssetProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(RentalAssetsUrls.RentalAssetProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_profile_id"] = rentalAssetProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteRentalAssetProfileAsync(
        string rentalAssetProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RentalAssetsUrls.RentalAssetProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_profile_id"] = rentalAssetProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/rental_assets/{rental_asset_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateRentalAssetAsync(
        string rentalAssetUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(RentalAssetsUrls.RentalAsset,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_uuid"] = rentalAssetUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/rental_assets/{rental_asset_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteRentalAssetAsync(
        string rentalAssetUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RentalAssetsUrls.RentalAsset,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_uuid"] = rentalAssetUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/rental_assets/{rental_asset_uuid}</c>.</summary>
    public Task<ApiResponse> GetRentalAssetAsync(
        string rentalAssetUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RentalAssetsUrls.RentalAsset,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_uuid"] = rentalAssetUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAsset),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/rental_assets/{rental_asset_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelRentalAssetAsync(
        string rentalAssetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RentalAssetsUrls.RentalAssetCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_id"] = rentalAssetId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetCancel),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/rental_assets/{rental_asset_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivateRentalAssetAsync(
        string rentalAssetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RentalAssetsUrls.RentalAssetReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["rental_asset_id"] = rentalAssetId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RentalAssetReactivate),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.RentalAssets.GetRentalAssetAvailabilityAsync</c>.</summary>
    public static Task<ApiResponse> GetRentalAssetAvailabilityAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.GetRentalAssetAvailabilityAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.UpdateRentalAssetAvailabilityAsync</c>.</summary>
    public static Task<ApiResponse> UpdateRentalAssetAvailabilityAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.UpdateRentalAssetAvailabilityAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.GetRentalAssetProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetRentalAssetProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.GetRentalAssetProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.CreateRentalAssetProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateRentalAssetProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.CreateRentalAssetProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.GetRentalAssetsAsync</c>.</summary>
    public static Task<ApiResponse> GetRentalAssetsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.GetRentalAssetsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.CreateRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> CreateRentalAssetAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.CreateRentalAssetAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.GetRentalAssetProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetRentalAssetProfileAsync(
        ExsitedClient client,
        string rentalAssetProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.GetRentalAssetProfileAsync(
            rentalAssetProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.UpdateRentalAssetProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateRentalAssetProfileAsync(
        ExsitedClient client,
        string rentalAssetProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.UpdateRentalAssetProfileAsync(
            rentalAssetProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.DeleteRentalAssetProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteRentalAssetProfileAsync(
        ExsitedClient client,
        string rentalAssetProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.DeleteRentalAssetProfileAsync(
            rentalAssetProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.UpdateRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> UpdateRentalAssetAsync(
        ExsitedClient client,
        string rentalAssetUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.UpdateRentalAssetAsync(
            rentalAssetUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.DeleteRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> DeleteRentalAssetAsync(
        ExsitedClient client,
        string rentalAssetUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.DeleteRentalAssetAsync(
            rentalAssetUuid, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.GetRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> GetRentalAssetAsync(
        ExsitedClient client,
        string rentalAssetUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.GetRentalAssetAsync(
            rentalAssetUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.CancelRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> CancelRentalAssetAsync(
        ExsitedClient client,
        string rentalAssetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.CancelRentalAssetAsync(
            rentalAssetId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.RentalAssets.ReactivateRentalAssetAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateRentalAssetAsync(
        ExsitedClient client,
        string rentalAssetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.RentalAssets.ReactivateRentalAssetAsync(
            rentalAssetId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
