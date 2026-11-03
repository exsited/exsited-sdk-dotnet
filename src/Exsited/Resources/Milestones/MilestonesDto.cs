namespace Exsited.Resources.Milestones.MilestonesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class MilestonesView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/milestones",
        "GET /api/{api_version}/milestones/account/{account_id}",
        "GET /api/{api_version}/milestones/employee/{employee_code}",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class MilestonesLabour : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/milestones/labour/{labour_id}",
    };
}

/// <summary>One page of <see cref="MilestonesLabour"/> records, under <c>data</c>.</summary>
public sealed class MilestonesLabourList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/milestones/labour/{labour_id}",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<MilestonesLabour>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
