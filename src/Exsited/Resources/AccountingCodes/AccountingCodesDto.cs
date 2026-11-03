namespace Exsited.Resources.AccountingCodes.AccountingCodesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsAccountingCode : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/accounting_codes",
        "GET /api/{api_version}/settings/accounting_codes/{accounting_code_id}",
    };

    protected override string? EnvelopeKey => "accounting_code";

    public string? AccountCodeType { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? DefaultMatchKey { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? GlAccountName { get; set; }

    public string? GlAccountNumber { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsAccountingCode"/> records, under <c>data</c>.</summary>
public sealed class SettingsAccountingCodeList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/accounting_codes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsAccountingCode>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsAccountingCodes : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/accounting_codes",
    };

    protected override string? EnvelopeKey => "accounting_code";

    public string? AccountCodeType { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? DefaultMatchKey { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? GlAccountName { get; set; }

    public string? GlAccountNumber { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsAccountingCodeUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/accounting_codes/{accounting_code_id}",
    };

    protected override string? EnvelopeKey => "accounting_code";

    public string? AccountCodeType { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? DefaultMatchKey { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? GlAccountName { get; set; }

    public string? GlAccountNumber { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}
