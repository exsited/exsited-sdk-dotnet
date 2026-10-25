namespace Exsited.Resources.Events.EventsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Event : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/events",
        "GET /api/{api_version}/events/{event_uuid}",
    };

    protected override string? EnvelopeKey => "event";

    public string? CreatedOn { get; set; }

    public string? EventName { get; set; }

    public string? ExecutedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? ResourceType { get; set; }

    public string? ResourceUuid { get; set; }

    public string? ScheduledToExecuteOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Status { get; set; }
}

/// <summary>One page of <see cref="Event"/> records, under <c>data</c>.</summary>
public sealed class EventList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/events",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Event>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class EventRemove : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/events/{event_uuid}/remove",
    };

    protected override string? EnvelopeKey => "event";

    public string? CreatedOn { get; set; }

    public string? EventName { get; set; }

    public string? ExecutedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? ResourceType { get; set; }

    public string? ResourceUuid { get; set; }

    public string? ScheduledToExecuteOn { get; set; }

    public string? Status { get; set; }
}
