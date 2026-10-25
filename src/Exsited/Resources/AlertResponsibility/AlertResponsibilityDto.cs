namespace Exsited.Resources.AlertResponsibility.AlertResponsibilityDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AlertResponsibilityView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alert_responsibility",
        "GET /api/{api_version}/alert_responsibility/{alert_responsibility_id}",
        "POST /api/{api_version}/alert_responsibility",
        "PATCH /api/{api_version}/alert_responsibility/{alert_responsibility_id}",
    };

    protected override string? EnvelopeKey => "alert_responsibility";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="AlertResponsibilityView"/> records, under <c>data</c>.</summary>
public sealed class AlertResponsibilityList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alert_responsibility",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AlertResponsibilityView>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
