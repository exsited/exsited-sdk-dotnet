namespace Exsited.Resources.IntegrationConnections;

/// <summary>Path templates for the v4 integration connections endpoints.</summary>
public static class IntegrationConnectionsUrls
{
    public const string IntegrationConnections = "/api/{api_version}/integration_connections";

    public const string IntegrationConnection = "/api/{api_version}/integration_connections/{integration_connection_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
