namespace Exsited.Resources.Items;

/// <summary>Path templates and body keys for the v4 items endpoints.</summary>
public static class ItemsUrls
{
    public const string Items = "/api/{api_version}/items";

    public const string Item = "/api/{api_version}/items/{item_id}";

    public const string ItemBundleDetails = "/api/{api_version}/items/{item_id}/bundle_details";

    public const string ItemDeactivate = "/api/{api_version}/items/{item_id}/deactivate";

    public const string ItemFamilyDetails = "/api/{api_version}/items/{item_id}/family_details";

    public const string ItemImage = "/api/{api_version}/items/{item_id}/image";

    public const string ItemInformation = "/api/{api_version}/items/{item_id}/information";

    public const string ItemInventories = "/api/{api_version}/items/{item_id}/inventories";

    public const string ItemInventoryAdjustments = "/api/{api_version}/items/{item_id}/inventory_adjustments";

    public const string ItemNotes = "/api/{api_version}/items/{item_id}/notes";

    public const string ItemPackageDetails = "/api/{api_version}/items/{item_id}/package_details";

    public const string ItemPurchase = "/api/{api_version}/items/{item_id}/purchase";

    public const string ItemReactivate = "/api/{api_version}/items/{item_id}/reactivate";

    public const string ItemSale = "/api/{api_version}/items/{item_id}/sale";

    public const string ItemVariations = "/api/{api_version}/items/{item_id}/variations";

    public const string ItemInventoryAdd = "/api/{api_version}/items/{item_id}/inventory/add";

    public const string ItemNote = "/api/{api_version}/items/{item_id}/notes/{item_note_id}";

    public const string ItemPackageDetail = "/api/{api_version}/items/{item_id}/package_details/{package_detail_id}";

    public const string ItemNoteFiles = "/api/{api_version}/items/{item_id}/notes/{item_note_id}/files";

    public const string ItemWarehouseInventories = "/api/{api_version}/items/{item_id}/warehouses/{warehouse_name}/inventories";

    public const string ItemNoteFile = "/api/{api_version}/items/{item_id}/notes/{item_note_id}/files/{item_file_id}";

    public const string ItemInventory = "/api/{api_version}/items/{item_id}/inventory";

    public const string ItemInventoriesAdd = "/api/{api_version}/items/{item_id}/inventories/add";

    public const string ItemKpis = "/api/{api_version}/items/{item_id}/kpis";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on the 24 endpoints its views were measured from.</summary>
    public const string ItemKey = "item";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files</c> and <c>GET /api/{api_version}/items/{item_id}/notes/{item_note_id}/files/{item_file_id}</c>.</summary>
    public const string FileKey = "file";
}
