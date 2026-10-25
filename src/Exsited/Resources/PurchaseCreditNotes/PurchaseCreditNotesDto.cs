namespace Exsited.Resources.PurchaseCreditNotes.PurchaseCreditNotesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseCreditNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_notes",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public string? IssueDate { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? PaymentId { get; set; }

    public IReadOnlyList<object?>? PurchaseCreditNoteRows { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchasePayment { get; set; }

    public string? RefundAmount { get; set; }

    public bool? Refundable { get; set; }

    public string? RemainingAmount { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="PurchaseCreditNote"/> records, under <c>data</c>.</summary>
public sealed class PurchaseCreditNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseCreditNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseCreditNoteRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}",
    };

    protected override string? EnvelopeKey => "purchase_credit_note";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? PurchaseCreditNoteRows { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchasePayment { get; set; }

    public string? RefundAmount { get; set; }

    public bool? Refundable { get; set; }

    public string? RemainingAmount { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseCreditNoteUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}",
    };

    protected override string? EnvelopeKey => "purchase_credit_note";

    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public Status? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>status</c>, merged over every record measured.</summary>
public sealed class Status : Dto
{
    public string? Key { get; set; }

    public string? Value { get; set; }
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

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseCreditNoteCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_credit_notes",
    };

    protected override string? EnvelopeKey => "purchase_credit_note";

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public string? IssueDate { get; set; }

    public string? Object { get; set; }

    public string? RemainingAmount { get; set; }

    public PurchaseCreditNoteCreatedStatus? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>status</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNoteCreatedStatus : Dto
{
    public string? Key { get; set; }

    public string? Value { get; set; }
}
