namespace Exsited.Resources.Employees;

/// <summary>Path templates and body keys for the v4 employees endpoints.</summary>
public static class EmployeesUrls
{
    public const string Employees = "/api/{api_version}/employees";

    public const string Employee = "/api/{api_version}/employees/{employee_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string EmployeeKey = "employee";
}
