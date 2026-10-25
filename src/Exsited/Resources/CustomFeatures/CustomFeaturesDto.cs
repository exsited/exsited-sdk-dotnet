namespace Exsited.Resources.CustomFeatures.CustomFeaturesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CustomFeature : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/custom_feature",
        "PATCH /api/{api_version}/custom_feature/{custom_feature_id}",
        "POST /api/{api_version}/custom_feature/{custom_feature_id}",
        "GET /api/{api_version}/custom_feature/{custom_feature_id}",
    };

    protected override string? EnvelopeKey => "custom_feature";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? ChildCustomComponents { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

    public IReadOnlyList<CustomForm>? CustomForms { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Message { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? UseIn { get; set; }

    public long? Version { get; set; }

    [WireName("custom_feature")]
    public CustomFeatureDetail? CustomFeatureValue { get; set; }
}

/// <summary>One entry of a list sent as <c>custom_forms</c>, merged over every record measured.</summary>
public sealed class CustomForm : Dto
{
    public Configuration? Configuration { get; set; }
}

/// <summary>An object sent as <c>configuration</c>, merged over every record measured.</summary>
public sealed class Configuration : Dto
{
    public Column1? Column1 { get; set; }

    public Column2? Column2 { get; set; }

    public SettingsEntry? Settings { get; set; }
}

/// <summary>An object sent as <c>column_1</c>, merged over every record measured.</summary>
public sealed class Column1 : Dto
{
    public IReadOnlyList<AttributeEntry>? Attributes { get; set; }
}

/// <summary>An object sent as <c>column_2</c>, merged over every record measured.</summary>
public sealed class Column2 : Dto
{
    public IReadOnlyList<AttributeEntry>? Attributes { get; set; }
}

/// <summary>An object sent as <c>settings</c>, merged over every record measured.</summary>
public sealed class SettingsEntry : Dto
{
    public string? CustomForm { get; set; }

    public string? FormLayout { get; set; }
}

/// <summary>One entry of a list sent as <c>attributes</c>, merged over every record measured.</summary>
public sealed class AttributeEntry : Dto
{
    public string? DataType { get; set; }

    public string? DisplayName { get; set; }

    public string? Name { get; set; }

    public bool? ShowInListView { get; set; }

    public string? Type { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CustomFeatureList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_feature",
    };

    public IReadOnlyList<CustomFeatureDetail>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetail : Dto
{
    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? ChildCustomComponents { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

    public IReadOnlyList<CustomFeatureDetailCustomForm>? CustomForms { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? UseIn { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>custom_forms</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomForm : Dto
{
    public CustomFeatureDetailCustomFormConfiguration? Configuration { get; set; }
}

/// <summary>An object sent as <c>configuration</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfiguration : Dto
{
    public CustomFeatureDetailCustomFormConfigurationColumn1? Column1 { get; set; }

    public CustomFeatureDetailCustomFormConfigurationColumn2? Column2 { get; set; }

    public CustomFeatureDetailCustomFormConfigurationSettings? Settings { get; set; }
}

/// <summary>An object sent as <c>column_1</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfigurationColumn1 : Dto
{
    public IReadOnlyList<CustomFeatureDetailCustomFormConfigurationColumn1Attribute>? Attributes { get; set; }
}

/// <summary>An object sent as <c>column_2</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfigurationColumn2 : Dto
{
    public IReadOnlyList<CustomFeatureDetailCustomFormConfigurationColumn2Attribute>? Attributes { get; set; }
}

/// <summary>An object sent as <c>settings</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfigurationSettings : Dto
{
    public string? CustomForm { get; set; }

    public string? FormLayout { get; set; }
}

/// <summary>One entry of a list sent as <c>attributes</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfigurationColumn1Attribute : Dto
{
    public string? DataType { get; set; }

    public string? DisplayName { get; set; }

    public string? Name { get; set; }

    public bool? ShowInListView { get; set; }

    public string? Type { get; set; }
}

/// <summary>One entry of a list sent as <c>attributes</c>, merged over every record measured.</summary>
public sealed class CustomFeatureDetailCustomFormConfigurationColumn2Attribute : Dto
{
    public string? Name { get; set; }

    public string? Type { get; set; }
}
