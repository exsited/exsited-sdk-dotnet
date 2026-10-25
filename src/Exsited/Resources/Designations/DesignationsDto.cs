namespace Exsited.Resources.Designations.DesignationsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsDesignation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/designations",
        "GET /api/{api_version}/settings/designations/{designation_id}",
    };

    protected override string? EnvelopeKey => "designation";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsDesignation"/> records, under <c>data</c>.</summary>
public sealed class SettingsDesignationList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/designations",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsDesignation>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
