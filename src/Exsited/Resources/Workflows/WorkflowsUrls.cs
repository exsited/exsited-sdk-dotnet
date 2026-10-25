namespace Exsited.Resources.Workflows;

/// <summary>Path templates and body keys for the v4 workflows endpoints.</summary>
public static class WorkflowsUrls
{
    public const string Milestone = "/api/{api_version}/milestones/{milestone_uuid}";

    public const string WorkflowComponentById = "/api/{api_version}/workflow/component/{cc_id}";

    public const string WorkflowMilestones = "/api/{api_version}/workflows/{workflow_uuid}/milestones";

    public const string WorkflowComponentCcMilestone = "/api/{api_version}/workflow/component/{cc_id}/milestone";

    public const string WorkflowComponentHistory = "/api/{api_version}/workflow/component/{component_object_id}/history";

    public const string WorkflowComponentCcInstanceCcMilestone = "/api/{api_version}/workflow/component/{component_uuid}/{component_object_id}/milestone";

    public const string Workflows = "/api/{api_version}/workflows";

    public const string Workflow = "/api/{api_version}/workflows/{workflow_id}";

    public const string WorkflowStages = "/api/{api_version}/workflows/{workflow_id}/stages";

    public const string WorkflowStage = "/api/{api_version}/workflows/{workflow_id}/stages/{stage_id}";

    public const string WorkflowMilestone = "/api/{api_version}/workflows/{workflow_id}/milestones/{milestone_id}";

    public const string WorkflowCustomComponentHistory = "/api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/history";

    public const string WorkflowCustomComponentMilestones = "/api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/milestones";

    public const string WorkflowCustomComponentMilestone = "/api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/milestones/{milestone_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/workflows/{workflow_id}</c>.</summary>
    public const string WorkflowKey = "workflow";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/workflows/{workflow_id}/milestones/{milestone_id}</c>.</summary>
    public const string WorkflowMilestoneKey = "workflow_milestone";
}
