using Exsited.Client;
using Exsited.Errors;

namespace Exsited.Resources.AlertResponsibilities;

/// <summary>The v4 alert responsibilities endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class AlertResponsibilities : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AlertResponsibilities</c>.</summary>
    public AlertResponsibilities(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/alert_responsibilities</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetSettingsAlertResponsibilitiesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertResponsibilitiesUrls.SettingsAlertResponsibilities,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/alert_responsibilities</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsAlertResponsibilityAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AlertResponsibilitiesUrls.SettingsAlertResponsibilities,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/alert_responsibilities/{alert_responsibility_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetSettingsAlertResponsibilityAsync(
        string alertResponsibilityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertResponsibilitiesUrls.SettingsAlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/alert_responsibilities/{alert_responsibility_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsAlertResponsibilityAsync(
        string alertResponsibilityId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AlertResponsibilitiesUrls.SettingsAlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/alert_responsibilities/{alert_responsibility_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsAlertResponsibilityAsync(
        string alertResponsibilityId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AlertResponsibilitiesUrls.SettingsAlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.AlertResponsibilities.GetSettingsAlertResponsibilitiesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAlertResponsibilitiesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibilities.GetSettingsAlertResponsibilitiesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibilities.CreateSettingsAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsAlertResponsibilityAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibilities.CreateSettingsAlertResponsibilityAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibilities.GetSettingsAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibilities.GetSettingsAlertResponsibilityAsync(
            alertResponsibilityId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibilities.DeleteSettingsAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibilities.DeleteSettingsAlertResponsibilityAsync(
            alertResponsibilityId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibilities.UpdateSettingsAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibilities.UpdateSettingsAlertResponsibilityAsync(
            alertResponsibilityId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
