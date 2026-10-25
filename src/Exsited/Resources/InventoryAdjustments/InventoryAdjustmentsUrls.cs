namespace Exsited.Resources.InventoryAdjustments;

/// <summary>Path templates and body keys for the v4 inventory adjustments endpoints.</summary>
public static class InventoryAdjustmentsUrls
{
    public const string InventoryAdjustments = "/api/{api_version}/inventory_adjustments";

    public const string InventoryAdjustment = "/api/{api_version}/inventory_adjustments/{inventory_adjustment_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string InventoryAdjustmentKey = "inventory_adjustment";
}
