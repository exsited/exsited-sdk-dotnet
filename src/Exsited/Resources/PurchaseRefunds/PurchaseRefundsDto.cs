namespace Exsited.Resources.PurchaseRefunds.PurchaseRefundsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseRefundsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_refunds",
    };

    public string? AlternateDate { get; set; }

    public string? Amount { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? CreditNoteId { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Date { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? Url { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseRefund : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_refunds/{purchase_refund_id}",
    };

    protected override string? EnvelopeKey => "purchase_refund";

    public Account? Account { get; set; }

    public string? AlternateDate { get; set; }

    public string? Amount { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CreditNote? CreditNote { get; set; }

    public string? CreditNoteId { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Date { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentProcessor { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("purchase_refund")]
    public object? PurchaseRefundValue { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>credit_note</c>, merged over every record measured.</summary>
public sealed class CreditNote : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
