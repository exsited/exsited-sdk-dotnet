namespace Exsited.Resources.ApprovalProfiles;

/// <summary>Path templates and body keys for the v4 approval profiles endpoints.</summary>
public static class ApprovalProfilesUrls
{
    public const string SettingsApprovalProfiles = "/api/{api_version}/settings/approval_profiles";

    public const string SettingsApprovalProfile = "/api/{api_version}/settings/approval_profiles/{approval_profile_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/approval_profiles</c> and <c>GET /api/{api_version}/settings/approval_profiles/{approval_profile_id}</c>.</summary>
    public const string ApprovalProfileKey = "approval_profile";
}
