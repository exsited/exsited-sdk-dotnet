namespace Exsited.Resources.Roles;

/// <summary>Path templates and body keys for the v4 roles endpoints.</summary>
public static class RolesUrls
{
    public const string SettingsRoles = "/api/{api_version}/settings/roles";

    public const string SettingsRole = "/api/{api_version}/settings/roles/{role_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/roles</c> and <c>GET /api/{api_version}/settings/roles/{role_id}</c>.</summary>
    public const string RoleKey = "role";
}
