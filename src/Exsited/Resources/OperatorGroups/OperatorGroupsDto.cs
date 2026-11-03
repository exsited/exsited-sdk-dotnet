namespace Exsited.Resources.OperatorGroups.OperatorGroupsDto;

/// <summary>A typed view of the response body. The create answer carries only <c>object</c>, <c>id</c>, <c>name</c>, <c>display_name</c>, <c>description</c> and <c>href</c>.</summary>
public sealed class SettingsOperatorGroup : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/operator_groups",
        "GET /api/{api_version}/settings/operator_groups/{operator_group_id}",
        "POST /api/{api_version}/settings/operator_groups",
        "PATCH /api/{api_version}/settings/operator_groups/{operator_group_id}",
    };

    protected override string? EnvelopeKey => "operator_group";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<SettingsOperatorGroupDepartment>? Departments { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public SettingsOperatorGroupRole? Role { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsOperatorGroup"/> records, under <c>data</c>.</summary>
public sealed class SettingsOperatorGroupList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/operator_groups",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsOperatorGroup>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>role</c>: a read names it as a <c>role</c> with its <c>rol_</c> id and <c>href</c>, the update answer as a <c>reference</c> with the dashed uuid and no <c>href</c>.</summary>
public sealed class SettingsOperatorGroupRole : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>departments</c>.</summary>
public sealed class SettingsOperatorGroupDepartment : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
