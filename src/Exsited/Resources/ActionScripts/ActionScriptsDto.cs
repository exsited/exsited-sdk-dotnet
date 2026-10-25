namespace Exsited.Resources.ActionScripts.ActionScriptsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ActionScript : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/action_scripts",
        "GET /api/{api_version}/action_scripts/{action_script_id}",
        "POST /api/{api_version}/action_scripts",
        "PATCH /api/{api_version}/action_scripts/{action_script_id}",
    };

    protected override string? EnvelopeKey => "action_script";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActionName { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public ActionScriptCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public ActionScriptLastUpdatedBy? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ObjectName { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="ActionScript"/> records, under <c>data</c>.</summary>
public sealed class ActionScriptList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/action_scripts",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ActionScript>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class ActionScriptCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class ActionScriptLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
