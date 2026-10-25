using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Designations.DesignationsDto;

namespace Exsited.Resources.Designations;

/// <summary>The v4 designations endpoints, as a typed resource bound to one client.</summary>
public sealed class Designations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Designations</c>.</summary>
    public Designations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/designations</c>.</summary>
    public Task<ApiResponse> GetSettingsDesignationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DesignationsUrls.SettingsDesignations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDesignationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/designations</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsDesignationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(DesignationsUrls.SettingsDesignations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/designations/{designation_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsDesignationAsync(
        string designationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DesignationsUrls.SettingsDesignation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["designation_id"] = designationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDesignation),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/designations/{designation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsDesignationAsync(
        string designationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(DesignationsUrls.SettingsDesignation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["designation_id"] = designationId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/designations/{designation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsDesignationAsync(
        string designationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(DesignationsUrls.SettingsDesignation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["designation_id"] = designationId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Designations.GetSettingsDesignationsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDesignationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Designations.GetSettingsDesignationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Designations.CreateSettingsDesignationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsDesignationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Designations.CreateSettingsDesignationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Designations.GetSettingsDesignationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDesignationAsync(
        ExsitedClient client,
        string designationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Designations.GetSettingsDesignationAsync(
            designationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Designations.DeleteSettingsDesignationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsDesignationAsync(
        ExsitedClient client,
        string designationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Designations.DeleteSettingsDesignationAsync(
            designationId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Designations.UpdateSettingsDesignationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsDesignationAsync(
        ExsitedClient client,
        string designationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Designations.UpdateSettingsDesignationAsync(
            designationId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
