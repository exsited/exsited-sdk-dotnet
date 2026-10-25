using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CustomFeatures.CustomFeaturesDto;

namespace Exsited.Resources.CustomFeatures;

/// <summary>The v4 custom features endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomFeatures : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomFeatures</c>.</summary>
    public CustomFeatures(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/custom_feature</c>.</summary>
    public Task<ApiResponse> CreateCustomFeatureAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomFeaturesUrls.CustomFeature,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomFeature),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/component/{custom_feature_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentByIdAsync(
        string customFeatureId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomFeaturesUrls.ComponentById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_feature_id"] = customFeatureId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/custom_feature/{custom_feature_id}</c>.</summary>
    public Task<ApiResponse> UpdateCustomFeatureByIdAsync(
        string customFeatureId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomFeaturesUrls.CustomFeatureById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_feature_id"] = customFeatureId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomFeature),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/custom_feature/{custom_feature_id}</c>.</summary>
    public Task<ApiResponse> CreateCustomFeatureByIdAsync(
        string customFeatureId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomFeaturesUrls.CustomFeatureById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_feature_id"] = customFeatureId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomFeature),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/custom_feature</c>.</summary>
    public Task<ApiResponse> GetCustomFeaturesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFeaturesUrls.CustomFeature,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomFeatureList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/custom_feature/{custom_feature_id}</c>.</summary>
    public Task<ApiResponse> GetCustomFeatureByIdAsync(
        string customFeatureId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFeaturesUrls.CustomFeatureById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_feature_id"] = customFeatureId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomFeature),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/custom_feature/{custom_feature_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteCustomFeatureByIdAsync(
        string customFeatureId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomFeaturesUrls.CustomFeatureById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_feature_id"] = customFeatureId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.CustomFeatures.CreateCustomFeatureAsync</c>.</summary>
    public static Task<ApiResponse> CreateCustomFeatureAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.CreateCustomFeatureAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.DeleteComponentByIdAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentByIdAsync(
        ExsitedClient client,
        string customFeatureId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.DeleteComponentByIdAsync(
            customFeatureId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.UpdateCustomFeatureByIdAsync</c>.</summary>
    public static Task<ApiResponse> UpdateCustomFeatureByIdAsync(
        ExsitedClient client,
        string customFeatureId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.UpdateCustomFeatureByIdAsync(
            customFeatureId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.CreateCustomFeatureByIdAsync</c>.</summary>
    public static Task<ApiResponse> CreateCustomFeatureByIdAsync(
        ExsitedClient client,
        string customFeatureId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.CreateCustomFeatureByIdAsync(
            customFeatureId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.GetCustomFeaturesAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomFeaturesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.GetCustomFeaturesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.GetCustomFeatureByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomFeatureByIdAsync(
        ExsitedClient client,
        string customFeatureId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.GetCustomFeatureByIdAsync(
            customFeatureId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFeatures.DeleteCustomFeatureByIdAsync</c>.</summary>
    public static Task<ApiResponse> DeleteCustomFeatureByIdAsync(
        ExsitedClient client,
        string customFeatureId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFeatures.DeleteCustomFeatureByIdAsync(
            customFeatureId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
