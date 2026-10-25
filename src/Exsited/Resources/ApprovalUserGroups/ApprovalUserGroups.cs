using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ApprovalUserGroups.ApprovalUserGroupsDto;

namespace Exsited.Resources.ApprovalUserGroups;

/// <summary>The v4 approval user groups endpoints, as a typed resource bound to one client.</summary>
public sealed class ApprovalUserGroups : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ApprovalUserGroups</c>.</summary>
    public ApprovalUserGroups(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/approval_user_groups</c>.</summary>
    public Task<ApiResponse> GetSettingsApprovalUserGroupsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalUserGroupsUrls.SettingsApprovalUserGroups,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalUserGroupList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/approval_user_groups</c>.</summary>
    public Task<ApiResponse> CreateSettingsApprovalUserGroupAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ApprovalUserGroupsUrls.SettingsApprovalUserGroups,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalUserGroup),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/approval_user_groups/{approval_user_group_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsApprovalUserGroupAsync(
        string approvalUserGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ApprovalUserGroupsUrls.SettingsApprovalUserGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_user_group_id"] = approvalUserGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalUserGroup),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/approval_user_groups/{approval_user_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsApprovalUserGroupAsync(
        string approvalUserGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ApprovalUserGroupsUrls.SettingsApprovalUserGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_user_group_id"] = approvalUserGroupId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/approval_user_groups/{approval_user_group_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsApprovalUserGroupAsync(
        string approvalUserGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ApprovalUserGroupsUrls.SettingsApprovalUserGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["approval_user_group_id"] = approvalUserGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsApprovalUserGroup),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ApprovalUserGroups.GetSettingsApprovalUserGroupsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApprovalUserGroupsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalUserGroups.GetSettingsApprovalUserGroupsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalUserGroups.CreateSettingsApprovalUserGroupAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsApprovalUserGroupAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalUserGroups.CreateSettingsApprovalUserGroupAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalUserGroups.GetSettingsApprovalUserGroupAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsApprovalUserGroupAsync(
        ExsitedClient client,
        string approvalUserGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalUserGroups.GetSettingsApprovalUserGroupAsync(
            approvalUserGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalUserGroups.DeleteSettingsApprovalUserGroupAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsApprovalUserGroupAsync(
        ExsitedClient client,
        string approvalUserGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalUserGroups.DeleteSettingsApprovalUserGroupAsync(
            approvalUserGroupId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ApprovalUserGroups.UpdateSettingsApprovalUserGroupAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsApprovalUserGroupAsync(
        ExsitedClient client,
        string approvalUserGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ApprovalUserGroups.UpdateSettingsApprovalUserGroupAsync(
            approvalUserGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
