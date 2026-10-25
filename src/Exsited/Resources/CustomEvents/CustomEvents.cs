using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CustomEvents.CustomEventsDto;

namespace Exsited.Resources.CustomEvents;

/// <summary>The v4 custom events endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomEvents : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomEvents</c>.</summary>
    public CustomEvents(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_events</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomEventsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomEventsUrls.SettingsCustomEvents,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomEventList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/custom_events</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsCustomEventAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomEventsUrls.SettingsCustomEvents,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_events/{custom_event_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomEventAsync(
        string customEventId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomEventsUrls.SettingsCustomEvent,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_event_id"] = customEventId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomEvent),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/custom_events/{custom_event_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsCustomEventAsync(
        string customEventId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomEventsUrls.SettingsCustomEvent,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_event_id"] = customEventId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/custom_events/{custom_event_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCustomEventAsync(
        string customEventId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomEventsUrls.SettingsCustomEvent,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_event_id"] = customEventId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.CustomEvents.GetSettingsCustomEventsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomEventsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomEvents.GetSettingsCustomEventsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomEvents.CreateSettingsCustomEventAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCustomEventAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomEvents.CreateSettingsCustomEventAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomEvents.GetSettingsCustomEventAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomEventAsync(
        ExsitedClient client,
        string customEventId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomEvents.GetSettingsCustomEventAsync(
            customEventId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomEvents.DeleteSettingsCustomEventAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsCustomEventAsync(
        ExsitedClient client,
        string customEventId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomEvents.DeleteSettingsCustomEventAsync(
            customEventId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomEvents.UpdateSettingsCustomEventAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCustomEventAsync(
        ExsitedClient client,
        string customEventId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomEvents.UpdateSettingsCustomEventAsync(
            customEventId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
