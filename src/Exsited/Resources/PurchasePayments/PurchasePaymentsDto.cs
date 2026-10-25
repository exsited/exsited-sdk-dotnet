namespace Exsited.Resources.PurchasePayments.PurchasePaymentsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePayment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public CreatedByEntry? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditNoteApplications { get; set; }

    public string? CreditNoteTotal { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaidTotal { get; set; }

    public string? PaymentDate { get; set; }

    public IReadOnlyList<object?>? PaymentMethodApplications { get; set; }

    public string? PaymentNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentReference { get; set; }

    public IReadOnlyList<object?>? PurchaseCreditApplied { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoiceApplications { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoices { get; set; }

    public string? PurchaseOrderId { get; set; }

    public IReadOnlyList<object?>? PurchasePaymentApplied { get; set; }

    public string? PurchasePaymentDate { get; set; }

    public string? PurchasePaymentNote { get; set; }

    public string? Status { get; set; }

    public string? TotalApplied { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="PurchasePayment"/> records, under <c>data</c>.</summary>
public sealed class PurchasePaymentList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchasePayment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments",
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_payments",
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}",
    };

    protected override string? EnvelopeKey => "purchase_payment";

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

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentReference { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoiceApplications { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

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

    public IReadOnlyDictionary<string, object?>? PurchasePayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="PurchasePaymentNote"/> records, under <c>data</c>.</summary>
public sealed class PurchasePaymentNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchasePaymentNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_payments/{purchase_payment_id}",
    };

    protected override string? EnvelopeKey => "purchase_payment";

    public Account? Account { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditNoteApplications { get; set; }

    public string? CreditNoteTotal { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaidTotal { get; set; }

    public string? PaymentDate { get; set; }

    public IReadOnlyList<PaymentMethodApplication>? PaymentMethodApplications { get; set; }

    public string? PaymentNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentReference { get; set; }

    public IReadOnlyList<object?>? PurchaseCreditApplied { get; set; }

    public IReadOnlyList<PurchaseInvoiceApplication>? PurchaseInvoiceApplications { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoices { get; set; }

    public string? PurchaseOrderId { get; set; }

    public IReadOnlyList<object?>? PurchasePaymentApplied { get; set; }

    public string? PurchasePaymentDate { get; set; }

    public string? PurchasePaymentNote { get; set; }

    public string? Status { get; set; }

    public string? TotalApplied { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments",
        "POST /api/{api_version}/purchase_payments",
    };

    protected override string? EnvelopeKey => "purchase_payment";

    public Account? Account { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<CreditNoteApplication>? CreditNoteApplications { get; set; }

    public string? CreditNoteTotal { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaidTotal { get; set; }

    public string? PaymentDate { get; set; }

    public IReadOnlyList<PaymentMethodApplication>? PaymentMethodApplications { get; set; }

    public string? PaymentNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentReference { get; set; }

    public IReadOnlyList<object?>? PurchaseCreditApplied { get; set; }

    public IReadOnlyList<PurchaseInvoiceApplication>? PurchaseInvoiceApplications { get; set; }

    public IReadOnlyList<object?>? PurchaseInvoices { get; set; }

    public string? PurchaseOrderId { get; set; }

    public IReadOnlyList<object?>? PurchasePaymentApplied { get; set; }

    public string? PurchasePaymentDate { get; set; }

    public string? PurchasePaymentNote { get; set; }

    public string? Status { get; set; }

    public string? TotalApplied { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentNotes : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_payments/{purchase_payment_id}/notes",
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

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Link { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public PurchasePaymentEntry? PurchasePayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentNoteRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}",
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

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Note { get; set; }

    public string? Object { get; set; }

    public PurchasePaymentEntry? PurchasePayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentNoteFile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files",
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files/{file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="PurchasePaymentNoteFile"/> records, under <c>data</c>.</summary>
public sealed class PurchasePaymentNoteFileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchasePaymentNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>purchase_payment</c>, merged over every record measured.</summary>
public sealed class PurchasePaymentEntry : Dto
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
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class Currency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_method_applications</c>, merged over every record measured.</summary>
public sealed class PaymentMethodApplication : Dto
{
    public string? Amount { get; set; }

    public PaymentMethod? PaymentMethod { get; set; }

    public PaymentProcessor? PaymentProcessor { get; set; }

    public string? Reference { get; set; }
}

/// <summary>One entry of a list sent as <c>credit_note_applications</c>, merged over every record measured.</summary>
public sealed class CreditNoteApplication : Dto
{
    public string? Amount { get; set; }

    public PurchaseCreditNote? PurchaseCreditNote { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_invoice_applications</c>, merged over every record measured.</summary>
public sealed class PurchaseInvoiceApplication : Dto
{
    public string? Applied { get; set; }

    public string? DueDate { get; set; }

    public string? IssueDate { get; set; }

    public string? Outstanding { get; set; }

    public PurchaseInvoice? PurchaseInvoice { get; set; }

    public string? Total { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>, merged over every record measured.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>payment_method</c>, merged over every record measured.</summary>
public sealed class PaymentMethod : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>payment_processor</c>, merged over every record measured.</summary>
public sealed class PaymentProcessor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_credit_note</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNote : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_invoice</c>, merged over every record measured.</summary>
public sealed class PurchaseInvoice : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
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

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchasePaymentNoteUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<PurchasePaymentNoteUpdatedAttachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public PurchasePaymentNoteUpdatedUser? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public PurchasePaymentNoteUpdatedUser? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public PurchasePaymentNoteUpdatedPurchasePayment? PurchasePayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class PurchasePaymentNoteUpdatedAttachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>purchase_payment</c>, merged over every record measured.</summary>
public sealed class PurchasePaymentNoteUpdatedPurchasePayment : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class PurchasePaymentNoteUpdatedUser : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One page of <see cref="PurchaseCreditNoteEntry"/> records, under <c>data</c>.</summary>
public sealed class PurchaseCreditNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseCreditNoteEntry>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PurchaseCreditNoteEntry : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_credit_notes",
    };

    public PurchaseCreditNoteAccount? Account { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    public PurchaseCreditNoteCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public PurchaseCreditNoteCurrency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InitialAmount { get; set; }

    public string? IssueDate { get; set; }

    public PurchaseCreditNoteLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public string? PaymentId { get; set; }

    public IReadOnlyList<PurchaseCreditNotePurchaseCreditNoteRow>? PurchaseCreditNoteRows { get; set; }

    public PurchaseCreditNotePurchasePayment? PurchasePayment { get; set; }

    public string? RefundAmount { get; set; }

    public bool? Refundable { get; set; }

    public string? RemainingAmount { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNoteAccount : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNoteCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNoteCurrency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNoteLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_credit_note_rows</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNotePurchaseCreditNoteRow : Dto
{
    public string? CreditNoteFromBlankMethod { get; set; }

    public string? CreditNoteFromCreditNote { get; set; }

    public string? CreditNoteFromPaymentMethod { get; set; }

    public string? CreditNoteTotal { get; set; }

    public PurchaseCreditNotePurchaseCreditNoteRowPaymentMethod? PaymentMethod { get; set; }

    public PurchaseCreditNotePurchaseCreditNoteRowPaymentProcessor? PaymentProcessor { get; set; }

    public string? RefundFromBlankMethod { get; set; }

    public string? RefundFromCreditNote { get; set; }

    public string? RefundFromPaymentMethod { get; set; }

    public string? RefundTotal { get; set; }
}

/// <summary>An object sent as <c>payment_method</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNotePurchaseCreditNoteRowPaymentMethod : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>payment_processor</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNotePurchaseCreditNoteRowPaymentProcessor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_payment</c>, merged over every record measured.</summary>
public sealed class PurchaseCreditNotePurchasePayment : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}
