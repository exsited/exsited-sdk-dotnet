namespace Exsited.Resources.Alerts.AlertsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class AlertsView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alerts",
        "GET /api/{api_version}/alerts/account/{account_id}",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class AlertsEmployee : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alerts/employee/{employee_id}",
    };
}

/// <summary>One page of <see cref="AlertsEmployee"/> records, under <c>data</c>.</summary>
public sealed class AlertsEmployeeList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alerts/employee/{employee_id}",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AlertsEmployee>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class AlertsLabour : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alerts/labour/{labour_id}",
    };
}

/// <summary>One page of <see cref="AlertsLabour"/> records, under <c>data</c>.</summary>
public sealed class AlertsLabourList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/alerts/labour/{labour_id}",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AlertsLabour>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
