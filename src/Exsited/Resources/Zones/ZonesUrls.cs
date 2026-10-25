namespace Exsited.Resources.Zones;

/// <summary>Path templates and body keys for the v4 zones endpoints.</summary>
public static class ZonesUrls
{
    public const string SettingsZones = "/api/{api_version}/settings/zones";

    public const string SettingsZone = "/api/{api_version}/settings/zones/{zone_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ZoneKey = "zone";
}
