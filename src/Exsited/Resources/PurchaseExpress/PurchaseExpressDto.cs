namespace Exsited.Resources.PurchaseExpress.PurchaseExpressDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseExpressView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_express",
    };

    protected override string? EnvelopeKey => "purchase_express";

    public PurchaseExpressAccount? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? BillTotal { get; set; }

    public string? Code { get; set; }

    public PurchaseExpressCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public PurchaseExpressCurrency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public PurchaseExpressCustomForm? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? DueTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ExpectedCompletionDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? IsPriceTaxInclusive { get; set; }

    public string? IssueDate { get; set; }

    public PurchaseExpressKpis? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? OperationalStatus { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public string? PaidAmount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PurchaseOrderNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SupplierInvoiceId { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class PurchaseExpressAccount : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class PurchaseExpressCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class PurchaseExpressCurrency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class PurchaseExpressCustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>kpis</c>, merged over every record measured.</summary>
public sealed class PurchaseExpressKpis : Dto
{
    public string? EstimatedTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastCancelledOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastChangedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastDeletedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastReactivatedOn { get; set; }

    public string? Object { get; set; }

    public string? TotalExpense { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalOverdue { get; set; }

    public long? TotalPurchaseInvoice { get; set; }
}
