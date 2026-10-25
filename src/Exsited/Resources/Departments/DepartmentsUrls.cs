namespace Exsited.Resources.Departments;

/// <summary>Path templates and body keys for the v4 departments endpoints.</summary>
public static class DepartmentsUrls
{
    public const string SettingsDepartments = "/api/{api_version}/settings/departments";

    public const string SettingsDepartment = "/api/{api_version}/settings/departments/{department_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/departments</c> and <c>GET /api/{api_version}/settings/departments/{department_id}</c>.</summary>
    public const string DepartmentKey = "department";
}
