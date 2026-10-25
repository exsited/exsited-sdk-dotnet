namespace Exsited.Resources.Usages.UsagesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Usage : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/usages",
        "GET /api/{api_version}/usages/{usage_id}",
    };

    protected override string? EnvelopeKey => "usage";

    public IReadOnlyDictionary<string, object?>? ChargeItem { get; set; }

    public string? ChargingEndDate { get; set; }

    public string? ChargingPeriod { get; set; }

    public string? ChargingStartDate { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? EndTime { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public double? Quantity { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Source { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Uom { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Usage"/> records, under <c>data</c>.</summary>
public sealed class UsageList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/usages",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Usage>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class UsagesView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/usages",
    };

    protected override string? EnvelopeKey => "usage";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? ChargeItemName { get; set; }

    public string? ChargeItemUuid { get; set; }

    public string? ChargeStatus { get; set; }

    public string? ChargingPeriod { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? EndTime { get; set; }

    public string? EventId { get; set; }

    public IReadOnlyList<object?>? Failed { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Quantity { get; set; }

    public string? Source { get; set; }

    public string? StartTime { get; set; }

    public IReadOnlyList<object?>? Success { get; set; }

    public string? Type { get; set; }

    public string? Uom { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class UsageUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/usages/{usage_id}",
        "PUT /api/{api_version}/usages/{usage_id}",
    };

    protected override string? EnvelopeKey => "usage";

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
