namespace Exsited.Resources.ExternalDatabases;

/// <summary>Path templates for the v4 external databases endpoints.</summary>
public static class ExternalDatabasesUrls
{
    public const string ExternalDatabases = "/api/{api_version}/external_databases";

    public const string ExternalDatabase = "/api/{api_version}/external_databases/{db_name}";

    public const string ExternalDatabaseInsertRecords = "/api/{api_version}/external_databases/{db_name}/insert_records";

    public const string ExternalDatabaseSearch = "/api/{api_version}/external_databases/{db_name}/search";

    public const string ExternalDatabaseUpdateRecords = "/api/{api_version}/external_databases/{db_name}/update_records";

    public const string ExternalDatabaseTable = "/api/{api_version}/external_databases/{db_name}/tables/{table_name}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ExternalDatabaseKey = "external_database";
}
