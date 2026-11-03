namespace Exsited.Resources.SettingsWorkflows.SettingsWorkflowsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsWorkflow : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/workflows",
        "GET /api/{api_version}/settings/workflows/{workflow_id}",
    };

    protected override string? EnvelopeKey => "workflow";

    /// <summary>Untyped.</summary>
    public object? Code { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public bool? EnableStage { get; set; }

    public string? Entity { get; set; }

    public string? Event { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPreBuilt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsWorkflow"/> records, under <c>data</c>.</summary>
public sealed class SettingsWorkflowList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/workflows",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsWorkflow>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
