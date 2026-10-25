using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ActionScripts.ActionScriptsDto;

namespace Exsited.Resources.ActionScripts;

/// <summary>The v4 action scripts endpoints, as a typed resource bound to one client.</summary>
public sealed class ActionScripts : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ActionScripts</c>.</summary>
    public ActionScripts(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/action_scripts</c>.</summary>
    public Task<ApiResponse> GetActionScriptsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ActionScriptsUrls.ActionScripts,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ActionScriptList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/action_scripts/{action_script_id}</c>.</summary>
    public Task<ApiResponse> GetActionScriptAsync(
        string actionScriptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ActionScriptsUrls.ActionScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["action_script_id"] = actionScriptId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ActionScript),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/action_scripts</c>.</summary>
    public Task<ApiResponse> CreateActionScriptAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ActionScriptsUrls.ActionScripts,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ActionScript),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/action_scripts/{action_script_id}</c>.</summary>
    public Task<ApiResponse> UpdateActionScriptAsync(
        string actionScriptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ActionScriptsUrls.ActionScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["action_script_id"] = actionScriptId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ActionScript),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/action_scripts/{action_script_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteActionScriptAsync(
        string actionScriptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ActionScriptsUrls.ActionScript,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["action_script_id"] = actionScriptId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ActionScripts.GetActionScriptsAsync</c>.</summary>
    public static Task<ApiResponse> GetActionScriptsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ActionScripts.GetActionScriptsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ActionScripts.GetActionScriptAsync</c>.</summary>
    public static Task<ApiResponse> GetActionScriptAsync(
        ExsitedClient client,
        string actionScriptId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ActionScripts.GetActionScriptAsync(
            actionScriptId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ActionScripts.CreateActionScriptAsync</c>.</summary>
    public static Task<ApiResponse> CreateActionScriptAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ActionScripts.CreateActionScriptAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ActionScripts.UpdateActionScriptAsync</c>.</summary>
    public static Task<ApiResponse> UpdateActionScriptAsync(
        ExsitedClient client,
        string actionScriptId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ActionScripts.UpdateActionScriptAsync(
            actionScriptId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ActionScripts.DeleteActionScriptAsync</c>.</summary>
    public static Task<ApiResponse> DeleteActionScriptAsync(
        ExsitedClient client,
        string actionScriptId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ActionScripts.DeleteActionScriptAsync(
            actionScriptId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
