using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CustomAttributes.CustomAttributesDto;

namespace Exsited.Resources.CustomAttributes;

/// <summary>The v4 custom attributes endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomAttributes : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomAttributes</c>.</summary>
    public CustomAttributes(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/custom_attributes</c>.</summary>
    public Task<ApiResponse> GetCustomAttributesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomAttributesUrls.CustomAttributes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomAttributeList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/custom_attributes</c>.</summary>
    public Task<ApiResponse> CreateCustomAttributeAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomAttributesUrls.CustomAttributes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomAttributesView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/custom_attributes/{custom_attribute_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteCustomAttributeAsync(
        string customAttributeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomAttributesUrls.CustomAttribute,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_attribute_id"] = customAttributeId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/custom_attributes/{custom_attribute_id}</c>.</summary>
    public Task<ApiResponse> GetCustomAttributeAsync(
        string customAttributeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomAttributesUrls.CustomAttribute,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_attribute_id"] = customAttributeId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomAttribute),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/custom_attributes/{custom_attribute_id}</c>.</summary>
    public Task<ApiResponse> UpdateCustomAttributeAsync(
        string customAttributeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomAttributesUrls.CustomAttribute,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_attribute_id"] = customAttributeId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CustomAttributeUpdated),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.CustomAttributes.GetCustomAttributesAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomAttributesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomAttributes.GetCustomAttributesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomAttributes.CreateCustomAttributeAsync</c>.</summary>
    public static Task<ApiResponse> CreateCustomAttributeAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomAttributes.CreateCustomAttributeAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomAttributes.DeleteCustomAttributeAsync</c>.</summary>
    public static Task<ApiResponse> DeleteCustomAttributeAsync(
        ExsitedClient client,
        string customAttributeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomAttributes.DeleteCustomAttributeAsync(
            customAttributeId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomAttributes.GetCustomAttributeAsync</c>.</summary>
    public static Task<ApiResponse> GetCustomAttributeAsync(
        ExsitedClient client,
        string customAttributeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomAttributes.GetCustomAttributeAsync(
            customAttributeId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomAttributes.UpdateCustomAttributeAsync</c>.</summary>
    public static Task<ApiResponse> UpdateCustomAttributeAsync(
        ExsitedClient client,
        string customAttributeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomAttributes.UpdateCustomAttributeAsync(
            customAttributeId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
