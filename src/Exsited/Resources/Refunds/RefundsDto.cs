namespace Exsited.Resources.Refunds.RefundsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Refund : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/refunds",
        "GET /api/{api_version}/refunds/{refund_id}",
    };

    protected override string? EnvelopeKey => "refund";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Amount { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CreditNote { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? GatewayResponse { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Note { get; set; }

    public string? Object { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? ReconcileStatus { get; set; }

    public string? Reference { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Refund"/> records, under <c>data</c>.</summary>
public sealed class RefundList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/refunds",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Refund>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class RefundUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/credit_notes/{credit_note_id}/refunds",
        "PATCH /api/{api_version}/refunds/{refund_id}",
    };

    protected override string? EnvelopeKey => "refund";

    public Account? Account { get; set; }

    public string? Amount { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CreditNote? CreditNote { get; set; }

    public string? CreditNoteId { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? GatewayResponse { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? ReconcileStatus { get; set; }

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

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class RefundNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/refunds/{refund_id}/notes",
        "GET /api/{api_version}/refunds/{refund_id}/notes",
        "GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<RefundNoteAttachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public RefundNoteCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public RefundNoteDetail? Refund { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<RefundNoteWatcher>? Watchers { get; set; }
}

/// <summary>One page of <see cref="RefundNote"/> records, under <c>data</c>.</summary>
public sealed class RefundNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/refunds/{refund_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<RefundNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class RefundNoteFile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}/files/{file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>refund</c>, merged over every record measured.</summary>
public sealed class RefundNoteDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class RefundNoteAttachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>, merged over every record measured.</summary>
public sealed class RefundNoteWatcher : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class RefundNoteCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>A listing of one note's attachments - the same envelope, different records.</summary>
public sealed class NoteFileList : Dto
{
    public string? Object { get; set; }

    public string? Url { get; set; }

    public IReadOnlyList<NoteAttachment>? Data { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class NoteAttachment : Dto
{
    public string? Uuid { get; set; }

    public string? Filename { get; set; }

    public string? ContentType { get; set; }

    public long? Size { get; set; }

    public string? Href { get; set; }
}
