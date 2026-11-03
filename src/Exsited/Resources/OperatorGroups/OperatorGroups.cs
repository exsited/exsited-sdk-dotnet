using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.OperatorGroups.OperatorGroupsDto;

namespace Exsited.Resources.OperatorGroups;

/// <summary>The v4 operator groups endpoints, as a typed resource bound to one client.</summary>
public sealed class OperatorGroups : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.OperatorGroups</c>.</summary>
    public OperatorGroups(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/operator_groups</c>.</summary>
    public Task<ApiResponse> GetSettingsOperatorGroupsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OperatorGroupsUrls.SettingsOperatorGroups,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperatorGroupList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/operator_groups</c>; <c>role</c> is required and takes the role's dashed uuid.</summary>
    public Task<ApiResponse> CreateSettingsOperatorGroupAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OperatorGroupsUrls.SettingsOperatorGroups,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperatorGroup),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/operator_groups/{operator_group_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsOperatorGroupAsync(
        string operatorGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OperatorGroupsUrls.SettingsOperatorGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["operator_group_id"] = operatorGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperatorGroup),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/operator_groups/{operator_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsOperatorGroupAsync(
        string operatorGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(OperatorGroupsUrls.SettingsOperatorGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["operator_group_id"] = operatorGroupId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/operator_groups/{operator_group_id}</c>; the answer names <c>role</c> as a reference carrying the dashed uuid.</summary>
    public Task<ApiResponse> UpdateSettingsOperatorGroupAsync(
        string operatorGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OperatorGroupsUrls.SettingsOperatorGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["operator_group_id"] = operatorGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperatorGroup),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.OperatorGroups.GetSettingsOperatorGroupsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOperatorGroupsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.OperatorGroups.GetSettingsOperatorGroupsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.OperatorGroups.CreateSettingsOperatorGroupAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsOperatorGroupAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.OperatorGroups.CreateSettingsOperatorGroupAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.OperatorGroups.GetSettingsOperatorGroupAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOperatorGroupAsync(
        ExsitedClient client,
        string operatorGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.OperatorGroups.GetSettingsOperatorGroupAsync(
            operatorGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.OperatorGroups.DeleteSettingsOperatorGroupAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsOperatorGroupAsync(
        ExsitedClient client,
        string operatorGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.OperatorGroups.DeleteSettingsOperatorGroupAsync(
            operatorGroupId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.OperatorGroups.UpdateSettingsOperatorGroupAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsOperatorGroupAsync(
        ExsitedClient client,
        string operatorGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.OperatorGroups.UpdateSettingsOperatorGroupAsync(
            operatorGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
