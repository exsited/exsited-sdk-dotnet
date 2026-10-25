namespace Exsited.Resources.ItemReceipts;

/// <summary>Path templates and body keys for the v4 item receipts endpoints.</summary>
public static class ItemReceiptsUrls
{
    public const string ItemReceipts = "/api/{api_version}/item_receipts";

    public const string ItemReceipt = "/api/{api_version}/item_receipts/{item_receipt_id}";

    public const string PurchaseOrderItemReceipts = "/api/{api_version}/purchase_orders/{purchase_order_id}/item_receipts";

    public const string ItemReceiptNote = "/api/{api_version}/item_receipts/{item_receipt_id}/notes/{note_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string ItemReceiptKey = "item_receipt";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/item_receipts</c>.</summary>
    public const string ItemReceiptHyphenatedKey = "item-receipt";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/item_receipts</c>.</summary>
    public const string PurchaseOrderKey = "purchase_order";
}
