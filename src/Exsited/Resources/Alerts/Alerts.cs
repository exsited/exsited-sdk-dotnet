using Exsited.Client;
using Exsited.Resources.Alerts.AlertsDto;

namespace Exsited.Resources.Alerts;

/// <summary>The v4 alerts endpoints, as a typed resource bound to one client.</summary>
public sealed class Alerts : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Alerts</c>.</summary>
    public Alerts(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/alerts</c>.</summary>
    public Task<ApiResponse> GetAlertsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertsUrls.Alerts,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/alerts/{alert_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetAlertAsync(
        string alertId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertsUrls.Alert,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_id"] = alertId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/alerts/account/{account_id}</c>.</summary>
    public Task<ApiResponse> GetAlertsAccountByIdAsync(
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertsUrls.AlertsAccountById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/alerts/employee/{employee_id}</c>.</summary>
    public Task<ApiResponse> GetAlertsEmployeeByIdAsync(
        string employeeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertsUrls.AlertsEmployeeById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["employee_id"] = employeeId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertsEmployeeList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/alerts/labour/{labour_id}</c>.</summary>
    public Task<ApiResponse> GetAlertsLabourByIdAsync(
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertsUrls.AlertsLabourById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_id"] = labourId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertsLabourList),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Alerts.GetAlertsAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Alerts.GetAlertsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Alerts.GetAlertAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertAsync(
        ExsitedClient client,
        string alertId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Alerts.GetAlertAsync(
            alertId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Alerts.GetAlertsAccountByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertsAccountByIdAsync(
        ExsitedClient client,
        string accountId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Alerts.GetAlertsAccountByIdAsync(
            accountId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Alerts.GetAlertsEmployeeByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertsEmployeeByIdAsync(
        ExsitedClient client,
        string employeeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Alerts.GetAlertsEmployeeByIdAsync(
            employeeId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Alerts.GetAlertsLabourByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertsLabourByIdAsync(
        ExsitedClient client,
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Alerts.GetAlertsLabourByIdAsync(
            labourId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
