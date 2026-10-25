namespace Exsited.Resources.ItemReceipts.ItemReceiptsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemReceipt : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_receipts",
        "GET /api/{api_version}/item_receipts/{item_receipt_id}",
    };

    protected override string? EnvelopeKey => "item_receipt";

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchaseOrder { get; set; }

    public string? ReceiptDate { get; set; }

    public string? ReceiptNote { get; set; }

    public string? ReceiptStatus { get; set; }

    public bool? ReceiveCompleted { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="ItemReceipt"/> records, under <c>data</c>.</summary>
public sealed class ItemReceiptList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/item_receipts",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemReceipt>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemReceiptsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/item_receipts",
    };

    protected override string? EnvelopeKey => "item-receipt";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Date { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? PurchaseOrderId { get; set; }

    public string? ReceiptStatus { get; set; }

    public IReadOnlyList<object?>? Receipts { get; set; }

    public string? TrackingNumber { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemReceiptUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/item_receipts/{item_receipt_id}",
    };

    protected override string? EnvelopeKey => "item_receipt";

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public PurchaseOrder? PurchaseOrder { get; set; }

    public string? PurchaseOrderId { get; set; }

    public string? ReceiptDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReceiptNote { get; set; }

    public string? ReceiptStatus { get; set; }

    public IReadOnlyList<object?>? Receipts { get; set; }

    public bool? ReceiveCompleted { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseOrderItemReceipts : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/item_receipts",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public IReadOnlyList<object?>? ItemReceipts { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }
}

/// <summary>An object sent as <c>purchase_order</c>, merged over every record measured.</summary>
public sealed class PurchaseOrder : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>, merged over every record measured.</summary>
public sealed class Line : Dto
{
    public Item? Item { get; set; }

    public double? PendingReturnQuantity { get; set; }

    public PurchaseOrderLine? PurchaseOrderLine { get; set; }

    public double? ReceiptQuantity { get; set; }

    public double? ReceivedQuantity { get; set; }

    public double? ReturnedQuantity { get; set; }

    public Uom? Uom { get; set; }

    public Warehouse? Warehouse { get; set; }
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

/// <summary>An object sent as <c>purchase_order_line</c>, merged over every record measured.</summary>
public sealed class PurchaseOrderLine : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class Item : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>uom</c>, merged over every record measured.</summary>
public sealed class Uom : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>warehouse</c>, merged over every record measured.</summary>
public sealed class Warehouse : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
