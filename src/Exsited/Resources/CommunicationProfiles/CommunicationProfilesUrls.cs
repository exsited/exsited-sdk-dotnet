namespace Exsited.Resources.CommunicationProfiles;

/// <summary>Path templates and body keys for the v4 communication profiles endpoints.</summary>
public static class CommunicationProfilesUrls
{
    public const string SettingsCommunicationProfiles = "/api/{api_version}/settings/communication_profiles";

    public const string SettingsCommunicationProfile = "/api/{api_version}/settings/communication_profiles/{communication_profile_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/communication_profiles</c> and <c>GET /api/{api_version}/settings/communication_profiles/{communication_profile_id}</c>.</summary>
    public const string CommunicationProfileKey = "communication_profile";
}
