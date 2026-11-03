namespace Exsited.Resources.CustomComponents.CustomComponentsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class Component : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/component",
        "GET /api/{api_version}/component/{component_uuid}",
        "POST /api/{api_version}/component",
        "PATCH /api/{api_version}/component/{component_uuid}",
    };

    protected override string? EnvelopeKey => "component";

    public IReadOnlyList<object?>? ChildCustomComponents { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomComponent { get; set; }

    public IReadOnlyList<object?>? CustomForms { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? UseIn { get; set; }

    public long? Version { get; set; }

    /// <summary>On the create answer only.</summary>
    public IReadOnlyList<object?>? ActivityLogs { get; set; }
}

/// <summary>One page of <see cref="Component"/> records, under <c>data</c>.</summary>
public sealed class ComponentList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/component",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Component>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentByUuid : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/component/{component_uuid}",
        "PATCH /api/{api_version}/component/{component_uuid}/{component_object_id}",
    };

    /// <summary>The envelope is keyed by the component's own name, so the body's one key is unwrapped whatever it is.</summary>
    protected override IReadOnlyDictionary<string, object?> ReadSource(
        IReadOnlyDictionary<string, object?> body) =>
        body.Count == 1 && body.Values.First() is IReadOnlyDictionary<string, object?> record
            ? record
            : body;

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? AttributeGroups { get; set; }

    public IReadOnlyList<object?>? Attributes { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Parents { get; set; }

    public IReadOnlyList<object?>? Restrictions { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObject : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}",
    };

    protected override string? EnvelopeKey => "custom_component_object";

    public IReadOnlyList<object?>? Accounts { get; set; }

    public IReadOnlyList<object?>? AttributeGroups { get; set; }

    public IReadOnlyList<object?>? Attributes { get; set; }

    public string? Code { get; set; }

    public ComponentEntry? Component { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Items { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Orders { get; set; }

    public IReadOnlyList<object?>? Parents { get; set; }

    public IReadOnlyList<object?>? Quotes { get; set; }

    public IReadOnlyList<object?>? Restrictions { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? WorkflowData { get; set; }

    /// <summary>Untyped.</summary>
    public object? WorkflowStage { get; set; }

    /// <summary>Untyped.</summary>
    public object? WorkflowStatus { get; set; }

    /// <summary>Untyped.</summary>
    public object? WorkflowStatusUuid { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjects : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>No endpoint names this view directly.</summary>
public sealed class ComponentObjectActivity : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity",
    };

    protected override string? EnvelopeKey => "Acc Cus Comp";

    public IReadOnlyList<object?>? Activites { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }
}

/// <summary>No endpoint names this view directly.</summary>
public sealed class ComponentObjectCustomObjects : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects",
    };

    public IReadOnlyList<object?>? CustomObjects { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectActivityRow : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity",
    };
}

/// <summary>One page of <see cref="ComponentObjectActivityRow"/> records, under <c>data</c>.</summary>
public sealed class ComponentObjectActivityList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ComponentObjectActivityRow>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectCustomObject : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects",
    };
}

/// <summary>One page of <see cref="ComponentObjectCustomObject"/> records, under <c>data</c>.</summary>
public sealed class ComponentObjectCustomObjectList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ComponentObjectCustomObject>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>component</c>.</summary>
public sealed class ComponentEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectRecord : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/components/{component_uuid}/objects",
        "PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}",
    };

    protected override string? EnvelopeKey => "custom_component_object";

    public IReadOnlyList<ComponentObjectRecordActivityLog>? ActivityLogs { get; set; }

    public string? LastUpdatedOn { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>.</summary>
public sealed class ComponentObjectRecordActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectActivityEntry : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity",
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity/{activity_id}",
    };

    protected override string? EnvelopeKey => "custom_component_object_activity";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Message { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public string? UserName { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes",
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}",
        "POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes",
        "PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<ComponentObjectNoteAttachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public ComponentObjectNoteCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public ComponentObjectNoteCustomComponentObject? CustomComponentObject { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public ComponentObjectNoteLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="ComponentObjectNote"/> records, under <c>data</c>.</summary>
public sealed class ComponentObjectNotes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ComponentObjectNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>.</summary>
public sealed class ComponentObjectNoteAttachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class ComponentObjectNoteCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_component_object</c>.</summary>
public sealed class ComponentObjectNoteCustomComponentObject : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class ComponentObjectNoteLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectNoteFiles : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files",
    };

    public IReadOnlyList<ComponentObjectNoteAttachment>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ComponentObjectNoteFile : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files/{file_id}",
    };

    protected override string? EnvelopeKey => "file";
}
