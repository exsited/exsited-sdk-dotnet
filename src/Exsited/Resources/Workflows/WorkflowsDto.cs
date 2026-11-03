namespace Exsited.Resources.Workflows.WorkflowsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class WorkflowMilestone : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/workflows/{workflow_uuid}/milestones",
    };

    public ActivityDefinition? ActivityDefinition { get; set; }

    /// <summary>Untyped.</summary>
    public object? AutoCreate { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Untyped.</summary>
    public object? EstimatedHours { get; set; }

    public string? Href { get; set; }

    /// <summary>Untyped.</summary>
    public object? Icon { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Priority { get; set; }

    /// <summary>Untyped.</summary>
    public object? SortOrder { get; set; }

    public string? Status { get; set; }

    public Workflow? Workflow { get; set; }

    public WorkflowVersion? WorkflowVersion { get; set; }
}

/// <summary>One page of <see cref="WorkflowMilestone"/> records, under <c>data</c>.</summary>
public sealed class WorkflowMilestoneList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/workflows/{workflow_uuid}/milestones",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<WorkflowMilestone>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>workflow</c>.</summary>
public sealed class Workflow : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? Code { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? Entity { get; set; }

    public long? EntityId { get; set; }

    public string? Event { get; set; }

    public bool? IsPreBuilt { get; set; }

    public bool? EnableStage { get; set; }

    public WorkflowCurrentVersion? CurrentVersion { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomForm { get; set; }

    public string? CreatedOn { get; set; }

    public string? LastUpdatedOn { get; set; }

    public WorkflowCreatedBy? CreatedBy { get; set; }

    public WorkflowLastUpdatedBy? LastUpdatedBy { get; set; }
}

/// <summary>An object sent as <c>activity_definition</c>.</summary>
public sealed class ActivityDefinition : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>workflow_version</c>.</summary>
public sealed class WorkflowVersion : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class WorkflowList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/workflows",
    };

    public IReadOnlyList<Workflow>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class WorkflowView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/workflows/{workflow_id}",
    };

    protected override string? EnvelopeKey => "workflow";
}

/// <summary>An object sent as <c>current_version</c>.</summary>
public sealed class WorkflowCurrentVersion : Dto
{
    public string? Object { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class WorkflowCreatedBy : Dto
{
    public string? Object { get; set; }

    public string? Name { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class WorkflowLastUpdatedBy : Dto
{
    public string? Object { get; set; }

    public string? Name { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class WorkflowMilestoneView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/workflows/{workflow_id}/milestones/{milestone_id}",
    };

    protected override string? EnvelopeKey => "workflow_milestone";
}
