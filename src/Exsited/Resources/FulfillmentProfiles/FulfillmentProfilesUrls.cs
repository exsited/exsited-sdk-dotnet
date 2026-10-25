namespace Exsited.Resources.FulfillmentProfiles;

/// <summary>Path templates and body keys for the v4 fulfillment profiles endpoints.</summary>
public static class FulfillmentProfilesUrls
{
    public const string SettingsFulfillmentProfiles = "/api/{api_version}/settings/fulfillment_profiles";

    public const string SettingsFulfillmentProfile = "/api/{api_version}/settings/fulfillment_profiles/{fulfillment_profile_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string FulfillmentProfileKey = "fulfillment_profile";
}
