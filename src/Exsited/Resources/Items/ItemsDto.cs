namespace Exsited.Resources.Items.ItemsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Item : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public IReadOnlyList<BundleDetail>? BundleDetails { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<object?>? Codes { get; set; }

    public IReadOnlyList<ConfigureVariation>? ConfigureVariations { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyList<FamilyDetail>? FamilyDetails { get; set; }

    public Group? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    public string? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public IReadOnlyList<PackageDetail>? PackageDetails { get; set; }

    public bool? Parent { get; set; }

    public string? ParentItemId { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public IReadOnlyList<UseVariation>? UseVariations { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }

    /// <summary><c>GetItemAsync</c> sends sale, purchase and inventories inline; activity_logs and the detail lists below wait for their own endpoint.</summary>
    public ItemSale? Sale { get; set; }

    public ItemPurchase? Purchase { get; set; }

    public ItemInventories? Inventories { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public IReadOnlyList<ItemCustomAttribute>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }
}

/// <summary>One page of <see cref="Item"/> records, under <c>data</c>.</summary>
public sealed class ItemList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Item>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemInventoryAdjustment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/inventory_adjustments",
    };

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

/// <summary>One page of <see cref="ItemInventoryAdjustment"/> records, under <c>data</c>.</summary>
public sealed class ItemInventoryAdjustmentList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/inventory_adjustments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemInventoryAdjustment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/notes",
        "POST /api/{api_version}/items/{item_id}/notes",
        "GET /api/{api_version}/items/{item_id}/notes/{item_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? Item { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="ItemNote"/> records, under <c>data</c>.</summary>
public sealed class ItemNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public IReadOnlyList<object?>? BundleDetails { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<object?>? Codes { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyList<object?>? FamilyDetails { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public IReadOnlyDictionary<string, object?>? Inventories { get; set; }

    public bool? InventoryEnabled { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public IReadOnlyList<object?>? PackageDetails { get; set; }

    public bool? Parent { get; set; }

    public IReadOnlyDictionary<string, object?>? Purchase { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public IReadOnlyDictionary<string, object?>? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemSale : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/items/{item_id}/information",
        "PATCH /api/{api_version}/items/{item_id}/inventories",
        "PATCH /api/{api_version}/items/{item_id}/purchase",
        "PATCH /api/{api_version}/items/{item_id}/sale",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<object?>? Codes { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public IReadOnlyDictionary<string, object?>? Inventories { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public IReadOnlyDictionary<string, object?>? Purchase { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public IReadOnlyDictionary<string, object?>? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }

    public bool? Enabled { get; set; }

    public bool? EnableBackOrder { get; set; }

    public double? DefaultSalePrice { get; set; }

    public string? PricingMethod { get; set; }

    public string? SalePriceVariant { get; set; }

    public bool? UseOnSalePrice { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public TaxConfiguration? TaxConfiguration { get; set; }

    public SaleCharge? Charge { get; set; }

    public Pricing? Pricing { get; set; }

    public IReadOnlyList<ItemSalePricingLevel>? PricingLevels { get; set; }

    public IReadOnlyList<object?>? PricingSchedules { get; set; }

    public IReadOnlyList<ItemSalePaymentProperty>? PaymentProperties { get; set; }

    public object? AccountingCode { get; set; }

    public object? DiscountProfile { get; set; }

    public object? PricingProfile { get; set; }

    public object? ShippingProfile { get; set; }

    public object? SalePrice { get; set; }

    public object? StartDate { get; set; }

    public object? EndDate { get; set; }

    public ItemSaleHeight? Height { get; set; }

    public ItemSaleLength? Length { get; set; }

    public ItemSaleWeight? Weight { get; set; }

    public ItemSaleWidth? Width { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}",
    };

    protected override string? EnvelopeKey => "item";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public IReadOnlyList<BundleDetail>? BundleDetails { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<object?>? Codes { get; set; }

    public IReadOnlyList<ConfigureVariation>? ConfigureVariations { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyList<FamilyDetail>? FamilyDetails { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public IReadOnlyDictionary<string, object?>? Inventories { get; set; }

    public bool? InventoryEnabled { get; set; }

    public string? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public IReadOnlyList<PackageDetail>? PackageDetails { get; set; }

    public bool? Parent { get; set; }

    public string? ParentItemId { get; set; }

    public IReadOnlyDictionary<string, object?>? Purchase { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public IReadOnlyDictionary<string, object?>? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public IReadOnlyList<UseVariation>? UseVariations { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemInformation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/information",
    };

    protected override string? EnvelopeKey => "item";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<object?>? Codes { get; set; }

    public IReadOnlyList<ConfigureVariation>? ConfigureVariations { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    public string? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public bool? Parent { get; set; }

    public string? ParentItemId { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public IReadOnlyList<UseVariation>? UseVariations { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemInventories : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/inventories",
    };

    protected override string? EnvelopeKey => "item";

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? Inventories { get; set; }

    public string? Name { get; set; }

    public bool? Enabled { get; set; }

    public bool? EnableWarehouseManagement { get; set; }

    public string? DefaultWarehouse { get; set; }

    public InventoryProperties? InventoryProperties { get; set; }

    public IReadOnlyList<WarehouseInventory>? Warehouses { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemPurchase : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/purchase",
    };

    protected override string? EnvelopeKey => "item";

    public long? Id { get; set; }

    public string? Name { get; set; }

    public IReadOnlyDictionary<string, object?>? Purchase { get; set; }

    public bool? Enabled { get; set; }

    public bool? SupplierManagementEnabled { get; set; }

    public string? PurchaseOrderNote { get; set; }

    public double? DefaultPurchasePrice { get; set; }

    public bool? TaxExemptWhenPurchase { get; set; }

    public TaxConfiguration? TaxConfiguration { get; set; }

    public Pricing? Pricing { get; set; }

    public IReadOnlyList<ItemPurchasePurchaseProperty>? PurchaseProperties { get; set; }

    public object? AccountingCode { get; set; }

    public object? PricingProfile { get; set; }

    public IReadOnlyList<ItemPurchaseSupplier>? Suppliers { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemSaleRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/sale",
    };

    protected override string? EnvelopeKey => "item";

    public long? Id { get; set; }

    public string? Name { get; set; }

    public IReadOnlyDictionary<string, object?>? Sale { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemWarehouseInventories : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/warehouses/{warehouse_name}/inventories",
    };

    protected override string? EnvelopeKey => "item";

    public string? Id { get; set; }

    public Inventories? Inventories { get; set; }

    public string? Name { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemFamilyDetails : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/family_details",
        "POST /api/{api_version}/items/{item_id}/family_details",
    };

    protected override string? EnvelopeKey => "item";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyList<FamilyDetail>? FamilyDetails { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public IReadOnlyList<object?>? PackageDetails { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public Sale? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemPackageDetails : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/package_details",
        "POST /api/{api_version}/items/{item_id}/package_details",
    };

    protected override string? EnvelopeKey => "item";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyList<FamilyDetail>? FamilyDetails { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public IReadOnlyList<PackageDetail>? PackageDetails { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public Sale? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemPackageDetail : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/package_details/{package_detail_id}",
    };

    protected override string? EnvelopeKey => "item";

    public string? Id { get; set; }

    public string? Name { get; set; }

    public IReadOnlyList<PackageDetail>? PackageDetails { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemNoteFile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files",
        "GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files/{item_file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="ItemNoteFile"/> records, under <c>data</c>.</summary>
public sealed class ItemNoteFileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ItemNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemDeactivate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/deactivate",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemReactivate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/reactivate",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemImage : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/image",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemSaleCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/sale",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<Currency>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public Sale? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemPurchaseCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/purchase",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<Currency>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public Purchase? Purchase { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public Sale? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemInventoryAdd : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/items/{item_id}/inventory/add",
    };

    protected override string? EnvelopeKey => "item";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<Currency>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public Inventories? Inventories { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public Purchase? Purchase { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public Sale? Sale { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemBundleDetails : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/items/{item_id}/bundle_details",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BaseUom { get; set; }

    public IReadOnlyList<BundleDetail>? BundleDetails { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? Currencies { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public IReadOnlyList<object?>? Uoms { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemVariations : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/items/{item_id}/variations",
    };

    protected override string? EnvelopeKey => "item";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? Child { get; set; }

    public IReadOnlyList<Code>? Codes { get; set; }

    public IReadOnlyList<ConfigureVariation>? ConfigureVariations { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InventoryEnabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public bool? Parent { get; set; }

    public bool? PurchaseEnabled { get; set; }

    public bool? SaleEnabled { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public bool? VariationsEnabled { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ItemNoteUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/items/{item_id}/notes/{item_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public ItemEntry? Item { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One entry of a list sent as <c>configure_variations</c>, merged over every record measured.</summary>
public sealed class ConfigureVariation : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Value>? Values { get; set; }
}

/// <summary>One entry of a list sent as <c>bundle_details</c>, merged over every record measured.</summary>
public sealed class BundleDetail : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public double? Quantity { get; set; }

    public string? Uom { get; set; }
}

/// <summary>One entry of a list sent as <c>family_details</c>, merged over every record measured.</summary>
public sealed class FamilyDetail : Dto
{
    public string? ItemId { get; set; }

    public string? ItemName { get; set; }
}

/// <summary>One entry of a list sent as <c>package_details</c>, merged over every record measured.</summary>
public sealed class PackageDetail : Dto
{
    public IReadOnlyList<BillingPeriod>? BillingPeriods { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<ItemEntry>? Items { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Rank { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>use_variations</c>, merged over every record measured.</summary>
public sealed class UseVariation : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Value>? Values { get; set; }
}

/// <summary>An object sent as <c>inventories</c>, merged over every record measured.</summary>
public sealed class Inventories : Dto
{
    public string? DefaultWarehouse { get; set; }

    public bool? EnableWarehouseManagement { get; set; }

    public bool? Enabled { get; set; }

    public InventoryProperties? InventoryProperties { get; set; }

    public IReadOnlyList<Warehouse>? Warehouses { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>codes</c>, merged over every record measured.</summary>
public sealed class Code : Dto
{
    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Value { get; set; }
}

/// <summary>An object sent as <c>sale</c>, merged over every record measured.</summary>
public sealed class Sale : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public Charge? Charge { get; set; }

    public double? DefaultSalePrice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DiscountProfile { get; set; }

    public bool? EnableBackOrder { get; set; }

    public bool? Enabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EndDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public IReadOnlyList<PaymentProperty>? PaymentProperties { get; set; }

    public Pricing? Pricing { get; set; }

    public IReadOnlyList<object?>? PricingLevels { get; set; }

    public string? PricingMethod { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingProfile { get; set; }

    public IReadOnlyList<object?>? PricingSchedules { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalePrice { get; set; }

    public string? SalePriceVariant { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ShippingProfile { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartDate { get; set; }

    public TaxConfiguration? TaxConfiguration { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public bool? UseOnSalePrice { get; set; }
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

/// <summary>One entry of a list sent as <c>currencies</c>, merged over every record measured.</summary>
public sealed class Currency : Dto
{
    public bool? DefaultForPurchase { get; set; }

    public bool? DefaultForSale { get; set; }

    public string? Name { get; set; }

    public bool? UsedForPurchase { get; set; }

    public bool? UsedForSale { get; set; }
}

/// <summary>An object sent as <c>purchase</c>, merged over every record measured.</summary>
public sealed class Purchase : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public double? DefaultPurchasePrice { get; set; }

    public bool? Enabled { get; set; }

    public Pricing? Pricing { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingProfile { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PurchaseOrderNote { get; set; }

    public IReadOnlyList<PurchaseProperty>? PurchaseProperties { get; set; }

    public bool? SupplierManagementEnabled { get; set; }

    public TaxConfiguration? TaxConfiguration { get; set; }

    public bool? TaxExemptWhenPurchase { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class ItemEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? Object { get; set; }

    public double? Quantity { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Uom { get; set; }
}

/// <summary>One entry of a list sent as <c>values</c>, merged over every record measured.</summary>
public sealed class Value : Dto
{
    public string? Name { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>billing_periods</c>, merged over every record measured.</summary>
public sealed class BillingPeriod : Dto
{
    public string? Name { get; set; }

    public long? Rank { get; set; }
}

/// <summary>One entry of a list sent as <c>warehouses</c>, merged over every record measured.</summary>
public sealed class Warehouse : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? QuantityAvailable { get; set; }

    public string? QuantityAvailableValue { get; set; }

    public long? QuantityOnHand { get; set; }

    public string? QuantityOnHandValue { get; set; }

    public long? QuantityOnOrder { get; set; }

    public long? QuantityOnPurchaseReturn { get; set; }

    public long? QuantityOnReturn { get; set; }

    public double? QuantityPromised { get; set; }

    public string? Uom { get; set; }

    [WireName("warehouse")]
    public Warehouse? WarehouseValue { get; set; }
}

/// <summary>An object sent as <c>inventory_properties</c>, merged over every record measured.</summary>
public sealed class InventoryProperties : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultCostPerUnit { get; set; }

    public bool? EnableBatchTracking { get; set; }

    public bool? EnableInventoryCosting { get; set; }

    public bool? EnableLowStockNotification { get; set; }

    public bool? EnablePreorder { get; set; }

    public bool? EnableReordering { get; set; }

    public bool? EnableSerialization { get; set; }

    public string? LowStockThresholdBasedOn { get; set; }

    public string? QuantityAvailableForSale { get; set; }

    public IReadOnlyList<string>? QuantityAvailableForSaleDetermination { get; set; }

    public string? ReorderingThresholdBasedOn { get; set; }

    public bool? UseAtpValueAsQuantityAvailableForWebhook { get; set; }

    public bool? Enabled { get; set; }

    public IReadOnlyList<InventoryPropertiesPreorderConfiguration>? PreorderConfiguration { get; set; }

    public string? PreorderPeriod { get; set; }
}

/// <summary>An object sent as <c>tax_configuration</c>, merged over every record measured.</summary>
public sealed class TaxConfiguration : Dto
{
    public bool? PurchasePriceEnteredInclusiveOfTax { get; set; }

    public bool? SalePriceEnteredInclusiveOfTax { get; set; }

    public string? SalePriceBasedOn { get; set; }

    public Reference? TaxCode { get; set; }
}

/// <summary>An object sent as <c>charge</c>, merged over every record measured.</summary>
public sealed class Charge : Dto
{
    public IReadOnlyList<Property>? Properties { get; set; }

    public string? Type { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_properties</c>, merged over every record measured.</summary>
public sealed class PaymentProperty : Dto
{
    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Value { get; set; }
}

/// <summary>An object sent as <c>pricing</c>, merged over every record measured.</summary>
public sealed class Pricing : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LatestUsedPricingVersion { get; set; }

    public IReadOnlyList<object?>? PricingModule { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_properties</c>, merged over every record measured.</summary>
public sealed class PurchaseProperty : Dto
{
    public string? Name { get; set; }

    public string? Value { get; set; }
}

/// <summary>One entry of a list sent as <c>properties</c>, merged over every record measured.</summary>
public sealed class Property : Dto
{
    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Value { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>group</c>, merged over every record measured.</summary>
public sealed class Group : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>, merged over every record measured.</summary>
public sealed class Reference : Dto
{
    public string? Object { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Href { get; set; }
}

/// <summary>An object sent as <c>charge</c>, merged over every record measured.</summary>
public sealed class SaleCharge : Dto
{
    public string? Type { get; set; }

    public string? PricePeriod { get; set; }

    public IReadOnlyList<SaleChargeProperty>? Properties { get; set; }
}

/// <summary>One entry of a list sent as <c>warehouses</c>, merged over every record measured.</summary>
public sealed class WarehouseInventory : Dto
{
    public long? QuantityOnHand { get; set; }

    public string? QuantityOnHandValue { get; set; }

    public double? QuantityAvailable { get; set; }

    public string? QuantityAvailableValue { get; set; }

    public long? QuantityOnOrder { get; set; }

    public double? QuantityPromised { get; set; }

    public long? QuantityOnReturn { get; set; }

    public long? QuantityOnPurchaseReturn { get; set; }

    public Reference? Warehouse { get; set; }

    public string? Uom { get; set; }
}

/// <summary>One entry of a list sent as <c>custom_attributes</c>, merged over every record measured.</summary>
public sealed class ItemCustomAttribute : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Type { get; set; }

    public string? Value { get; set; }
}

/// <summary>One entry of a list sent as <c>pricing_levels</c>, merged over every record measured.</summary>
public sealed class ItemSalePricingLevel : Dto
{
    public string? Name { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_properties</c>, merged over every record measured.</summary>
public sealed class ItemSalePaymentProperty : Dto
{
    public string? Name { get; set; }

    public string? Value { get; set; }
}

/// <summary>An object sent as <c>width</c>, merged over every record measured.</summary>
public sealed class ItemSaleWidth : Dto
{
    public string? Uom { get; set; }

    public double? Value { get; set; }
}

/// <summary>An object sent as <c>height</c>, merged over every record measured.</summary>
public sealed class ItemSaleHeight : Dto
{
    public string? Uom { get; set; }

    public double? Value { get; set; }
}

/// <summary>An object sent as <c>length</c>, merged over every record measured.</summary>
public sealed class ItemSaleLength : Dto
{
    public string? Uom { get; set; }

    public double? Value { get; set; }
}

/// <summary>An object sent as <c>weight</c>, merged over every record measured.</summary>
public sealed class ItemSaleWeight : Dto
{
    public string? Uom { get; set; }

    public double? Value { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_properties</c>, merged over every record measured.</summary>
public sealed class ItemPurchasePurchaseProperty : Dto
{
    public string? Name { get; set; }

    public string? Value { get; set; }
}

/// <summary>One entry of a list sent as <c>suppliers</c>, merged over every record measured.</summary>
public sealed class ItemPurchaseSupplier : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public double? DefaultPurchasePrice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Id { get; set; }

    public string? Name { get; set; }

    public Pricing? Pricing { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PurchaseOrderNote { get; set; }

    public ItemPurchaseSupplierTaxConfiguration? TaxConfiguration { get; set; }

    public bool? TaxExemptWhenPurchase { get; set; }
}

/// <summary>One entry of a list sent as <c>properties</c>, merged over every record measured.</summary>
public sealed class SaleChargeProperty : Dto
{
    public string? Name { get; set; }

    public string? Value { get; set; }
}

/// <summary>An object sent as <c>tax_configuration</c>, merged over every record measured.</summary>
public sealed class ItemPurchaseSupplierTaxConfiguration : Dto
{
    public bool? PurchasePriceEnteredInclusiveOfTax { get; set; }

    public Reference? TaxCode { get; set; }
}

/// <summary>One entry of a list sent as <c>preorder_configuration</c>, merged over every record measured.</summary>
public sealed class InventoryPropertiesPreorderConfiguration : Dto
{
    public string? EndDate { get; set; }

    public string? Name { get; set; }

    public string? StartDate { get; set; }
}
