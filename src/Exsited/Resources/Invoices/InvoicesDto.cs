namespace Exsited.Resources.Invoices.InvoicesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Invoice : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices",
        "GET /api/{api_version}/orders/{order_id}/invoices",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastPayment { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Order { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Invoice"/> records, under <c>data</c>.</summary>
public sealed class InvoiceList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices",
        "GET /api/{api_version}/orders/{order_id}/invoices",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Invoice>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceItemFulfillment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments",
        "GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments/{fulfillment_id}",
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

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="InvoiceItemFulfillment"/> records, under <c>data</c>.</summary>
public sealed class InvoiceItemFulfillmentList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/item_fulfillments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<InvoiceItemFulfillment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? Invoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="InvoiceNote"/> records, under <c>data</c>.</summary>
public sealed class InvoiceNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<InvoiceNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}",
    };

    protected override string? EnvelopeKey => "invoice";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AccountId { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public CreatedByEntry? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    public IReadOnlyDictionary<string, object?>? LastPayment { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Order { get; set; }

    public string? OrderId { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoicesView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/invoices",
        "POST /api/{api_version}/invoices/{invoice_id}/amend",
        "POST /api/{api_version}/invoices/{invoice_id}/cancel",
        "POST /api/{api_version}/orders/{order_id}/invoices",
    };

    protected override string? EnvelopeKey => "invoice";

    public Account? Account { get; set; }

    public string? AccountId { get; set; }

    public string? AccountName { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    public Order? Order { get; set; }

    public string? OrderId { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? ShippingCost { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceInformation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/invoices/{invoice_id}/information",
    };

    protected override string? EnvelopeKey => "invoice";

    public Account? Account { get; set; }

    public string? AccountId { get; set; }

    public string? AccountName { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? OrderId { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? ShippingCost { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceReactivate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/invoices/{invoice_id}/reactivate",
    };

    protected override string? EnvelopeKey => "invoice";

    public Account? Account { get; set; }

    public string? AccountId { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? OrderId { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceInformationRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/information",
    };

    protected override string? EnvelopeKey => "invoice";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastPayment { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Order { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceDeleted : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "DELETE /api/{api_version}/invoices/{invoice_id}",
    };

    protected override string? EnvelopeKey => "invoice";

    public string? AccountId { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? OrderId { get; set; }

    public string? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceReturnMerchandiseAuthorisation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_id}",
    };

    protected override string? EnvelopeKey => "return_merchandise_authorisation";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public long? ItemCount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? ReceiveRmas { get; set; }

    public string? ReturnStatus { get; set; }

    public string? RmaDate { get; set; }

    public IReadOnlyDictionary<string, object?>? SaleInvoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountInvoices : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/invoices",
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceNoteRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public InvoiceEntry? Invoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Note { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoicePdf : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/pdf",
    };

    protected override string? EnvelopeKey => "invoice";

    public Pdf? Pdf { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceNoteFile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files",
        "GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files/{invoice_file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="InvoiceNoteFile"/> records, under <c>data</c>.</summary>
public sealed class InvoiceNoteFileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/notes/{invoice_note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<InvoiceNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceNotes : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/invoices/{invoice_id}/notes",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public InvoiceEntry? Invoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>An object sent as <c>pdf</c>, merged over every record measured.</summary>
public sealed class Pdf : Dto
{
    public string? DownloadUrl { get; set; }

    public long? FileSize { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreviewUrl { get; set; }
}

/// <summary>An object sent as <c>invoice</c>, merged over every record measured.</summary>
public sealed class InvoiceEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class Attachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>, merged over every record measured.</summary>
public sealed class Watcher : Dto
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>order</c>, merged over every record measured.</summary>
public sealed class Order : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>, merged over every record measured.</summary>
public sealed class Line : Dto
{
    public AccountingCode? AccountingCode { get; set; }

    public string? Id { get; set; }

    public Item? Item { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<object?>? ItemCustomAttributes { get; set; }

    public string? ItemId { get; set; }

    public string? ItemName { get; set; }

    public long? ItemOrderQuantity { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ItemUom { get; set; }

    public string? ItemUuid { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ItemWarehouse { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingSnapshotPrice { get; set; }

    public string? PricingSnapshotUuid { get; set; }

    public string? Subtotal { get; set; }

    public Tax? Tax { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class Item : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>tax</c>, merged over every record measured.</summary>
public sealed class Tax : Dto
{
    public string? Amount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Rate { get; set; }
}

/// <summary>An object sent as <c>accounting_code</c>, merged over every record measured.</summary>
public sealed class AccountingCode : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRevenue { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>tax</c>, merged over every record measured.</summary>
public sealed class LineTax : Dto
{
    public string? Object { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    /// <summary>A number, unlike the other money fields, which arrive as strings.</summary>
    public double? Rate { get; set; }

    public string? Amount { get; set; }

    public string? Href { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>, merged over every record measured.</summary>
public sealed class InvoiceLine : Dto
{
    public string? Object { get; set; }

    public string? Id { get; set; }

    public long? Version { get; set; }

    /// <summary>A <c>{object, id, name, href}</c> reference to the item.</summary>
    public InvoiceLineItem? Item { get; set; }

    public string? ItemId { get; set; }

    public string? ItemUuid { get; set; }

    public string? ItemName { get; set; }

    public string? ItemUom { get; set; }

    public string? ItemWarehouse { get; set; }

    /// <summary>Not sent for an item that is not serialised, so it reads <c>null</c> there.</summary>
    public string? ItemSerialOrBatchNumber { get; set; }

    public long? ItemOrderQuantity { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<object?>? ItemCustomAttributes { get; set; }

    public double? PricingSnapshotPrice { get; set; }

    public string? PricingSnapshotUuid { get; set; }

    /// <summary>Set on a recurring line only.</summary>
    public string? ChargingStartDate { get; set; }

    public string? ChargingEndDate { get; set; }

    public string? AlternateChargingStartDate { get; set; }

    public string? AlternateChargingEndDate { get; set; }

    public string? Subtotal { get; set; }

    public string? Total { get; set; }

    public LineTax? Tax { get; set; }

    public AccountingCode? AccountingCode { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class InvoiceLineItem : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>What <c>GetInvoiceKpisAsync</c> answers, under <c>invoice_kpis</c>: the block an invoice carries as <c>kpis</c>, with an <c>object</c> beside it.</summary>
public sealed class InvoiceKpisRead : Dto
{
    protected override string? EnvelopeKey => "invoice_kpis";

    public string? Object { get; set; }
}

/// <summary>What <c>GetInvoiceLinesAsync</c> answers, under <c>invoice</c>: its <c>object</c> and <c>lines</c>, and nothing else of the invoice.</summary>
public sealed class InvoiceLines : Dto
{
    protected override string? EnvelopeKey => "invoice";

    public string? Object { get; set; }

    public IReadOnlyList<InvoiceLine>? Lines { get; set; }
}

/// <summary>What <c>GetInvoiceLineAsync</c> answers, under <c>invoice</c>: its <c>object</c> and one <c>line</c>.</summary>
public sealed class InvoiceLineRead : Dto
{
    protected override string? EnvelopeKey => "invoice";

    public string? Object { get; set; }

    public InvoiceLine? Line { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteApplicationRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_note_applications/{credit_note_application_id}",
    };

    protected override string? EnvelopeKey => "credit_note_application";

    public double? Amount { get; set; }

    public CreditNoteApplicationReadCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CreditNoteApplicationReadDetail? CreditNote { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public CreditNoteApplicationReadPayment? Payment { get; set; }

    [WireName("primaryId")]
    public long? PrimaryId { get; set; }

    public CreditNoteApplicationReadRefund? Refund { get; set; }

    public double? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreditNoteApplicationReadCreatedBy : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>credit_note</c>, merged over every record measured.</summary>
public sealed class CreditNoteApplicationReadDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>payment</c>, merged over every record measured.</summary>
public sealed class CreditNoteApplicationReadPayment : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>refund</c>, merged over every record measured.</summary>
public sealed class CreditNoteApplicationReadRefund : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
