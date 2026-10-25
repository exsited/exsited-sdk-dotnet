using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ApprovalProfiles.ApprovalProfilesDto;

namespace Exsited.Resources.ApprovalProfiles;

/// <summary>The v4 approval profiles endpoints, as a typed resource bound to one client.</summary>
public sealed class ApprovalProfiles : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ApprovalProfiles</c>.</summary>
    public ApprovalProfiles(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/approval_profiles</c>.</summary>
    public Task<ApiResponse> GetSettingsApprovalProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalProfilesUrls.SettingsApprovalProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalProfileList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/approval_profiles</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsApprovalProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ApprovalProfilesUrls.SettingsApprovalProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/approval_profiles/{approval_profile_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsApprovalProfileAsync(
        string approvalProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalProfilesUrls.SettingsApprovalProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_profile_id"] = approvalProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalProfile),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/approval_profiles/{approval_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsApprovalProfileAsync(
        string approvalProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ApprovalProfilesUrls.SettingsApprovalProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_profile_id"] = approvalProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/approval_profiles/{approval_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsApprovalProfileAsync(
        string approvalProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ApprovalProfilesUrls.SettingsApprovalProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_profile_id"] = approvalProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ApprovalProfiles.GetSettingsApprovalProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApprovalProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalProfiles.GetSettingsApprovalProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalProfiles.CreateSettingsApprovalProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsApprovalProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalProfiles.CreateSettingsApprovalProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalProfiles.GetSettingsApprovalProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApprovalProfileAsync(
        ExsitedClient client,
        string approvalProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalProfiles.GetSettingsApprovalProfileAsync(
            approvalProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalProfiles.DeleteSettingsApprovalProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsApprovalProfileAsync(
        ExsitedClient client,
        string approvalProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalProfiles.DeleteSettingsApprovalProfileAsync(
            approvalProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalProfiles.UpdateSettingsApprovalProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsApprovalProfileAsync(
        ExsitedClient client,
        string approvalProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalProfiles.UpdateSettingsApprovalProfileAsync(
            approvalProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
