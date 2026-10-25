namespace Exsited.Resources.GiftCertificates.GiftCertificatesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates",
        "GET /api/{api_version}/gift_certificates/{gc_id}",
    };

    protected override string? EnvelopeKey => "gift_certificate";

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public IReadOnlyList<object?>? Allocations { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? ExpiryDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LinkedItem { get; set; }

    public string? Object { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<object?>? Transactions { get; set; }

    public string? UsedAmount { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<GiftCertificateActivityLog>? ActivityLogs { get; set; }
}

/// <summary>One page of <see cref="GiftCertificate"/> records, under <c>data</c>.</summary>
public sealed class GiftCertificateList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<GiftCertificate>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificateTransaction : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates/{gc_id}/transactions",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public string? Amount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Reference { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="GiftCertificateTransaction"/> records, under <c>data</c>.</summary>
public sealed class GiftCertificateTransactionList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates/{gc_id}/transactions",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<GiftCertificateTransaction>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificateAllocations : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates/{gc_id}/allocations",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificatesView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/gift_certificates",
    };

    protected override string? EnvelopeKey => "gift_certificate";

    public AccountingCode? AccountingCode { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Allocations { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? ExpiryDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LinkedItem { get; set; }

    public string? Object { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<Transaction>? Transactions { get; set; }

    public string? UsedAmount { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificateUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/gift_certificates/{gc_id}",
    };

    protected override string? EnvelopeKey => "gift_certificate";

    public AccountingCode? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Allocations { get; set; }

    public string? Amount { get; set; }

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? ExpiryDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LinkedItem { get; set; }

    public string? Object { get; set; }

    public string? RemainingBalance { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<Transaction>? Transactions { get; set; }

    public string? UsedAmount { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class Currency : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>accounting_code</c>, merged over every record measured.</summary>
public sealed class AccountingCode : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>transactions</c>, merged over every record measured.</summary>
public sealed class Transaction : Dto
{
    public AccountingCode? AccountingCode { get; set; }

    public string? Amount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? Date { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Reference { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>, merged over every record measured.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>, merged over every record measured.</summary>
public sealed class GiftCertificateActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificateAllocationRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates/{gc_id}/allocations/{allocation_id}",
    };

    protected override string? EnvelopeKey => "gift_certificate_allocation";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class GiftCertificateTransactionRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/gift_certificates/{gc_id}/transactions/{transaction_id}",
    };

    protected override string? EnvelopeKey => "gift_certificate_transaction";
}
