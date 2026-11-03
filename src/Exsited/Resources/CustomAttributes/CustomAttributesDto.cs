namespace Exsited.Resources.CustomAttributes.CustomAttributesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class CustomAttribute : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_attributes",
        "GET /api/{api_version}/custom_attributes/{custom_attribute_id}",
    };

    protected override string? EnvelopeKey => "custom_attribute";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public bool? EncryptData { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IncludeSeconds { get; set; }

    public bool? IsMandatory { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? MaxLength { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxSize { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxValue { get; set; }

    /// <summary>Untyped.</summary>
    public object? MetaData { get; set; }

    /// <summary>Untyped.</summary>
    public object? MinValue { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Options { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? TimeFormat { get; set; }

    public string? Type { get; set; }

    /// <summary>Untyped.</summary>
    public object? Unit { get; set; }

    /// <summary>Untyped.</summary>
    public object? Uom { get; set; }

    public IReadOnlyList<object?>? UseIn { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="CustomAttribute"/> records, under <c>data</c>.</summary>
public sealed class CustomAttributeList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_attributes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<CustomAttribute>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class CustomAttributesView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/custom_attributes",
    };

    protected override string? EnvelopeKey => "custom_attribute";

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public bool? EncryptData { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IncludeSeconds { get; set; }

    public bool? IsMandatory { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? MaxLength { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxSize { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxValue { get; set; }

    public string? MetaData { get; set; }

    /// <summary>Untyped.</summary>
    public object? MinValue { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Option>? Options { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? TimeFormat { get; set; }

    public string? Type { get; set; }

    /// <summary>Untyped.</summary>
    public object? Unit { get; set; }

    /// <summary>Untyped.</summary>
    public object? Uom { get; set; }

    public IReadOnlyList<object?>? UseIn { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class CustomAttributeUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/custom_attributes/{custom_attribute_id}",
    };

    protected override string? EnvelopeKey => "custom_attribute";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public bool? EncryptData { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IncludeSeconds { get; set; }

    public bool? IsMandatory { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxLength { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxSize { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxValue { get; set; }

    /// <summary>Untyped.</summary>
    public object? MetaData { get; set; }

    /// <summary>Untyped.</summary>
    public object? MinValue { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? Options { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? TimeFormat { get; set; }

    public string? Type { get; set; }

    /// <summary>Untyped.</summary>
    public object? Unit { get; set; }

    /// <summary>Untyped.</summary>
    public object? Uom { get; set; }

    public IReadOnlyList<object?>? UseIn { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>options</c>.</summary>
public sealed class Option : Dto
{
    public long? DisplayOrder { get; set; }

    public string? Name { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}
