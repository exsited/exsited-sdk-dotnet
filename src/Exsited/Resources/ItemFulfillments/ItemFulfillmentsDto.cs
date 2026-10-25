namespace Exsited.Resources.ItemFulfillments.ItemFulfillmentsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_fulfillments",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomAttributes { get; set; }

    public string? Date { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DeliveryStatus { get; set; }

    public bool? FulfillmentCompleted { get; set; }

    public string? FulfillmentDate { get; set; }

    public string? FulfillmentNote { get; set; }

    public string? FulfillmentStatus { get; set; }

    public IReadOnlyList<object?>? Fulfillments { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? Invoice { get; set; }

    public string? InvoiceId { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? OrderId { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="ItemFulfillment"/> records, under <c>data</c>.</summary>
public sealed class ItemFulfillmentList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_fulfillments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemFulfillment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillmentRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments",
        "GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments/{fulfillment_id}",
        "GET /api/{api_version}/item_fulfillments/{fulfillment_id}",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomAttributes { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DeliveryStatus { get; set; }

    public bool? FulfillmentCompleted { get; set; }

    public string? FulfillmentDate { get; set; }

    public string? FulfillmentNote { get; set; }

    public string? FulfillmentStatus { get; set; }

    public IReadOnlyList<object?>? Fulfillments { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? Invoice { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillmentsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/item_fulfillments",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public string? FulfillmentDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? FulfillmentNote { get; set; }

    public string? FulfillmentStatus { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemFulfillment { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillmentUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/item_fulfillments/{fulfillment_id}",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillmentNotes : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/item_fulfillments/{fulfillment_id}/notes",
    };

    protected override string? EnvelopeKey => "note";

    public string? Href { get; set; }

    public string? Id { get; set; }

    public ItemFulfillmentEntry? ItemFulfillment { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>item_fulfillment</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentNote : Dto
{
    public IReadOnlyList<ItemFulfillmentNoteAttachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public ItemFulfillmentCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public ItemFulfillmentNotesDetail? ItemFulfillment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<ItemFulfillmentNoteWatcher>? Watchers { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentNoteAttachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentNoteWatcher : Dto
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>One page of <see cref="ItemFulfillmentNote"/> records, under <c>data</c>.</summary>
public sealed class ItemFulfillmentNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_fulfillments/{fulfillment_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemFulfillmentNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFulfillmentNoteRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_fulfillments/{fulfillment_id}/notes/{note_id}",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public ItemFulfillmentNote? Note { get; set; }
}

/// <summary>An object sent as <c>item_fulfillment</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentNotesDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class ItemFulfillmentCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
