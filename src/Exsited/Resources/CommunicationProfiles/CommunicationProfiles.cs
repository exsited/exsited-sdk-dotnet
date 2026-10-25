using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CommunicationProfiles.CommunicationProfilesDto;

namespace Exsited.Resources.CommunicationProfiles;

/// <summary>The v4 communication profiles endpoints, as a typed resource bound to one client.</summary>
public sealed class CommunicationProfiles : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CommunicationProfiles</c>.</summary>
    public CommunicationProfiles(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/communication_profiles</c>.</summary>
    public Task<ApiResponse> GetSettingsCommunicationProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CommunicationProfilesUrls.SettingsCommunicationProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCommunicationProfileList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/communication_profiles</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsCommunicationProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CommunicationProfilesUrls.SettingsCommunicationProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/communication_profiles/{communication_profile_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCommunicationProfileAsync(
        string communicationProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CommunicationProfilesUrls.SettingsCommunicationProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["communication_profile_id"] = communicationProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCommunicationProfile),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/communication_profiles/{communication_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsCommunicationProfileAsync(
        string communicationProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CommunicationProfilesUrls.SettingsCommunicationProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["communication_profile_id"] = communicationProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/communication_profiles/{communication_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCommunicationProfileAsync(
        string communicationProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CommunicationProfilesUrls.SettingsCommunicationProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["communication_profile_id"] = communicationProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.CommunicationProfiles.GetSettingsCommunicationProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCommunicationProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CommunicationProfiles.GetSettingsCommunicationProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CommunicationProfiles.CreateSettingsCommunicationProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCommunicationProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CommunicationProfiles.CreateSettingsCommunicationProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CommunicationProfiles.GetSettingsCommunicationProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCommunicationProfileAsync(
        ExsitedClient client,
        string communicationProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CommunicationProfiles.GetSettingsCommunicationProfileAsync(
            communicationProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CommunicationProfiles.DeleteSettingsCommunicationProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsCommunicationProfileAsync(
        ExsitedClient client,
        string communicationProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CommunicationProfiles.DeleteSettingsCommunicationProfileAsync(
            communicationProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CommunicationProfiles.UpdateSettingsCommunicationProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCommunicationProfileAsync(
        ExsitedClient client,
        string communicationProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CommunicationProfiles.UpdateSettingsCommunicationProfileAsync(
            communicationProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
