namespace Exsited.Resources.Orders;

/// <summary>Path templates and body keys for the v4 orders endpoints.</summary>
public static class OrdersUrls
{
    public const string Orders = "/api/{api_version}/orders";

    public const string Order = "/api/{api_version}/orders/{order_id}";

    public const string OrderActivate = "/api/{api_version}/orders/{order_id}/activate";

    public const string OrderActivateDraft = "/api/{api_version}/orders/{order_id}/activate_draft";

    public const string OrderBillingPreferences = "/api/{api_version}/orders/{order_id}/billing_preferences";

    public const string OrderCancel = "/api/{api_version}/orders/{order_id}/cancel";

    public const string OrderChange = "/api/{api_version}/orders/{order_id}/change";

    public const string OrderConvertToOrder = "/api/{api_version}/orders/{order_id}/convert_to_order";

    public const string OrderCustomObjects = "/api/{api_version}/orders/{order_id}/custom_objects";

    public const string OrderCustomObjectsInstances = "/api/{api_version}/orders/{order_id}/custom_objects_instances";

    public const string OrderDiscardDraft = "/api/{api_version}/orders/{order_id}/discard_draft";

    public const string OrderExtendTrial = "/api/{api_version}/orders/{order_id}/extend_trial";

    public const string OrderInformation = "/api/{api_version}/orders/{order_id}/information";

    public const string OrderItemFulfillments = "/api/{api_version}/orders/{order_id}/item_fulfillments";

    public const string OrderLines = "/api/{api_version}/orders/{order_id}/lines";

    public const string OrderNotes = "/api/{api_version}/orders/{order_id}/notes";

    public const string OrderPaymentMethods = "/api/{api_version}/orders/{order_id}/payment_methods";

    public const string OrderPdf = "/api/{api_version}/orders/{order_id}/pdf";

    public const string OrderReactivate = "/api/{api_version}/orders/{order_id}/reactivate";

    public const string OrderRelinquish = "/api/{api_version}/orders/{order_id}/relinquish";

    public const string OrderLine = "/api/{api_version}/orders/{order_id}/lines/{line_uuid}";

    public const string OrderNote = "/api/{api_version}/orders/{order_id}/notes/{order_note_id}";

    public const string OrderPaymentMethod = "/api/{api_version}/orders/{order_id}/payment_methods/{payment_method_ref}";

    public const string OrderLineBillingPreferences = "/api/{api_version}/orders/{order_id}/lines/{line_uuid}/billing_preferences";

    public const string OrderNoteFiles = "/api/{api_version}/orders/{order_id}/notes/{order_note_id}/files";

    public const string OrderNoteFile = "/api/{api_version}/orders/{order_id}/notes/{order_note_id}/files/{order_file_id}";

    public const string OrdersNotes = "/api/{api_version}/orders/notes";

    public const string OrdersPreview = "/api/{api_version}/orders/preview";

    public const string OrdersExpress = "/api/{api_version}/orders/express";

    public const string OrderAccept = "/api/{api_version}/orders/{order_id}/accept";

    public const string OrderActivateInvoiceFromDormant = "/api/{api_version}/orders/{order_id}/activate_invoice_from_dormant/{invoice_uuid}";

    public const string OrderChangePreview = "/api/{api_version}/orders/{order_id}/change/preview";

    public const string OrderChangeStatus = "/api/{api_version}/orders/{order_id}/change_status";

    public const string OrderContractAdjustment = "/api/{api_version}/orders/{order_id}/contract_adjustment";

    public const string OrderContractAdjustmentPreview = "/api/{api_version}/orders/{order_id}/contract_adjustment/preview";

    public const string OrderDowngrade = "/api/{api_version}/orders/{order_id}/downgrade";

    public const string OrderDowngradePreview = "/api/{api_version}/orders/{order_id}/downgrade/preview";

    public const string OrderUpgrade = "/api/{api_version}/orders/{order_id}/upgrade";

    public const string OrderUpgradePreview = "/api/{api_version}/orders/{order_id}/upgrade/preview";

    public const string OrderTerminateTrial = "/api/{api_version}/orders/{order_id}/terminate_trial";

    public const string OrderCustomObject = "/api/{api_version}/orders/{order_id}/custom_objects/{custom_object_id}";

    public const string OrderCustomObjectInstance = "/api/{api_version}/orders/{order_id}/custom_objects/{custom_object_id}/instances/{instance_id}";

    public const string OrderCustomObjectsInstance = "/api/{api_version}/orders/{order_id}/custom_objects_instances/{custom_object_id}";

    public const string OrderCustomObjectsInstanceInstance = "/api/{api_version}/orders/{order_id}/custom_objects_instances/{custom_object_id}/instances/{instance_id}";

    public const string OrderItemFulfillment = "/api/{api_version}/orders/{order_id}/item_fulfillments/{fulfillment_id}";

    public const string OrderKpis = "/api/{api_version}/orders/{order_id}/kpis";

    public const string OrderPayment = "/api/{api_version}/orders/{order_id}/payments/{payment_id}";

    public const string OrderQuotePartialInvoices = "/api/{api_version}/orders/{order_id}/quote_partial_invoices";

    public const string OrderShippingPdf = "/api/{api_version}/orders/{order_id}/shipping_pdf/{shipping_line_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 22 endpoints its views were measured from.</summary>
    public const string OrderKey = "order";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/orders/{order_id}/lines/{line_uuid}</c>.</summary>
    public const string OrderLineKey = "order_line";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files</c> and <c>GET /api/{api_version}/orders/{order_id}/notes/{order_note_id}/files/{order_file_id}</c>.</summary>
    public const string FileKey = "file";
}
