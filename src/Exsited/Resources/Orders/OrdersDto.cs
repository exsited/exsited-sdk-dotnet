namespace Exsited.Resources.Orders.OrdersDto;

/// <summary>A typed view of the response body.</summary>
public sealed class Order : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public bool? AllowContract { get; set; }

    public BillingAddress? BillingAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public string? BillingStartDayOfMonth { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public ContractProperties? ContractProperties { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    public DiscountProfile? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    public string? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    public ReferralAccount? ReferralAccount { get; set; }

    public SalesRep? SalesRep { get; set; }

    public ShippingAddress? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public ShippingProfile? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Order"/> records, under <c>data</c>.</summary>
public sealed class OrderList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Order>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Order { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="OrderNote"/> records, under <c>data</c>.</summary>
public sealed class OrderNoteList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<OrderNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}",
        "POST /api/{api_version}/orders",
        "POST /api/{api_version}/orders/{order_id}/change/preview",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    public BillingAddress? BillingAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public string? BillingStartDayOfMonth { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Sent for a contract order, on the create answer and on the read.</summary>
    public OrderReadContractProperties? ContractProperties { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    public DiscountProfile? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    public string? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    public ShippingAddress? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderInformation : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/information",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public bool? AllowContract { get; set; }

    public BillingAddress? BillingAddress { get; set; }

    public string? BillingStartDate { get; set; }

    public string? BillingStartDayOfMonth { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    public DiscountProfile? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    public string? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    public ShippingAddress? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class AccountOrders : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/orders",
        "GET /api/{api_version}/orders/{order_id}/custom_objects",
        "GET /api/{api_version}/orders/{order_id}/custom_objects_instances",
        "GET /api/{api_version}/orders/{order_id}/item_fulfillments",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderBillingPreferences : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderLines : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/lines",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderPaymentMethods : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/payment_methods",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyList<PaymentMethod>? PaymentMethods { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderPdf : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/pdf",
    };

    protected override string? EnvelopeKey => "order";

    public Pdf? Pdf { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderLine : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/lines/{line_uuid}",
    };

    protected override string? EnvelopeKey => "order_line";

    public string? ChargeItemUuid { get; set; }

    public string? ExpectedDeliveryDate { get; set; }

    public string? Id { get; set; }

    public Item? Item { get; set; }

    public ItemAccountingCode? ItemAccountingCode { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<object?>? ItemCustomAttributes { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemInvoiceNote { get; set; }

    public long? ItemOrderQuantity { get; set; }

    public ItemPriceSnapshot? ItemPriceSnapshot { get; set; }

    public ItemPriceTax? ItemPriceTax { get; set; }

    public ItemProperties? ItemProperties { get; set; }

    public ItemSaleTaxConfiguration? ItemSaleTaxConfiguration { get; set; }

    public string? ItemType { get; set; }

    public string? Object { get; set; }

    public PreOrderStockDetails? PreOrderStockDetails { get; set; }

    public double? ShippingCost { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderNoteRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public OrderEntry? Order { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderPaymentMethod : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/payment_methods/{payment_method_ref}",
    };

    protected override string? EnvelopeKey => "order";

    public PaymentMethod? PaymentMethod { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderNoteFile : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files",
        "GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files/{order_file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="OrderNoteFile"/> records, under <c>data</c>.</summary>
public sealed class OrderNoteFileList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<OrderNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderActivateDraft : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/activate_draft",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderBillingPreferencesUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/orders/{order_id}/billing_preferences",
        "PUT /api/{api_version}/orders/{order_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderCancel : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/cancel",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderChange : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/change",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderConvertToOrder : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/convert_to_order",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderDiscardDraft : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/discard_draft",
    };

    protected override string? EnvelopeKey => "order";

    public string? Message { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderExtendTrial : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/extend_trial",
    };

    protected override string? EnvelopeKey => "order";

    public string? Message { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderInformationUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/orders/{order_id}/information",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderNotes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/notes",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public OrderEntry? Order { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderReactivate : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/reactivate",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderRelinquish : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/orders/{order_id}/relinquish",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderLineUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/orders/{order_id}/lines/{line_uuid}",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderNoteUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/orders/{order_id}/notes/{order_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public OrderEntry? Order { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderLineBillingPreferences : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/orders/{order_id}/lines/{line_uuid}/billing_preferences",
        "PUT /api/{api_version}/orders/{order_id}/lines/{line_uuid}/billing_preferences",
    };

    protected override string? EnvelopeKey => "order";

    public Account? Account { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>.</summary>
public sealed class Line : Dto
{
    public string? ChargeItemUuid { get; set; }

    public string? ExpectedDeliveryDate { get; set; }

    public string? Id { get; set; }

    public Item? Item { get; set; }

    public ItemAccountingCode? ItemAccountingCode { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<ItemCustomAttribute>? ItemCustomAttributes { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemInvoiceNote { get; set; }

    public long? ItemOrderQuantity { get; set; }

    public ItemPriceSnapshot? ItemPriceSnapshot { get; set; }

    public ItemPriceTax? ItemPriceTax { get; set; }

    public ItemProperties? ItemProperties { get; set; }

    public ItemSaleTaxConfiguration? ItemSaleTaxConfiguration { get; set; }

    public string? ItemType { get; set; }

    public string? Object { get; set; }

    public PreOrderStockDetails? PreOrderStockDetails { get; set; }

    public double? ShippingCost { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_methods</c>.</summary>
public sealed class PaymentMethod : Dto
{
    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public bool? Default { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUsedAt { get; set; }

    public string? Object { get; set; }

    public long? PaymentCount { get; set; }

    public Processor? Processor { get; set; }

    public string? ProcessorType { get; set; }

    public string? Reference { get; set; }

    public bool? RestrictedToOrders { get; set; }

    public string? SpecifiedOrderIds { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>pdf</c>.</summary>
public sealed class Pdf : Dto
{
    public string? DownloadUrl { get; set; }

    public long? FileSize { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreviewUrl { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class Item : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>item_price_snapshot</c>.</summary>
public sealed class ItemPriceSnapshot : Dto
{
    public PricingRule? PricingRule { get; set; }
}

/// <summary>An object sent as <c>item_price_tax</c>.</summary>
public sealed class ItemPriceTax : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Rate { get; set; }
}

/// <summary>An object sent as <c>item_sale_tax_configuration</c>.</summary>
public sealed class ItemSaleTaxConfiguration : Dto
{
    public string? SalePriceIsBasedOn { get; set; }

    public TaxCode? TaxCode { get; set; }
}

/// <summary>An object sent as <c>item_accounting_code</c>.</summary>
public sealed class ItemAccountingCode : Dto
{
    /// <summary>Untyped: the field's type varies.</summary>
    public object? SalesRevenue { get; set; }
}

/// <summary>An object sent as <c>pre_order_stock_details</c>.</summary>
public sealed class PreOrderStockDetails : Dto
{
    public string? PendingReserve { get; set; }

    public string? Reserved { get; set; }

    public string? Sold { get; set; }
}

/// <summary>An object sent as <c>item_properties</c>.</summary>
public sealed class ItemProperties : Dto
{
    public string? BillingMode { get; set; }

    public string? ChargingAndBillingAlignment { get; set; }

    public string? ChargingPeriod { get; set; }

    public string? ChargingStartDate { get; set; }

    public string? ProRataPartialChargingPeriod { get; set; }

    public string? ProRataPartialPricingPeriod { get; set; }
}

/// <summary>An object sent as <c>order</c>.</summary>
public sealed class OrderEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>.</summary>
public sealed class Attachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>.</summary>
public sealed class Watcher : Dto
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>.</summary>
public sealed class Currency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>time_zone</c>.</summary>
public sealed class TimeZone : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>billing_preferences</c>.</summary>
public sealed class BillingPreferences : Dto
{
    public string? BillingPeriod { get; set; }

    public string? CommunicationProfile { get; set; }

    public bool? ConsolidateInvoice { get; set; }

    public string? FulfillmentMode { get; set; }

    public string? FulfillmentTerm { get; set; }

    public string? InvoiceMode { get; set; }

    public string? InvoiceTerm { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? PaymentTerm { get; set; }

    public string? PaymentTermAlignment { get; set; }

    public ProformaProperties? ProformaProperties { get; set; }
}

/// <summary>An object sent as <c>kpis</c>.</summary>
public sealed class Kpis : Dto
{
    /// <summary>Untyped.</summary>
    public object? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? DeletedAt { get; set; }

    public string? EstimatedTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastCancelledAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastChangedAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastReactivatedAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? MonthlyRecurringRevenue { get; set; }

    /// <summary>Untyped.</summary>
    public object? NextInvoiceIssueDate { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? StartDate { get; set; }

    public string? TotalCollected { get; set; }

    public string? TotalDue { get; set; }

    public long? TotalInvoice { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalRevenue { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>An object sent as <c>contract_properties</c>.</summary>
public sealed class ContractProperties : Dto
{
    public bool? AllowDowngrade { get; set; }

    public bool? AllowDowngradeCharge { get; set; }

    public bool? AllowEarlyTermination { get; set; }

    public bool? AllowPostponement { get; set; }

    public bool? AllowTrial { get; set; }

    public bool? AllowUpgrade { get; set; }

    public string? AutoRenewalEndsOn { get; set; }

    public bool? AutoRenewalRequireCustomerAcceptance { get; set; }

    public string? AutoRenewalTerm { get; set; }

    public string? DowngradeChargeFixed { get; set; }

    public string? DowngradeChargeType { get; set; }

    public string? InitialContractTerm { get; set; }

    public string? PeriodBeforeDowngrade { get; set; }

    public string? RenewAutomatically { get; set; }

    public bool? RequireCustomerAcceptance { get; set; }

    public bool? RequiresPaymentMethod { get; set; }

    public string? TerminationAccountingCode { get; set; }

    public string? TerminationNoticePeriod { get; set; }
}

/// <summary>An object sent as <c>contract_properties</c> on an <see cref="OrderRead"/>.</summary>
public sealed class OrderReadContractProperties : Dto
{
    public bool? AllowDowngrade { get; set; }

    public bool? AllowEarlyTermination { get; set; }

    public bool? AllowPostponement { get; set; }

    public bool? AllowTrial { get; set; }

    public bool? AllowUpgrade { get; set; }

    public bool? ApplyEarlyTerminationCharge { get; set; }

    public string? AutoRenewalEndsOn { get; set; }

    public bool? AutoRenewalRequireCustomerAcceptance { get; set; }

    public string? AutoRenewalTerm { get; set; }

    public string? EarlyTerminationChargeType { get; set; }

    public string? EarlyTerminationMinimumPeriod { get; set; }

    public string? InitialContractTerm { get; set; }

    public string? RenewAutomatically { get; set; }

    public bool? RequireCustomerAcceptance { get; set; }

    public bool? RequiresPaymentMethod { get; set; }

    public bool? StartContractAfterTrialEnds { get; set; }

    public string? TerminationAccountingCode { get; set; }

    public string? TerminationFixedCharge { get; set; }

    public string? TerminationNoticePeriod { get; set; }

    public string? TrialEndDate { get; set; }

    public string? TrialPeriod { get; set; }

    public bool? TrialRequiresPaymentMethod { get; set; }
}

/// <summary>One entry of a list sent as <c>item_custom_attributes</c>.</summary>
public sealed class ItemCustomAttribute : Dto
{
    public string? Name { get; set; }

    /// <summary>A string for a <c>STRING</c> attribute and a list of strings for others, so untyped.</summary>
    public object? Value { get; set; }
}

/// <summary>An object sent as <c>processor</c>.</summary>
public sealed class Processor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>pricing_rule</c>.</summary>
public sealed class PricingRule : Dto
{
    public double? Price { get; set; }

    public string? PricePeriod { get; set; }

    public string? PriceType { get; set; }

    public string? PricingLevel { get; set; }

    public string? PricingMethod { get; set; }

    public string? PricingSchedule { get; set; }

    public string? Uom { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }

    public string? Warehouse { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>.</summary>
public sealed class TaxCode : Dto
{
    public string? Code { get; set; }

    public string? Link { get; set; }

    /// <summary>Untyped: the field's type varies.</summary>
    public object? Rate { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>proforma_properties</c>.</summary>
public sealed class ProformaProperties : Dto
{
    /// <summary>Untyped.</summary>
    public object? AcceptanceDate { get; set; }

    public bool? AcceptanceRequired { get; set; }

    /// <summary>Untyped.</summary>
    public object? AcceptanceTerm { get; set; }

    public bool? PaymentRequired { get; set; }

    /// <summary>Untyped.</summary>
    public object? TermsAndConditions { get; set; }
}

/// <summary>An object sent as <c>discount_profile</c>.</summary>
public sealed class DiscountProfile : Dto
{
    public string? Amount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? RedemptionCode { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>billing_address</c>.</summary>
public sealed class BillingAddress : Dto
{
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? AddressLine5 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }
}

/// <summary>An object sent as <c>shipping_address</c>.</summary>
public sealed class ShippingAddress : Dto
{
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? AddressLine5 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }
}

/// <summary>An object sent as <c>sales_rep</c>.</summary>
public sealed class SalesRep : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>shipping_profile</c>.</summary>
public sealed class ShippingProfile : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>referral_account</c>.</summary>
public sealed class ReferralAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderKpis : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/kpis",
    };

    protected override string? EnvelopeKey => "order_kpis";

    /// <summary>Untyped.</summary>
    public object? DeletedAt { get; set; }

    public string? EstimatedTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastCancelledAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastChangedAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastReactivatedAt { get; set; }

    public string? MonthlyRecurringRevenue { get; set; }

    /// <summary>Untyped.</summary>
    public object? NextInvoiceIssueDate { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? StartDate { get; set; }

    public string? TotalCollected { get; set; }

    public string? TotalDue { get; set; }

    public long? TotalInvoice { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalRevenue { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderCustomObject : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/custom_objects/{custom_object_id}",
        "GET /api/{api_version}/orders/{order_id}/custom_objects_instances/{custom_object_id}",
    };

    protected override string? EnvelopeKey => "custom_object";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomComponent { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Instances { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Relation { get; set; }

    public string? UseIn { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderItemFulfillment : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/item_fulfillments/{fulfillment_id}",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public OrderItemFulfillmentAccount? Account { get; set; }

    public string? Code { get; set; }

    public OrderItemFulfillmentCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomAttributes { get; set; }

    /// <summary>Untyped.</summary>
    public object? DeliveryStatus { get; set; }

    public bool? FulfillmentCompleted { get; set; }

    public string? FulfillmentDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? FulfillmentNote { get; set; }

    public string? FulfillmentStatus { get; set; }

    public IReadOnlyList<OrderItemFulfillmentFulfillment>? Fulfillments { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public OrderItemFulfillmentInvoice? Invoice { get; set; }

    public OrderItemFulfillmentLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? Order { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderPayment : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/payments/{payment_id}",
    };

    protected override string? EnvelopeKey => "payment";

    public OrderPaymentAccount? Account { get; set; }

    public OrderPaymentCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditApplied { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? GiftCertificateApplied { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<OrderPaymentInvoice>? Invoices { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public IReadOnlyList<OrderPaymentPaymentApplied>? PaymentApplied { get; set; }

    public string? PaymentNote { get; set; }

    public string? ReconcileStatus { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class OrderQuotePartialInvoices : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/orders/{order_id}/quote_partial_invoices",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyList<object?>? PartialInvoices { get; set; }
}

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class OrderItemFulfillmentAccount : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class OrderItemFulfillmentCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>fulfillments</c>.</summary>
public sealed class OrderItemFulfillmentFulfillment : Dto
{
    public long? FulfillmentIndex { get; set; }

    public double? FulfillmentQty { get; set; }

    public double? FulfillmentSentQty { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InventoryTracking { get; set; }

    public OrderItemFulfillmentFulfillmentItem? Item { get; set; }

    public string? Object { get; set; }

    public double? PendingReturn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Returned { get; set; }

    public string? ServingStatus { get; set; }

    /// <summary>Untyped.</summary>
    public object? Uom { get; set; }

    /// <summary>Untyped.</summary>
    public object? UomPrecision { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class OrderItemFulfillmentFulfillmentItem : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>invoice</c>.</summary>
public sealed class OrderItemFulfillmentInvoice : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class OrderItemFulfillmentLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class OrderPaymentAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class OrderPaymentCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>invoices</c>.</summary>
public sealed class OrderPaymentInvoice : Dto
{
    public string? Applied { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? Outstanding { get; set; }

    public string? Total { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_applied</c>.</summary>
public sealed class OrderPaymentPaymentApplied : Dto
{
    public string? Amount { get; set; }

    /// <summary>Untyped.</summary>
    public object? GatewayResponse { get; set; }

    public string? Method { get; set; }

    public string? Processor { get; set; }

    public string? Reference { get; set; }
}
