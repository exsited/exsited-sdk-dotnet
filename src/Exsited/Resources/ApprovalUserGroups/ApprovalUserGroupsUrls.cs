namespace Exsited.Resources.ApprovalUserGroups;

/// <summary>Path templates and body keys for the v4 approval user groups endpoints.</summary>
public static class ApprovalUserGroupsUrls
{
    public const string SettingsApprovalUserGroups = "/api/{api_version}/settings/approval_user_groups";

    public const string SettingsApprovalUserGroup = "/api/{api_version}/settings/approval_user_groups/{approval_user_group_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ApprovalUserGroupKey = "approval_user_group";
}
