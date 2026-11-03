namespace Exsited.Resources.OperatorGroups;

/// <summary>Path templates and body keys for the v4 operator groups endpoints.</summary>
public static class OperatorGroupsUrls
{
    public const string SettingsOperatorGroups = "/api/{api_version}/settings/operator_groups";

    public const string SettingsOperatorGroup = "/api/{api_version}/settings/operator_groups/{operator_group_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under.</summary>
    public const string OperatorGroupKey = "operator_group";
}
