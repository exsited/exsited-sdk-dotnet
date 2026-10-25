using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Employees.EmployeesDto;

namespace Exsited.Resources.Employees;

/// <summary>The v4 employees endpoints, as a typed resource bound to one client.</summary>
public sealed class Employees : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Employees</c>.</summary>
    public Employees(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/employees</c>.</summary>
    public Task<ApiResponse> GetEmployeesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EmployeesUrls.Employees,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(EmployeeList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/employees</c>.</summary>
    public Task<ApiResponse> CreateEmployeeAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(EmployeesUrls.Employees,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(EmployeesView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/employees/{employee_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteEmployeeAsync(
        string employeeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(EmployeesUrls.Employee,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["employee_id"] = employeeId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/employees/{employee_id}</c>.</summary>
    public Task<ApiResponse> GetEmployeeAsync(
        string employeeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EmployeesUrls.Employee,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["employee_id"] = employeeId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Employee),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/employees/{employee_id}</c>.</summary>
    public Task<ApiResponse> UpdateEmployeeAsync(
        string employeeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(EmployeesUrls.Employee,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["employee_id"] = employeeId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(EmployeeUpdated),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Employees.GetEmployeesAsync</c>.</summary>
    public static Task<ApiResponse> GetEmployeesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Employees.GetEmployeesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Employees.CreateEmployeeAsync</c>.</summary>
    public static Task<ApiResponse> CreateEmployeeAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Employees.CreateEmployeeAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Employees.DeleteEmployeeAsync</c>.</summary>
    public static Task<ApiResponse> DeleteEmployeeAsync(
        ExsitedClient client,
        string employeeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Employees.DeleteEmployeeAsync(
            employeeId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Employees.GetEmployeeAsync</c>.</summary>
    public static Task<ApiResponse> GetEmployeeAsync(
        ExsitedClient client,
        string employeeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Employees.GetEmployeeAsync(
            employeeId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Employees.UpdateEmployeeAsync</c>.</summary>
    public static Task<ApiResponse> UpdateEmployeeAsync(
        ExsitedClient client,
        string employeeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Employees.UpdateEmployeeAsync(
            employeeId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
