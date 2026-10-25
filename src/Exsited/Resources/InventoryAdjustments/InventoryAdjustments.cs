using Exsited.Client;
using Exsited.Resources.InventoryAdjustments.InventoryAdjustmentsDto;

namespace Exsited.Resources.InventoryAdjustments;

/// <summary>The v4 inventory adjustments endpoints, as a typed resource bound to one client.</summary>
public sealed class InventoryAdjustments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.InventoryAdjustments</c>.</summary>
    public InventoryAdjustments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/inventory_adjustments</c>.</summary>
    public Task<ApiResponse> GetInventoryAdjustmentsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InventoryAdjustmentsUrls.InventoryAdjustments,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InventoryAdjustmentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/inventory_adjustments/{inventory_adjustment_id}</c>.</summary>
    public Task<ApiResponse> GetInventoryAdjustmentAsync(
        string inventoryAdjustmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InventoryAdjustmentsUrls.InventoryAdjustment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["inventory_adjustment_id"] = inventoryAdjustmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InventoryAdjustment),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.InventoryAdjustments.GetInventoryAdjustmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetInventoryAdjustmentsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InventoryAdjustments.GetInventoryAdjustmentsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.InventoryAdjustments.GetInventoryAdjustmentAsync</c>.</summary>
    public static Task<ApiResponse> GetInventoryAdjustmentAsync(
        ExsitedClient client,
        string inventoryAdjustmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InventoryAdjustments.GetInventoryAdjustmentAsync(
            inventoryAdjustmentId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
