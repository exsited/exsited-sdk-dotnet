namespace Exsited.Resources.NoteGroups.NoteGroupsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class NoteGroup : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/note_groups",
        "GET /api/{api_version}/note_groups/{note_group_id}",
    };

    protected override string? EnvelopeKey => "note_group";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="NoteGroup"/> records, under <c>data</c>.</summary>
public sealed class NoteGroupList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/note_groups",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<NoteGroup>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class NoteGroupNotes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/note_groups/{note_group_id}/notes",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class NoteGroupsView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/note_groups",
    };

    protected override string? EnvelopeKey => "note_group";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class NoteGroupUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/note_groups/{note_group_id}",
    };

    protected override string? EnvelopeKey => "note_group";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}
