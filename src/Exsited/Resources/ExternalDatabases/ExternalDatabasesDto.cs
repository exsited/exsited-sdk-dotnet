namespace Exsited.Resources.ExternalDatabases.ExternalDatabasesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabasesView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/external_databases",
        "GET /api/{api_version}/external_databases/{db_name}",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabaseTable : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/external_databases/{db_name}/tables/{table_name}",
    };
}

/// <summary>One page of <see cref="ExternalDatabaseTable"/> records, under <c>data</c>.</summary>
public sealed class ExternalDatabaseTableList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/external_databases/{db_name}/tables/{table_name}",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ExternalDatabaseTable>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabasesCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/external_databases",
    };

    protected override string? EnvelopeKey => "external_database";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Message { get; set; }

    public string? Name { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabaseInsertRecords : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/external_databases/{db_name}/insert_records",
    };

    protected override string? EnvelopeKey => "external_database";

    public IReadOnlyList<object?>? InsertedData { get; set; }

    public string? Message { get; set; }

    public bool? Success { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabaseSearch : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/external_databases/{db_name}/search",
    };

    protected override string? EnvelopeKey => "external_database";

    public long? Count { get; set; }

    public long? Limit { get; set; }

    public IReadOnlyDictionary<string, object?>? List { get; set; }

    public long? Offset { get; set; }

    public bool? Success { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ExternalDatabaseUpdateRecords : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/external_databases/{db_name}/update_records",
    };

    protected override string? EnvelopeKey => "external_database";

    public string? Message { get; set; }
}
