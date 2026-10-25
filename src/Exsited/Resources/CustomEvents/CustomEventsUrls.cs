namespace Exsited.Resources.CustomEvents;

/// <summary>Path templates and body keys for the v4 custom events endpoints.</summary>
public static class CustomEventsUrls
{
    public const string SettingsCustomEvents = "/api/{api_version}/settings/custom_events";

    public const string SettingsCustomEvent = "/api/{api_version}/settings/custom_events/{custom_event_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/custom_events</c> and <c>GET /api/{api_version}/settings/custom_events/{custom_event_id}</c>.</summary>
    public const string CustomEventKey = "custom_event";
}
