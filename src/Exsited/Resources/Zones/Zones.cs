using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Zones.ZonesDto;

namespace Exsited.Resources.Zones;

/// <summary>The v4 zones endpoints, as a typed resource bound to one client.</summary>
public sealed class Zones : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Zones</c>.</summary>
    public Zones(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/zones</c>.</summary>
    public Task<ApiResponse> GetSettingsZonesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ZonesUrls.SettingsZones,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsZoneList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/zones</c>.</summary>
    public Task<ApiResponse> CreateSettingsZoneAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ZonesUrls.SettingsZones,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsZone),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/zones/{zone_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsZoneAsync(
        string zoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ZonesUrls.SettingsZone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["zone_id"] = zoneId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsZone),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/zones/{zone_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsZoneAsync(
        string zoneId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ZonesUrls.SettingsZone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["zone_id"] = zoneId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/zones/{zone_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsZoneAsync(
        string zoneId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ZonesUrls.SettingsZone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["zone_id"] = zoneId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsZone),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Zones.GetSettingsZonesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsZonesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Zones.GetSettingsZonesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Zones.CreateSettingsZoneAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsZoneAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Zones.CreateSettingsZoneAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Zones.GetSettingsZoneAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsZoneAsync(
        ExsitedClient client,
        string zoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Zones.GetSettingsZoneAsync(
            zoneId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Zones.DeleteSettingsZoneAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsZoneAsync(
        ExsitedClient client,
        string zoneId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Zones.DeleteSettingsZoneAsync(
            zoneId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Zones.UpdateSettingsZoneAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsZoneAsync(
        ExsitedClient client,
        string zoneId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Zones.UpdateSettingsZoneAsync(
            zoneId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
