namespace Exsited.Resources.IntegrationConnections.IntegrationConnectionsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class IntegrationConnectionsView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/integration_connections",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
