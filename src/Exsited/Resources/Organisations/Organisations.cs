using Exsited.Client;
using Exsited.Errors;

namespace Exsited.Resources.Organisations;

/// <summary>The v4 organisations endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class Organisations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Organisations</c>.</summary>
    public Organisations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/organisations</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetSettingsOrganisationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrganisationsUrls.SettingsOrganisations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/organisations</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsOrganisationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OrganisationsUrls.SettingsOrganisations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/organisations/{organisation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetSettingsOrganisationAsync(
        string organisationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrganisationsUrls.SettingsOrganisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["organisation_id"] = organisationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/organisations/{organisation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsOrganisationAsync(
        string organisationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(OrganisationsUrls.SettingsOrganisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["organisation_id"] = organisationId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/organisations/{organisation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsOrganisationAsync(
        string organisationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OrganisationsUrls.SettingsOrganisation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["organisation_id"] = organisationId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Organisations.GetSettingsOrganisationsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOrganisationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisations.GetSettingsOrganisationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Organisations.CreateSettingsOrganisationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsOrganisationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisations.CreateSettingsOrganisationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Organisations.GetSettingsOrganisationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOrganisationAsync(
        ExsitedClient client,
        string organisationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisations.GetSettingsOrganisationAsync(
            organisationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Organisations.DeleteSettingsOrganisationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsOrganisationAsync(
        ExsitedClient client,
        string organisationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisations.DeleteSettingsOrganisationAsync(
            organisationId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Organisations.UpdateSettingsOrganisationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsOrganisationAsync(
        ExsitedClient client,
        string organisationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisations.UpdateSettingsOrganisationAsync(
            organisationId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
