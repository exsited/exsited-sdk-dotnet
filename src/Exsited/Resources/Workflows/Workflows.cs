using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Workflows.WorkflowsDto;

namespace Exsited.Resources.Workflows;

/// <summary>The v4 workflows endpoints, as a typed resource bound to one client.</summary>
public sealed class Workflows : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Workflows</c>.</summary>
    public Workflows(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>DELETE /api/{api_version}/milestones/{milestone_uuid}</c>.</summary>
    public Task<ApiResponse> DeleteMilestoneAsync(
        string milestoneUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(WorkflowsUrls.Milestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["milestone_uuid"] = milestoneUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/workflow/component/{cc_id}</c>.
    /// Answers 405, and the documented route takes two slots where this path has one.</summary>
    public Task<ApiResponse> UpdateWorkflowComponentByIdAsync(
        string ccId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(WorkflowsUrls.WorkflowComponentById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["cc_id"] = ccId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/workflows/{workflow_uuid}/milestones</c>.</summary>
    public Task<ApiResponse> GetWorkflowMilestonesAsync(
        string workflowUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowMilestones,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_uuid"] = workflowUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowMilestoneList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/workflow/component/{cc_id}/milestone</c>.
    /// Answers 405, and the documented route takes two slots where this path has one.</summary>
    public Task<ApiResponse> CreateWorkflowComponentCcMilestoneAsync(
        string ccId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(WorkflowsUrls.WorkflowComponentCcMilestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["cc_id"] = ccId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/workflow/component/{component_object_id}/history</c>, by the
    /// instance's code; answered under <c>histories</c>.</summary>
    public Task<ApiResponse> GetWorkflowComponentHistoryAsync(
        string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowComponentHistory,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?>
                {
                    ["component_object_id"] = componentObjectId,
                },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflow/component/{component_uuid}/{component_object_id}/milestone</c>, by
    /// the component's uuid and the instance's code; answered under <c>milestones</c>.</summary>
    public Task<ApiResponse> GetWorkflowComponentCcInstanceCcMilestoneAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowComponentCcInstanceCcMilestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?>
                {
                    ["component_uuid"] = componentUuid,
                    ["component_object_id"] = componentObjectId,
                },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows</c>.</summary>
    public Task<ApiResponse> GetWorkflowsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.Workflows,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/{workflow_id}</c>.</summary>
    public Task<ApiResponse> GetWorkflowAsync(
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.Workflow,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowView),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/workflows</c>.</summary>
    public Task<ApiResponse> CreateWorkflowAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(WorkflowsUrls.Workflows,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowView),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/workflows/{workflow_id}</c>.</summary>
    public Task<ApiResponse> UpdateWorkflowAsync(
        string workflowId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(WorkflowsUrls.Workflow,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/workflows/{workflow_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteWorkflowAsync(
        string workflowId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(WorkflowsUrls.Workflow,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/{workflow_id}/stages</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWorkflowStagesAsync(
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowStages,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/{workflow_id}/stages/{stage_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWorkflowStageAsync(
        string workflowId, string stageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowStage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId, ["stage_id"] = stageId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/{workflow_id}/milestones/{milestone_id}</c>.</summary>
    public Task<ApiResponse> GetWorkflowMilestoneAsync(
        string workflowId, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowMilestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["workflow_id"] = workflowId, ["milestone_id"] = milestoneId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(WorkflowMilestoneView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/history</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWorkflowCustomComponentHistoryAsync(
        string componentUuid, string objectCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowCustomComponentHistory,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["object_code"] = objectCode },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/milestones</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWorkflowCustomComponentMilestonesAsync(
        string componentUuid, string objectCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowCustomComponentMilestones,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["object_code"] = objectCode },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/workflows/custom_components/{component_uuid}/{object_code}/milestones/{milestone_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWorkflowCustomComponentMilestoneAsync(
        string componentUuid, string objectCode, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WorkflowsUrls.WorkflowCustomComponentMilestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["object_code"] = objectCode, ["milestone_id"] = milestoneId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Workflows.DeleteMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> DeleteMilestoneAsync(
        ExsitedClient client,
        string milestoneUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.DeleteMilestoneAsync(
            milestoneUuid, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.UpdateWorkflowComponentByIdAsync</c>.
    /// Answers 405, and the documented route takes two slots where this path has one.</summary>
    public static Task<ApiResponse> UpdateWorkflowComponentByIdAsync(
        ExsitedClient client,
        string ccId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.UpdateWorkflowComponentByIdAsync(
            ccId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowMilestonesAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowMilestonesAsync(
        ExsitedClient client,
        string workflowUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowMilestonesAsync(
            workflowUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.CreateWorkflowComponentCcMilestoneAsync</c>.
    /// Answers 405, and the documented route takes two slots where this path has one.</summary>
    public static Task<ApiResponse> CreateWorkflowComponentCcMilestoneAsync(
        ExsitedClient client,
        string ccId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.CreateWorkflowComponentCcMilestoneAsync(
            ccId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowComponentHistoryAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowComponentHistoryAsync(
        ExsitedClient client,
        string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowComponentHistoryAsync(
            componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowComponentCcInstanceCcMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowComponentCcInstanceCcMilestoneAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowComponentCcInstanceCcMilestoneAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowsAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowAsync(
        ExsitedClient client,
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowAsync(
            workflowId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.CreateWorkflowAsync</c>.</summary>
    public static Task<ApiResponse> CreateWorkflowAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.CreateWorkflowAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.UpdateWorkflowAsync</c>.</summary>
    public static Task<ApiResponse> UpdateWorkflowAsync(
        ExsitedClient client,
        string workflowId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.UpdateWorkflowAsync(
            workflowId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.DeleteWorkflowAsync</c>.</summary>
    public static Task<ApiResponse> DeleteWorkflowAsync(
        ExsitedClient client,
        string workflowId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.DeleteWorkflowAsync(
            workflowId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowStagesAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowStagesAsync(
        ExsitedClient client,
        string workflowId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowStagesAsync(
            workflowId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowStageAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowStageAsync(
        ExsitedClient client,
        string workflowId, string stageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowStageAsync(
            workflowId, stageId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowMilestoneAsync(
        ExsitedClient client,
        string workflowId, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowMilestoneAsync(
            workflowId, milestoneId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowCustomComponentHistoryAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowCustomComponentHistoryAsync(
        ExsitedClient client,
        string componentUuid, string objectCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowCustomComponentHistoryAsync(
            componentUuid, objectCode, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowCustomComponentMilestonesAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowCustomComponentMilestonesAsync(
        ExsitedClient client,
        string componentUuid, string objectCode, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowCustomComponentMilestonesAsync(
            componentUuid, objectCode, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Workflows.GetWorkflowCustomComponentMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> GetWorkflowCustomComponentMilestoneAsync(
        ExsitedClient client,
        string componentUuid, string objectCode, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Workflows.GetWorkflowCustomComponentMilestoneAsync(
            componentUuid, objectCode, milestoneId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
