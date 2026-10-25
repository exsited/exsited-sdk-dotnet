namespace Exsited.Resources.InventoryAdjustments.InventoryAdjustmentsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InventoryAdjustment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/inventory_adjustments",
        "GET /api/{api_version}/inventory_adjustments/{inventory_adjustment_id}",
        "GET /api/{api_version}/items/{item_id}/inventory_adjustments",
    };

    protected override string? EnvelopeKey => "inventory_adjustment";

    public string? AdjustmentAmount { get; set; }

    public string? AdjustmentType { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? QuantityAvailable { get; set; }

    public string? QuantityOnHand { get; set; }

    public string? QuantityOnOrder { get; set; }

    public string? QuantityOnPurchaseReturn { get; set; }

    public string? QuantityOnReserve { get; set; }

    public string? QuantityOnReturn { get; set; }

    public string? QuantityPromised { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? WarehouseName { get; set; }
}

/// <summary>One page of <see cref="InventoryAdjustment"/> records, under <c>data</c>.</summary>
public sealed class InventoryAdjustmentList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/inventory_adjustments",
        "GET /api/{api_version}/items/{item_id}/inventory_adjustments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<InventoryAdjustment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
