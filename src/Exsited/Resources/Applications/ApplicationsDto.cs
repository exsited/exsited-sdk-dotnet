namespace Exsited.Resources.Applications.ApplicationsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsApplication : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/applications",
        "GET /api/{api_version}/settings/applications/{application_id}",
        "POST /api/{api_version}/settings/applications",
        "PATCH /api/{api_version}/settings/applications/{application_id}",
    };

    protected override string? EnvelopeKey => "application";

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
}

/// <summary>One page of <see cref="SettingsApplication"/> records, under <c>data</c>.</summary>
public sealed class SettingsApplicationList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/applications",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsApplication>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
