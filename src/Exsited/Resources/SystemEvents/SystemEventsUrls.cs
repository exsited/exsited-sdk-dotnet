namespace Exsited.Resources.SystemEvents;

/// <summary>Path templates and body keys for the v4 system events endpoints.</summary>
public static class SystemEventsUrls
{
    public const string SettingsSystemEvents = "/api/{api_version}/settings/system_events";

    public const string SettingsSystemEvent = "/api/{api_version}/settings/system_events/{system_event_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/system_events</c> and <c>GET /api/{api_version}/settings/system_events/{system_event_id}</c>.</summary>
    public const string SystemEventKey = "system_event";
}
