using Exsited.Client;
using Exsited.Resources.SettingsWorkflows.SettingsWorkflowsDto;

namespace Exsited.Resources.SettingsWorkflows;

/// <summary>The v4 settings workflows endpoints, as a typed resource bound to one client.</summary>
public sealed class SettingsWorkflows : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.SettingsWorkflows</c>.</summary>
    public SettingsWorkflows(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/workflows</c>.</summary>
    public Task<ApiResponse> GetSettingsWorkflowsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsWorkflowsUrls.SettingsWorkflows,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWorkflowList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/workflows/{workflow_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsWorkflowAsync(
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SettingsWorkflowsUrls.SettingsWorkflow,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsWorkflow),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.SettingsWorkflows.GetSettingsWorkflowsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsWorkflowsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SettingsWorkflows.GetSettingsWorkflowsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.SettingsWorkflows.GetSettingsWorkflowAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsWorkflowAsync(
        ExsitedClient client,
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.SettingsWorkflows.GetSettingsWorkflowAsync(
            workflowId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
