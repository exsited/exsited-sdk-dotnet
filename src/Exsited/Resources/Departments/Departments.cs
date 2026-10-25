using Exsited.Client;
using Exsited.Resources.Departments.DepartmentsDto;

namespace Exsited.Resources.Departments;

/// <summary>The v4 departments endpoints, as a typed resource bound to one client.</summary>
public sealed class Departments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Departments</c>.</summary>
    public Departments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/departments</c>.</summary>
    public Task<ApiResponse> GetSettingsDepartmentsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DepartmentsUrls.SettingsDepartments,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDepartmentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/departments/{department_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsDepartmentAsync(
        string departmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DepartmentsUrls.SettingsDepartment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["department_id"] = departmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDepartment),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Departments.GetSettingsDepartmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDepartmentsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Departments.GetSettingsDepartmentsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Departments.GetSettingsDepartmentAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDepartmentAsync(
        ExsitedClient client,
        string departmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Departments.GetSettingsDepartmentAsync(
            departmentId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
