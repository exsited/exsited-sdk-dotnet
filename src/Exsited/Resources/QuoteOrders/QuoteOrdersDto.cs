namespace Exsited.Resources.QuoteOrders.QuoteOrdersDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class QuoteOrderInvoiceList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/quote_orders/{quote_order_id}/invoices",
    };

    public IReadOnlyList<QuoteOrderInvoice>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoice : Dto
{
    public QuoteOrderInvoiceAccount? Account { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public QuoteOrderInvoiceCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public QuoteOrderInvoiceCurrency? Currency { get; set; }

    public QuoteOrderInvoiceCustomForm? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public QuoteOrderInvoiceOrder? Order { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

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

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoiceAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoiceCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoiceCurrency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoiceCustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>order</c>, merged over every record measured.</summary>
public sealed class QuoteOrderInvoiceOrder : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
