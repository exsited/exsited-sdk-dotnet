namespace Exsited.Resources.Approvals.ApprovalsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class ApprovalsAccount : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/approvals/account",
    };

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Entity { get; set; }

    public string? Event { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="ApprovalsAccount"/> records, under <c>data</c>.</summary>
public sealed class ApprovalsAccountList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/approvals/account",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ApprovalsAccount>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class ApprovalsSaleorder : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/approvals/saleOrder",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
