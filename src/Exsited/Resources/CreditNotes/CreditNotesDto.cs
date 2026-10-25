namespace Exsited.Resources.CreditNotes.CreditNotesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AccountId { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public string? InvoiceId { get; set; }

    public IReadOnlyList<object?>? Invoices { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Payment { get; set; }

    public string? PaymentId { get; set; }

    public string? RefundAmount { get; set; }

    public bool? Refundable { get; set; }

    public string? RemainingAmount { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="CreditNote"/> records, under <c>data</c>.</summary>
public sealed class CreditNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<CreditNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes/{credit_note_id}",
    };

    protected override string? EnvelopeKey => "credit_note";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public IReadOnlyList<object?>? Invoices { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Payment { get; set; }

    public string? RefundAmount { get; set; }

    public bool? Refundable { get; set; }

    public string? RemainingAmount { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/credit_notes/{credit_note_id}",
    };

    protected override string? EnvelopeKey => "credit_note";

    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? Object { get; set; }

    public bool? Refundable { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteItems : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes/{credit_note_id}/items",
    };

    protected override string? EnvelopeKey => "credit_note";

    public string? Href { get; set; }

    public IReadOnlyList<CreditNoteItem>? Items { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>items</c>, merged over every record measured.</summary>
public sealed class CreditNoteItem : Dto
{
    public string? CreditNoteFromBlankMethod { get; set; }

    public string? CreditNoteFromCreditNote { get; set; }

    public string? CreditNoteFromGiftCertificate { get; set; }

    public string? CreditNoteFromInvoiceCredit { get; set; }

    public string? CreditNoteFromPaymentMethod { get; set; }

    public string? CreditNoteTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Invoice { get; set; }

    public string? Object { get; set; }

    public string? RefundFromBlankMethod { get; set; }

    public string? RefundFromCreditNote { get; set; }

    public string? RefundFromGiftCertificate { get; set; }

    public string? RefundFromInvoiceCredit { get; set; }

    public string? RefundFromPaymentMethod { get; set; }

    public string? RefundTotal { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteApplicationsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes/{credit_note_id}/credit_note_applications",
    };

    protected override string? EnvelopeKey => "credit_note";

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? Applications { get; set; }

    public string? Href { get; set; }

    public string? Object { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CreditNoteNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes/{credit_note_id}/notes",
        "GET /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}",
    };

    protected override string? EnvelopeKey => "note";

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreditNoteNoteCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CreditNoteNoteDetail? CreditNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="CreditNoteNote"/> records, under <c>data</c>.</summary>
public sealed class CreditNoteNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/credit_notes/{credit_note_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<CreditNoteNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>credit_note</c>, merged over every record measured.</summary>
public sealed class CreditNoteNoteDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreditNoteNoteCreatedBy : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
