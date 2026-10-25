namespace Exsited.Resources.Events;

/// <summary>Path templates and body keys for the v4 events endpoints.</summary>
public static class EventsUrls
{
    public const string Events = "/api/{api_version}/events";

    public const string Event = "/api/{api_version}/events/{event_uuid}";

    public const string EventExecute = "/api/{api_version}/events/{event_uuid}/execute";

    public const string EventRemove = "/api/{api_version}/events/{event_uuid}/remove";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string EventKey = "event";
}
