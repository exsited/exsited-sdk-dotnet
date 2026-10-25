namespace Exsited.Resources.ChargingPeriods.ChargingPeriodsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsChargingPeriod : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/charging_periods",
        "GET /api/{api_version}/settings/charging_periods/{charging_period_id}",
        "POST /api/{api_version}/settings/charging_periods",
        "PATCH /api/{api_version}/settings/charging_periods/{charging_period_id}",
    };

    protected override string? EnvelopeKey => "charging_period";

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

    public SettingsChargingPeriodTimePeriod? TimePeriod { get; set; }
}

/// <summary>One page of <see cref="SettingsChargingPeriod"/> records, under <c>data</c>.</summary>
public sealed class SettingsChargingPeriodList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/charging_periods",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsChargingPeriod>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>time_period</c>, merged over every record measured.</summary>
public sealed class SettingsChargingPeriodTimePeriod : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
