using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Portals.PortalsDto;

namespace Exsited.Resources.Portals;

/// <summary>The v4 portals endpoints, as a typed resource bound to one client.</summary>
public sealed class Portals : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Portals</c>.</summary>
    public Portals(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/portal/activate</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ActivatePortalAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalActivate,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/change_password</c>.</summary>
    public Task<ApiResponse> CreatePortalChangePasswordAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalChangePassword,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PortalChangePassword),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/login</c>.</summary>
    public Task<ApiResponse> CreatePortalLoginAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalLogin,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PortalLogin),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/reset</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreatePortalResetAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalReset,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/reset_link</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreatePortalResetLinkAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalResetLink,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/validate</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreatePortalValidateAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalValidate,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/portal/change</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> SetPortalPasswordAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PortalsUrls.PortalChange,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Portals.ActivatePortalAsync</c>.</summary>
    public static Task<ApiResponse> ActivatePortalAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.ActivatePortalAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.CreatePortalChangePasswordAsync</c>.</summary>
    public static Task<ApiResponse> CreatePortalChangePasswordAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.CreatePortalChangePasswordAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.CreatePortalLoginAsync</c>.</summary>
    public static Task<ApiResponse> CreatePortalLoginAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.CreatePortalLoginAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.CreatePortalResetAsync</c>.</summary>
    public static Task<ApiResponse> CreatePortalResetAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.CreatePortalResetAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.CreatePortalResetLinkAsync</c>.</summary>
    public static Task<ApiResponse> CreatePortalResetLinkAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.CreatePortalResetLinkAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.CreatePortalValidateAsync</c>.</summary>
    public static Task<ApiResponse> CreatePortalValidateAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.CreatePortalValidateAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Portals.SetPortalPasswordAsync</c>.</summary>
    public static Task<ApiResponse> SetPortalPasswordAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Portals.SetPortalPasswordAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
