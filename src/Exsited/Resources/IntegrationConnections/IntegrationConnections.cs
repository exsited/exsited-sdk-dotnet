using Exsited.Client;
using Exsited.Resources.IntegrationConnections.IntegrationConnectionsDto;

namespace Exsited.Resources.IntegrationConnections;

/// <summary>The v4 integration connections endpoints, as a typed resource bound to one client.</summary>
public sealed class IntegrationConnections : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.IntegrationConnections</c>.</summary>
    public IntegrationConnections(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/integration_connections</c>; filter by status with <c>filter_status</c>
    /// (<c>QueryParams.FilterParam("status")</c>): ACTIVE, INACTIVE or DISCONNECTED. A plain <c>status</c> is ignored.</summary>
    public Task<ApiResponse> GetIntegrationConnectionsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(IntegrationConnectionsUrls.IntegrationConnections,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(IntegrationConnectionsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/integration_connections/{integration_connection_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetIntegrationConnectionAsync(
        string integrationConnectionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(IntegrationConnectionsUrls.IntegrationConnection,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["integration_connection_id"] = integrationConnectionId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.IntegrationConnections.GetIntegrationConnectionsAsync</c>.</summary>
    public static Task<ApiResponse> GetIntegrationConnectionsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.IntegrationConnections.GetIntegrationConnectionsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.IntegrationConnections.GetIntegrationConnectionAsync</c>.</summary>
    public static Task<ApiResponse> GetIntegrationConnectionAsync(
        ExsitedClient client,
        string integrationConnectionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.IntegrationConnections.GetIntegrationConnectionAsync(
            integrationConnectionId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
