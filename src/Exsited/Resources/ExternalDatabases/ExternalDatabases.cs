using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ExternalDatabases.ExternalDatabasesDto;

namespace Exsited.Resources.ExternalDatabases;

/// <summary>The v4 external databases endpoints, as a typed resource bound to one client.</summary>
public sealed class ExternalDatabases : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ExternalDatabases</c>.</summary>
    public ExternalDatabases(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/external_databases</c>.</summary>
    public Task<ApiResponse> GetExternalDatabasesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ExternalDatabasesUrls.ExternalDatabases,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabasesView),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/external_databases</c>.</summary>
    public Task<ApiResponse> CreateExternalDatabaseAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ExternalDatabasesUrls.ExternalDatabases,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabasesCreated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/external_databases/{db_name}</c>.</summary>
    public Task<ApiResponse> GetExternalDatabaseAsync(
        string dbName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ExternalDatabasesUrls.ExternalDatabase,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["db_name"] = dbName },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabasesView),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/external_databases/{db_name}/insert_records</c>.</summary>
    public Task<ApiResponse> CreateExternalDatabaseInsertRecordAsync(
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ExternalDatabasesUrls.ExternalDatabaseInsertRecords,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["db_name"] = dbName },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabaseInsertRecords),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/external_databases/{db_name}/search</c>.</summary>
    public Task<ApiResponse> CreateExternalDatabaseSearchAsync(
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ExternalDatabasesUrls.ExternalDatabaseSearch,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["db_name"] = dbName },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabaseSearch),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/external_databases/{db_name}/update_records</c>.</summary>
    public Task<ApiResponse> UpdateExternalDatabaseUpdateRecordsAsync(
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ExternalDatabasesUrls.ExternalDatabaseUpdateRecords,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["db_name"] = dbName },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabaseUpdateRecords),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/external_databases/{db_name}/tables/{table_name}</c>.</summary>
    public Task<ApiResponse> GetExternalDatabaseTableAsync(
        string dbName, string tableName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ExternalDatabasesUrls.ExternalDatabaseTable,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["db_name"] = dbName, ["table_name"] = tableName },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExternalDatabaseTableList),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ExternalDatabases.GetExternalDatabasesAsync</c>.</summary>
    public static Task<ApiResponse> GetExternalDatabasesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.GetExternalDatabasesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.CreateExternalDatabaseAsync</c>.</summary>
    public static Task<ApiResponse> CreateExternalDatabaseAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.CreateExternalDatabaseAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.GetExternalDatabaseAsync</c>.</summary>
    public static Task<ApiResponse> GetExternalDatabaseAsync(
        ExsitedClient client,
        string dbName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.GetExternalDatabaseAsync(
            dbName, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.CreateExternalDatabaseInsertRecordAsync</c>.</summary>
    public static Task<ApiResponse> CreateExternalDatabaseInsertRecordAsync(
        ExsitedClient client,
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.CreateExternalDatabaseInsertRecordAsync(
            dbName, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.CreateExternalDatabaseSearchAsync</c>.</summary>
    public static Task<ApiResponse> CreateExternalDatabaseSearchAsync(
        ExsitedClient client,
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.CreateExternalDatabaseSearchAsync(
            dbName, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.UpdateExternalDatabaseUpdateRecordsAsync</c>.</summary>
    public static Task<ApiResponse> UpdateExternalDatabaseUpdateRecordsAsync(
        ExsitedClient client,
        string dbName, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.UpdateExternalDatabaseUpdateRecordsAsync(
            dbName, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ExternalDatabases.GetExternalDatabaseTableAsync</c>.</summary>
    public static Task<ApiResponse> GetExternalDatabaseTableAsync(
        ExsitedClient client,
        string dbName, string tableName, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ExternalDatabases.GetExternalDatabaseTableAsync(
            dbName, tableName, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
