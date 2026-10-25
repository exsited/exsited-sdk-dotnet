using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Applications.ApplicationsDto;

namespace Exsited.Resources.Applications;

/// <summary>The v4 applications endpoints, as a typed resource bound to one client.</summary>
public sealed class Applications : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Applications</c>.</summary>
    public Applications(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/applications</c>.</summary>
    public Task<ApiResponse> GetSettingsApplicationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApplicationsUrls.SettingsApplications,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApplicationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/applications</c>.</summary>
    public Task<ApiResponse> CreateSettingsApplicationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ApplicationsUrls.SettingsApplications,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApplication),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/applications/{application_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsApplicationAsync(
        string applicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApplicationsUrls.SettingsApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["application_id"] = applicationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApplication),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/applications/{application_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsApplicationAsync(
        string applicationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ApplicationsUrls.SettingsApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["application_id"] = applicationId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/applications/{application_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsApplicationAsync(
        string applicationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ApplicationsUrls.SettingsApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["application_id"] = applicationId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApplication),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Applications.GetSettingsApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApplicationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Applications.GetSettingsApplicationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Applications.CreateSettingsApplicationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsApplicationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Applications.CreateSettingsApplicationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Applications.GetSettingsApplicationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApplicationAsync(
        ExsitedClient client,
        string applicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Applications.GetSettingsApplicationAsync(
            applicationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Applications.DeleteSettingsApplicationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsApplicationAsync(
        ExsitedClient client,
        string applicationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Applications.DeleteSettingsApplicationAsync(
            applicationId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Applications.UpdateSettingsApplicationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsApplicationAsync(
        ExsitedClient client,
        string applicationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Applications.UpdateSettingsApplicationAsync(
            applicationId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
