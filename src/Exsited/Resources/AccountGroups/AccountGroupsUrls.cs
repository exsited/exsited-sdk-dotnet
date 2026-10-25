namespace Exsited.Resources.AccountGroups;

/// <summary>Path templates and body keys for the v4 account groups endpoints.</summary>
public static class AccountGroupsUrls
{
    public const string SettingsAccountGroups = "/api/{api_version}/settings/account_groups";

    public const string SettingsAccountGroup = "/api/{api_version}/settings/account_groups/{account_group_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string AccountGroupKey = "account_group";
}
