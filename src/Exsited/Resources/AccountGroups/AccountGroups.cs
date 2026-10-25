using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.AccountGroups.AccountGroupsDto;

namespace Exsited.Resources.AccountGroups;

/// <summary>The v4 account groups endpoints, as a typed resource bound to one client.</summary>
public sealed class AccountGroups : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AccountGroups</c>.</summary>
    public AccountGroups(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/account_groups</c>.</summary>
    public Task<ApiResponse> GetSettingsAccountGroupsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountGroupsUrls.SettingsAccountGroups,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountGroupList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/account_groups</c>.</summary>
    public Task<ApiResponse> CreateSettingsAccountGroupAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountGroupsUrls.SettingsAccountGroups,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountGroup),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/account_groups/{account_group_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsAccountGroupAsync(
        string accountGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountGroupsUrls.SettingsAccountGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_group_id"] = accountGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountGroup),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/account_groups/{account_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsAccountGroupAsync(
        string accountGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountGroupsUrls.SettingsAccountGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_group_id"] = accountGroupId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/account_groups/{account_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsAccountGroupAsync(
        string accountGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountGroupsUrls.SettingsAccountGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_group_id"] = accountGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.AccountGroups.GetSettingsAccountGroupsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAccountGroupsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountGroups.GetSettingsAccountGroupsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountGroups.CreateSettingsAccountGroupAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsAccountGroupAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountGroups.CreateSettingsAccountGroupAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountGroups.GetSettingsAccountGroupAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAccountGroupAsync(
        ExsitedClient client,
        string accountGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountGroups.GetSettingsAccountGroupAsync(
            accountGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountGroups.DeleteSettingsAccountGroupAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsAccountGroupAsync(
        ExsitedClient client,
        string accountGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountGroups.DeleteSettingsAccountGroupAsync(
            accountGroupId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountGroups.UpdateSettingsAccountGroupAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsAccountGroupAsync(
        ExsitedClient client,
        string accountGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountGroups.UpdateSettingsAccountGroupAsync(
            accountGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
