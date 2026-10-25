using Exsited.Client;
using Exsited.Resources.SystemEvents.SystemEventsDto;

namespace Exsited.Resources.SystemEvents;

/// <summary>The v4 system events endpoints, as a typed resource bound to one client.</summary>
public sealed class SystemEvents : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.SystemEvents</c>.</summary>
    public SystemEvents(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/system_events</c>.</summary>
    public Task<ApiResponse> GetSettingsSystemEventsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SystemEventsUrls.SettingsSystemEvents,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSystemEventList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/system_events/{system_event_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsSystemEventAsync(
        string systemEventId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SystemEventsUrls.SettingsSystemEvent,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["system_event_id"] = systemEventId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSystemEvent),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.SystemEvents.GetSettingsSystemEventsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSystemEventsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SystemEvents.GetSettingsSystemEventsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SystemEvents.GetSettingsSystemEventAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSystemEventAsync(
        ExsitedClient client,
        string systemEventId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SystemEvents.GetSettingsSystemEventAsync(
            systemEventId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
