using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.AlertResponsibility.AlertResponsibilityDto;

namespace Exsited.Resources.AlertResponsibility;

/// <summary>The v4 alert responsibility endpoints, as a typed resource bound to one client.</summary>
public sealed class AlertResponsibility : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AlertResponsibility</c>.</summary>
    public AlertResponsibility(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/alert_responsibility</c>.</summary>
    public Task<ApiResponse> GetAlertResponsibilitiesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertResponsibilityUrls.AlertResponsibilities,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertResponsibilityList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/alert_responsibility/{alert_responsibility_id}</c>.</summary>
    public Task<ApiResponse> GetAlertResponsibilityAsync(
        string alertResponsibilityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AlertResponsibilityUrls.AlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertResponsibilityView),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/alert_responsibility</c>.</summary>
    public Task<ApiResponse> CreateAlertResponsibilityAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AlertResponsibilityUrls.AlertResponsibilities,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertResponsibilityView),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/alert_responsibility/{alert_responsibility_id}</c>.</summary>
    public Task<ApiResponse> UpdateAlertResponsibilityAsync(
        string alertResponsibilityId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AlertResponsibilityUrls.AlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AlertResponsibilityView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/alert_responsibility/{alert_responsibility_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAlertResponsibilityAsync(
        string alertResponsibilityId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AlertResponsibilityUrls.AlertResponsibility,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["alert_responsibility_id"] = alertResponsibilityId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.AlertResponsibility.GetAlertResponsibilitiesAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertResponsibilitiesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibility.GetAlertResponsibilitiesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibility.GetAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> GetAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibility.GetAlertResponsibilityAsync(
            alertResponsibilityId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibility.CreateAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> CreateAlertResponsibilityAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibility.CreateAlertResponsibilityAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibility.UpdateAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> UpdateAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibility.UpdateAlertResponsibilityAsync(
            alertResponsibilityId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AlertResponsibility.DeleteAlertResponsibilityAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAlertResponsibilityAsync(
        ExsitedClient client,
        string alertResponsibilityId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AlertResponsibility.DeleteAlertResponsibilityAsync(
            alertResponsibilityId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
