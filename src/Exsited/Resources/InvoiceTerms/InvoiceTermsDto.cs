namespace Exsited.Resources.InvoiceTerms.InvoiceTermsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsInvoiceTerm : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/invoice_terms",
        "GET /api/{api_version}/settings/invoice_terms/{invoice_term_id}",
    };

    protected override string? EnvelopeKey => "invoice_term";

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public SettingsInvoiceTermDuration? Duration { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsInvoiceTerm"/> records, under <c>data</c>.</summary>
public sealed class SettingsInvoiceTermList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/invoice_terms",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsInvoiceTerm>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>duration</c>, merged over every record measured.</summary>
public sealed class SettingsInvoiceTermDuration : Dto
{
    public long? Count { get; set; }

    public string? Period { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsInvoiceTermWrite : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/invoice_terms",
        "PATCH /api/{api_version}/settings/invoice_terms/{invoice_term_id}",
    };

    protected override string? EnvelopeKey => "invoice_term";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public long? Duration { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Ordering { get; set; }

    public string? Period { get; set; }

    public string? Status { get; set; }
}
