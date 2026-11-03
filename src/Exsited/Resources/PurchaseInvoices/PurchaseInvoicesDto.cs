namespace Exsited.Resources.PurchaseInvoices.PurchaseInvoicesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoice : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices",
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/information",
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

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

/// <summary>One page of <see cref="PurchaseInvoice"/> records, under <c>data</c>.</summary>
public sealed class PurchaseInvoiceList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices",
        "GET /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseInvoice>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoicePurchasePayment : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments",
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

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

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

/// <summary>One page of <see cref="PurchaseInvoicePurchasePayment"/> records, under <c>data</c>.</summary>
public sealed class PurchaseInvoicePurchasePaymentList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseInvoicePurchasePayment>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? PurchaseInvoice { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="PurchaseInvoiceNote"/> records, under <c>data</c>.</summary>
public sealed class PurchaseInvoiceNoteList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseInvoiceNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoicesNote : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/notes",
    };

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="PurchaseInvoicesNote"/> records, under <c>data</c>.</summary>
public sealed class PurchaseInvoicesNoteList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseInvoicesNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomForm { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

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

/// <summary>A typed view of the response body.</summary>
public sealed class AccountPurchaseInvoices : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/purchase_invoices",
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_credit_note_applications",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceInformation : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_invoices/{purchase_invoice_id}/information",
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

    public string? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceCancel : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/cancel",
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

    public string? EventUuid { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public Kpis? Kpis { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceNotes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? ExternalWatchers { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? InternalWatchers { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public PurchaseInvoiceEntry? PurchaseInvoice { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceLines : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceLine : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines/{purchase_invoice_line_uuid}",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

    public LineEntry? Line { get; set; }

    public string? Object { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceNoteRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}",
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

    public PurchaseInvoiceEntry? PurchaseInvoice { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceNoteFile : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files",
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files/{file_id}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="PurchaseInvoiceNoteFile"/> records, under <c>data</c>.</summary>
public sealed class PurchaseInvoiceNoteFileList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<PurchaseInvoiceNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoicesView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices",
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

    /// <summary>Untyped.</summary>
    public object? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceAmend : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/amend",
    };

    protected override string? EnvelopeKey => "purchase_invoice";

    public Account? Account { get; set; }

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

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceReactivate : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/reactivate",
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

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    /// <summary>Untyped.</summary>
    public object? PurchaseOrder { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PurchaseInvoiceNoteUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public PurchaseInvoiceEntry? PurchaseInvoice { get; set; }

    /// <summary>Untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>An object sent as <c>purchase_invoice</c>.</summary>
public sealed class PurchaseInvoiceEntry : Dto
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

/// <summary>An object sent as <c>currency</c>.</summary>
public sealed class Currency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
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

/// <summary>An object sent as <c>kpis</c>.</summary>
public sealed class Kpis : Dto
{
    public string? CreditApplied { get; set; }

    public string? CreditIssued { get; set; }

    /// <summary>Untyped.</summary>
    public object? DeletedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastAmendedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastCancelledOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastPaymentDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastReactivatedOn { get; set; }

    public string? Object { get; set; }

    public string? Outstanding { get; set; }

    public string? Overdue { get; set; }

    public string? PaymentApplied { get; set; }

    /// <summary>Untyped.</summary>
    public object? VoidedOn { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_order</c>.</summary>
public sealed class PurchaseOrder : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class Item : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>line</c>.</summary>
public sealed class LineEntry : Dto
{
    public string? AccountingCode { get; set; }

    public string? Id { get; set; }

    public ItemEntry? Item { get; set; }

    public string? Object { get; set; }

    public long? Quantity { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? Total { get; set; }

    public string? Uom { get; set; }

    public long? Version { get; set; }

    public string? Warehouse { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class ItemEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
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

    public PurchaseCreditNoteApplicationReadCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public PurchaseCreditNoteApplicationReadDetail? PurchaseCreditNote { get; set; }

    public PurchaseCreditNoteApplicationReadPurchasePayment? PurchasePayment { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class PurchaseCreditNoteApplicationReadCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_credit_note</c>.</summary>
public sealed class PurchaseCreditNoteApplicationReadDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_payment</c>.</summary>
public sealed class PurchaseCreditNoteApplicationReadPurchasePayment : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
