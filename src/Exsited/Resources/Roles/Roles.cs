using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Roles.RolesDto;

namespace Exsited.Resources.Roles;

/// <summary>The v4 roles endpoints, as a typed resource bound to one client.</summary>
public sealed class Roles : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Roles</c>.</summary>
    public Roles(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/roles</c>.</summary>
    public Task<ApiResponse> GetSettingsRolesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RolesUrls.SettingsRoles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsRoleList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/roles</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateSettingsRoleAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RolesUrls.SettingsRoles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/roles/{role_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsRoleAsync(
        string roleId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RolesUrls.SettingsRole,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["role_id"] = roleId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsRole),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/roles/{role_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsRoleAsync(
        string roleId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RolesUrls.SettingsRole,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["role_id"] = roleId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/roles/{role_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsRoleAsync(
        string roleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(RolesUrls.SettingsRole,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["role_id"] = roleId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Roles.GetSettingsRolesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsRolesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Roles.GetSettingsRolesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Roles.CreateSettingsRoleAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsRoleAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Roles.CreateSettingsRoleAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Roles.GetSettingsRoleAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsRoleAsync(
        ExsitedClient client,
        string roleId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Roles.GetSettingsRoleAsync(
            roleId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Roles.DeleteSettingsRoleAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsRoleAsync(
        ExsitedClient client,
        string roleId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Roles.DeleteSettingsRoleAsync(
            roleId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Roles.UpdateSettingsRoleAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsRoleAsync(
        ExsitedClient client,
        string roleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Roles.UpdateSettingsRoleAsync(
            roleId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
