namespace Exsited.Resources.ItemFulfillments;

/// <summary>Path templates and body keys for the v4 item fulfillments endpoints.</summary>
public static class ItemFulfillmentsUrls
{
    public const string ItemFulfillments = "/api/{api_version}/item_fulfillments";

    public const string ItemFulfillment = "/api/{api_version}/item_fulfillments/{fulfillment_id}";

    public const string ItemFulfillmentNotes = "/api/{api_version}/item_fulfillments/{fulfillment_id}/notes";

    public const string ItemFulfillmentNote = "/api/{api_version}/item_fulfillments/{fulfillment_id}/notes/{note_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 5 endpoints its views were measured from.</summary>
    public const string ItemFulfillmentKey = "item_fulfillment";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string InvoiceKey = "invoice";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/item_fulfillments/{fulfillment_id}/notes</c>.</summary>
    public const string NoteKey = "note";
}
