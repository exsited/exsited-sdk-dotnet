namespace Exsited.Resources.AccountGroups.AccountGroupsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsAccountGroup : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/account_groups",
        "GET /api/{api_version}/settings/account_groups/{account_group_id}",
        "POST /api/{api_version}/settings/account_groups",
    };

    protected override string? EnvelopeKey => "account_group";

    /// <summary>Untyped.</summary>
    public object? AccountingCode { get; set; }

    /// <summary>Entries are untyped.</summary>
    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<string>? InvoiceAccountMedia { get; set; }

    /// <summary>Untyped.</summary>
    public object? ManagedBy { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? PricingLevel { get; set; }

    public SettingsAccountGroupStateRule? StateRule { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsAccountGroup"/> records, under <c>data</c>.</summary>
public sealed class SettingsAccountGroupList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/account_groups",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsAccountGroup>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>state_rule</c>.</summary>
public sealed class SettingsAccountGroupStateRule : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}
