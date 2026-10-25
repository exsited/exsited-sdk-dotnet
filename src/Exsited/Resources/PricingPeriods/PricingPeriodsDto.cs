namespace Exsited.Resources.PricingPeriods.PricingPeriodsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPricingPeriod : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/pricing_periods",
        "GET /api/{api_version}/settings/pricing_periods/{pricing_period_id}",
        "POST /api/{api_version}/settings/pricing_periods",
        "PATCH /api/{api_version}/settings/pricing_periods/{pricing_period_id}",
    };

    protected override string? EnvelopeKey => "pricing_period";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public SettingsPricingPeriodTimePeriod? TimePeriod { get; set; }
}

/// <summary>One page of <see cref="SettingsPricingPeriod"/> records, under <c>data</c>.</summary>
public sealed class SettingsPricingPeriodList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/pricing_periods",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsPricingPeriod>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>time_period</c>, merged over every record measured.</summary>
public sealed class SettingsPricingPeriodTimePeriod : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
