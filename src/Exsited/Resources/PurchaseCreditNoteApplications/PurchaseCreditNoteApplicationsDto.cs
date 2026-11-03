namespace Exsited.Resources.PurchaseCreditNoteApplications.PurchaseCreditNoteApplicationsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseCreditNoteApplication : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_note_applications",
    };

    public string? Amount { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? CreditNoteId { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? PaymentId { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchaseCreditNote { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchasePayment { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="PurchaseCreditNoteApplication"/> records, under <c>data</c>.</summary>
public sealed class PurchaseCreditNoteApplicationList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_note_applications",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseCreditNoteApplication>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseCreditNoteApplicationRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_note_applications/{purchase_credit_note_application_id}",
    };

    protected override string? EnvelopeKey => "purchase_credit_note_application";

    public string? Amount { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchaseCreditNote { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchasePayment { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
