using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Uom.UomDto;

namespace Exsited.Resources.Uom;

/// <summary>The v4 uom endpoints, as a typed resource bound to one client.</summary>
public sealed class Uom : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Uom</c>.</summary>
    public Uom(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/uom</c>.</summary>
    public Task<ApiResponse> GetSettingsUomsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UomUrls.SettingsUoms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsUomList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/uom</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsUomAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(UomUrls.SettingsUoms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/uom/{uom_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsUomAsync(
        string uomId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UomUrls.SettingsUom,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["uom_id"] = uomId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsUom),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/uom/{uom_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsUomAsync(
        string uomId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(UomUrls.SettingsUom,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["uom_id"] = uomId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/uom/{uom_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsUomAsync(
        string uomId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(UomUrls.SettingsUom,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["uom_id"] = uomId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Uom.GetSettingsUomsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsUomsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Uom.GetSettingsUomsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Uom.CreateSettingsUomAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsUomAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Uom.CreateSettingsUomAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Uom.GetSettingsUomAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsUomAsync(
        ExsitedClient client,
        string uomId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Uom.GetSettingsUomAsync(
            uomId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Uom.DeleteSettingsUomAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsUomAsync(
        ExsitedClient client,
        string uomId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Uom.DeleteSettingsUomAsync(
            uomId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Uom.UpdateSettingsUomAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsUomAsync(
        ExsitedClient client,
        string uomId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Uom.UpdateSettingsUomAsync(
            uomId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
