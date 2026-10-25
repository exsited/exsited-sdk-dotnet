namespace Exsited.Resources.Bookings;

/// <summary>Path templates and body keys for the v4 bookings endpoints.</summary>
public static class BookingsUrls
{
    public const string Booking = "/api/{api_version}/booking";

    public const string BookingById = "/api/{api_version}/booking/{booking_id}";

    public const string BookingPreview = "/api/{api_version}/booking/preview";

    public const string BookingNotes = "/api/{api_version}/booking/notes";

    public const string BookingBillingPreferences = "/api/{api_version}/booking/{booking_id}/billing_preferences";

    public const string BookingChange = "/api/{api_version}/booking/{booking_id}/change";

    public const string BookingChangePreview = "/api/{api_version}/booking/{booking_id}/change/preview";

    public const string BookingInformation = "/api/{api_version}/booking/{booking_id}/information";

    public const string BookingLines = "/api/{api_version}/booking/{booking_id}/lines";

    public const string BookingLine = "/api/{api_version}/booking/{booking_id}/lines/{line_uuid}";

    public const string BookingLineBillingPreferences = "/api/{api_version}/booking/{booking_id}/lines/{line_uuid}/billing_preferences";

    public const string BookingCustomObjects = "/api/{api_version}/booking/{booking_id}/custom_objects";

    public const string BookingCustomObject = "/api/{api_version}/booking/{booking_id}/custom_objects/{custom_object_id}";

    public const string BookingCustomObjectInstance = "/api/{api_version}/booking/{booking_id}/custom_objects/{custom_object_id}/instances/{instance_id}";

    public const string BookingCustomObjectsInstances = "/api/{api_version}/booking/{booking_id}/custom_objects_instances";

    public const string BookingCustomObjectsInstance = "/api/{api_version}/booking/{booking_id}/custom_objects_instances/{custom_object_id}";

    public const string BookingCustomObjectsInstanceInstance = "/api/{api_version}/booking/{booking_id}/custom_objects_instances/{custom_object_id}/instances/{instance_id}";

    public const string BookingInvoices = "/api/{api_version}/booking/{booking_id}/invoices";

    public const string BookingItemFulfillments = "/api/{api_version}/booking/{booking_id}/item_fulfillments";

    public const string BookingItemFulfillment = "/api/{api_version}/booking/{booking_id}/item_fulfillments/{fulfillment_id}";

    public const string BookingKpis = "/api/{api_version}/booking/{booking_id}/kpis";

    public const string BookingPaymentMethods = "/api/{api_version}/booking/{booking_id}/payment_methods";

    public const string BookingPaymentMethod = "/api/{api_version}/booking/{booking_id}/payment_methods/{payment_method_ref}";

    public const string BookingPayments = "/api/{api_version}/booking/{booking_id}/payments";

    public const string BookingPayment = "/api/{api_version}/booking/{booking_id}/payments/{payment_id}";

    public const string BookingPdf = "/api/{api_version}/booking/{booking_id}/pdf";

    public const string BookingQuotePartialInvoices = "/api/{api_version}/booking/{booking_id}/quote_partial_invoices";

    public const string BookingShippingPdf = "/api/{api_version}/booking/{booking_id}/shipping_pdf/{shipping_line_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/booking/{booking_id}</c>.</summary>
    public const string OrderKey = "order";
}
