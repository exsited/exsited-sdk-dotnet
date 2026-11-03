namespace Exsited.Resources.PurchaseOrders.PurchaseOrdersDto;

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderLine : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines",
    };

    public string? CreatedOn { get; set; }

    public double? FlatDiscount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPriceTaxInclusive { get; set; }

    public bool? IsTaxExempt { get; set; }

    public IReadOnlyDictionary<string, object?>? Item { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemAccountingCode { get; set; }

    public double? ItemDiscountAmount { get; set; }

    public string? ItemExpectedCompletionDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? ItemInvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemPriceSnapshot { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemPriceTax { get; set; }

    public bool? ItemPriceTaxExempt { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemPurchaseAccountingCode { get; set; }

    public IReadOnlyDictionary<string, object?>? ItemPurchaseTaxConfiguration { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Price { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseLineNote { get; set; }

    public long? Quantity { get; set; }

    public long? SortIndex { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public IReadOnlyDictionary<string, object?>? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public UomEntry? Uom { get; set; }

    public long? Version { get; set; }

    public IReadOnlyDictionary<string, object?>? Warehouse { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrderLine"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderLineList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrderLine>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrder : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrder"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrder>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderPurchaseInvoice : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrderPurchaseInvoice"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderPurchaseInvoiceList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrderPurchaseInvoice>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderPurchasePayment : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_payments",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditNoteApplications { get; set; }

    public string? CreditNoteTotal { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaidTotal { get; set; }

    public string? PaymentDate { get; set; }

    public IReadOnlyList<object?>? PaymentMethodApplications { get; set; }

    public string? PaymentNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? PaymentReference { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoiceApplications { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrderPurchasePayment"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderPurchasePaymentList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_payments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrderPurchasePayment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrdersNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

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

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrdersNote"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrdersNoteList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrdersNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_orders/{purchase_order_id}",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public Account? Account { get; set; }

    public string? AccountId { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PriceTaxInclusive { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? SaleOrderId { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrdersView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public Account? Account { get; set; }

    public string? AccountId { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PriceTaxInclusive { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderInformation : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/information",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>No endpoint names this view directly.</summary>
public sealed class PurchaseOrderNotes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public IReadOnlyList<object?>? Notes { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes",
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}",
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

    public IReadOnlyDictionary<string, object?>? Note { get; set; }

    public string? Object { get; set; }

    public PurchaseOrderEntry? PurchaseOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrderNote"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderNoteList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrderNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderLineRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines/{purchase_order_line_uuid}",
    };

    protected override string? EnvelopeKey => "purchase_order_line";

    public string? CreatedOn { get; set; }

    public double? FlatDiscount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsPriceTaxInclusive { get; set; }

    public bool? IsTaxExempt { get; set; }

    public Item? Item { get; set; }

    public ItemAccountingCode? ItemAccountingCode { get; set; }

    public double? ItemDiscountAmount { get; set; }

    public string? ItemExpectedCompletionDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? ItemInvoiceNote { get; set; }

    public ItemPriceSnapshot? ItemPriceSnapshot { get; set; }

    public ItemPriceTax? ItemPriceTax { get; set; }

    public bool? ItemPriceTaxExempt { get; set; }

    public ItemPurchaseAccountingCode? ItemPurchaseAccountingCode { get; set; }

    public ItemPurchaseTaxConfiguration? ItemPurchaseTaxConfiguration { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Line { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Price { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseLineNote { get; set; }

    public long? Quantity { get; set; }

    public long? SortIndex { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public Tax? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public Uom? Uom { get; set; }

    public long? Version { get; set; }

    public Warehouse? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderNoteFile : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files",
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files/{purchase_order_file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="PurchaseOrderNoteFile"/> records, under <c>data</c>.</summary>
public sealed class PurchaseOrderNoteFileList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseOrderNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderChange : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders/{purchase_order_id}/change",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public Account? Account { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderCancel : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders/{purchase_order_id}/cancel",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderReactivate : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders/{purchase_order_id}/reactivate",
    };

    protected override string? EnvelopeKey => "purchase_order";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    public string? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    public string? Origin { get; set; }

    public string? PaidAmount { get; set; }

    public string? PurchaseOrderNote { get; set; }

    /// <summary>Untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderNotesCreated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders/{purchase_order_id}/notes",
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

    public PurchaseOrderEntry? PurchaseOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderPurchaseInvoices : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public PurchaseOrderEntry? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class Item : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>uom</c>.</summary>
public sealed class Uom : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>warehouse</c>.</summary>
public sealed class Warehouse : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>tax</c>.</summary>
public sealed class Tax : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
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

/// <summary>An object sent as <c>item_purchase_tax_configuration</c>.</summary>
public sealed class ItemPurchaseTaxConfiguration : Dto
{
    public bool? PurchasePriceIsTaxInclusive { get; set; }

    public TaxCode? TaxCode { get; set; }

    public bool? TaxExemptWhenPurchase { get; set; }
}

/// <summary>An object sent as <c>item_accounting_code</c>.</summary>
public sealed class ItemAccountingCode : Dto
{
    public string? CostOfGoodsSold { get; set; }
}

/// <summary>An object sent as <c>item_purchase_accounting_code</c>.</summary>
public sealed class ItemPurchaseAccountingCode : Dto
{
    public string? CostOfGoodsSold { get; set; }
}

/// <summary>An object sent as <c>purchase_order</c>.</summary>
public sealed class PurchaseOrderEntry : Dto
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

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class Account : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

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

/// <summary>An object sent as <c>custom_form</c>.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>kpis</c>.</summary>
public sealed class Kpis : Dto
{
    public string? CreditApplied { get; set; }

    public string? CreditIssued { get; set; }

    /// <summary>Untyped.</summary>
    public object? DeletedOn { get; set; }

    public string? EstimatedTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? IssueDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastAmendedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastCancelledOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastChangedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastDeletedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastPaymentDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastReactivatedOn { get; set; }

    public string? Object { get; set; }

    public string? Outstanding { get; set; }

    public string? Overdue { get; set; }

    public string? PaymentApplied { get; set; }

    public string? TotalExpense { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalOverdue { get; set; }

    public long? TotalPurchaseInvoice { get; set; }

    /// <summary>Untyped.</summary>
    public object? VoidedOn { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>.</summary>
public sealed class Line : Dto
{
    public string? AccountingCode { get; set; }

    public string? Id { get; set; }

    public Item? Item { get; set; }

    public string? Object { get; set; }

    public long? Quantity { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uom { get; set; }

    public long? Version { get; set; }

    public string? Warehouse { get; set; }
}

/// <summary>An object sent as <c>pricing_rule</c>.</summary>
public sealed class PricingRule : Dto
{
    public double? Price { get; set; }

    public string? PriceType { get; set; }

    public string? PricingVersion { get; set; }

    public string? Uom { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>.</summary>
public sealed class TaxCode : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Rate { get; set; }
}

/// <summary>An object sent as <c>uom</c>.</summary>
public sealed class UomEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseOrderKpis : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/kpis",
    };

    protected override string? EnvelopeKey => "purchase_order_kpis";
}
