using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Events.EventsDto;

namespace Exsited.Resources.Events;

/// <summary>The v4 events endpoints, as a typed resource bound to one client.</summary>
public sealed class Events : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Events</c>.</summary>
    public Events(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/events</c>.</summary>
    public Task<ApiResponse> GetEventsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EventsUrls.Events,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(EventList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/events/{event_uuid}</c>.</summary>
    public Task<ApiResponse> GetEventAsync(
        string eventUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EventsUrls.Event,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["event_uuid"] = eventUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Event),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/events/{event_uuid}/execute</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateEventExecuteAsync(
        string eventUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(EventsUrls.EventExecute,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["event_uuid"] = eventUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/events/{event_uuid}/remove</c>.</summary>
    public Task<ApiResponse> CreateEventRemoveAsync(
        string eventUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(EventsUrls.EventRemove,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["event_uuid"] = eventUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(EventRemove),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Events.GetEventsAsync</c>.</summary>
    public static Task<ApiResponse> GetEventsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Events.GetEventsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Events.GetEventAsync</c>.</summary>
    public static Task<ApiResponse> GetEventAsync(
        ExsitedClient client,
        string eventUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Events.GetEventAsync(
            eventUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Events.CreateEventExecuteAsync</c>.</summary>
    public static Task<ApiResponse> CreateEventExecuteAsync(
        ExsitedClient client,
        string eventUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Events.CreateEventExecuteAsync(
            eventUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Events.CreateEventRemoveAsync</c>.</summary>
    public static Task<ApiResponse> CreateEventRemoveAsync(
        ExsitedClient client,
        string eventUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Events.CreateEventRemoveAsync(
            eventUuid, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
