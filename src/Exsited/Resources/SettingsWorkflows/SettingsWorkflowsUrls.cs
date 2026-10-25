namespace Exsited.Resources.SettingsWorkflows;

/// <summary>Path templates and body keys for the v4 settings workflows endpoints.</summary>
public static class SettingsWorkflowsUrls
{
    public const string SettingsWorkflows = "/api/{api_version}/settings/workflows";

    public const string SettingsWorkflow = "/api/{api_version}/settings/workflows/{workflow_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/workflows</c> and <c>GET /api/{api_version}/settings/workflows/{workflow_id}</c>.</summary>
    public const string WorkflowKey = "workflow";
}
