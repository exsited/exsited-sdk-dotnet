namespace Exsited.Resources.PurchaseOrders;

/// <summary>Path templates and body keys for the v4 purchase orders endpoints.</summary>
public static class PurchaseOrdersUrls
{
    public const string PurchaseOrders = "/api/{api_version}/purchase_orders";

    public const string PurchaseOrdersNotes = "/api/{api_version}/purchase_orders/notes";

    public const string PurchaseOrder = "/api/{api_version}/purchase_orders/{purchase_order_id}";

    public const string PurchaseOrderCancel = "/api/{api_version}/purchase_orders/{purchase_order_id}/cancel";

    public const string PurchaseOrderChange = "/api/{api_version}/purchase_orders/{purchase_order_id}/change";

    public const string PurchaseOrderInformation = "/api/{api_version}/purchase_orders/{purchase_order_id}/information";

    public const string PurchaseOrderLines = "/api/{api_version}/purchase_orders/{purchase_order_id}/lines";

    public const string PurchaseOrderNotes = "/api/{api_version}/purchase_orders/{purchase_order_id}/notes";

    public const string PurchaseOrderPurchaseInvoices = "/api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices";

    public const string PurchaseOrderPurchasePayments = "/api/{api_version}/purchase_orders/{purchase_order_id}/purchase_payments";

    public const string PurchaseOrderReactivate = "/api/{api_version}/purchase_orders/{purchase_order_id}/reactivate";

    public const string PurchaseOrderLine = "/api/{api_version}/purchase_orders/{purchase_order_id}/lines/{purchase_order_line_uuid}";

    public const string PurchaseOrderNote = "/api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}";

    public const string PurchaseOrderNoteFiles = "/api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files";

    public const string PurchaseOrderNoteFile = "/api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files/{purchase_order_file_id}";

    public const string PurchaseOrderKpis = "/api/{api_version}/purchase_orders/{purchase_order_id}/kpis";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 7 endpoints its views were measured from.</summary>
    public const string PurchaseOrderKey = "purchase_order";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/lines/{purchase_order_line_uuid}</c>.</summary>
    public const string PurchaseOrderLineKey = "purchase_order_line";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files</c> and <c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/notes/{purchase_order_note_id}/files/{purchase_order_file_id}</c>.</summary>
    public const string FileKey = "file";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/purchase_orders/{purchase_order_id}/purchase_invoices</c>.</summary>
    public const string PurchaseInvoiceKey = "purchase_invoice";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_orders/{purchase_order_id}/kpis</c>.</summary>
    public const string PurchaseOrderKpisKey = "purchase_order_kpis";
}
