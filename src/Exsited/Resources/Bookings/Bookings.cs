using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Bookings.BookingsDto;

namespace Exsited.Resources.Bookings;

/// <summary>The v4 bookings endpoints, as a typed resource bound to one client.</summary>
public sealed class Bookings : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Bookings</c>.</summary>
    public Bookings(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/booking</c>.</summary>
    public Task<ApiResponse> GetBookingAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.Booking,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}</c>.</summary>
    public Task<ApiResponse> GetBookingByIdAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/booking</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateBookingAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(BookingsUrls.Booking,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/booking/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewBookingAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(BookingsUrls.BookingPreview,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/booking/{booking_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteBookingAsync(
        string bookingId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(BookingsUrls.BookingById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/notes</c>.</summary>
    public Task<ApiResponse> GetBookingNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> GetBookingBillingPreferencesAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingBillingPreferencesView),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/booking/{booking_id}/billing_preferences</c>.</summary>
    public Task<ApiResponse> UpdateBookingBillingPreferencesAsync(
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(BookingsUrls.BookingBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/booking/{booking_id}/change</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ChangeBookingAsync(
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(BookingsUrls.BookingChange,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/booking/{booking_id}/change/preview</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> PreviewBookingChangeAsync(
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(BookingsUrls.BookingChangePreview,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/information</c>.</summary>
    public Task<ApiResponse> GetBookingInformationAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/booking/{booking_id}/information</c>.</summary>
    public Task<ApiResponse> UpdateBookingInformationAsync(
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(BookingsUrls.BookingInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/lines</c>.</summary>
    public Task<ApiResponse> GetBookingLinesAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingLines,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/lines/{line_uuid}</c>.</summary>
    public Task<ApiResponse> GetBookingLineAsync(
        string bookingId, string lineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["line_uuid"] = lineUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingLine),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/booking/{booking_id}/lines/{line_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateBookingLineAsync(
        string bookingId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(BookingsUrls.BookingLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["line_uuid"] = lineUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/booking/{booking_id}/lines/{line_uuid}/billing_preferences</c>.</summary>
    public Task<ApiResponse> UpdateBookingLineBillingPreferencesAsync(
        string bookingId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(BookingsUrls.BookingLineBillingPreferences,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["line_uuid"] = lineUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingById),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectsAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingCustomObjectList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectAsync(
        string bookingId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingCustomObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectInstanceAsync(
        string bookingId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects_instances</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectsInstancesAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObjectsInstances,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingCustomObjectList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects_instances/{custom_object_id}</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectsInstanceAsync(
        string bookingId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObjectsInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingCustomObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/custom_objects_instances/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetBookingCustomObjectsInstanceInstanceAsync(
        string bookingId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingCustomObjectsInstanceInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/invoices</c>.</summary>
    public Task<ApiResponse> GetBookingInvoicesAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingInvoiceList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/item_fulfillments</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetBookingItemFulfillmentsAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingItemFulfillments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public Task<ApiResponse> GetBookingItemFulfillmentAsync(
        string bookingId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["fulfillment_id"] = fulfillmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingItemFulfillment),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/kpis</c>.</summary>
    public Task<ApiResponse> GetBookingKpisAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingKpis,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingKpis),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/payment_methods</c>.</summary>
    public Task<ApiResponse> GetBookingPaymentMethodsAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingPaymentMethods,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingPaymentMethods),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/payment_methods/{payment_method_ref}</c>.</summary>
    public Task<ApiResponse> GetBookingPaymentMethodAsync(
        string bookingId, string paymentMethodRef, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingPaymentMethod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["payment_method_ref"] = paymentMethodRef },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingPaymentMethod),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/payments</c>.</summary>
    public Task<ApiResponse> GetBookingPaymentsAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingPayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingPaymentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/payments/{payment_id}</c>.</summary>
    public Task<ApiResponse> GetBookingPaymentAsync(
        string bookingId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingPayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["payment_id"] = paymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingPaymentView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/pdf</c>.</summary>
    public Task<ApiResponse> GetBookingPdfAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingPdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingPdf),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/quote_partial_invoices</c>.</summary>
    public Task<ApiResponse> GetBookingQuotePartialInvoicesAsync(
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingQuotePartialInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(BookingQuotePartialInvoices),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/booking/{booking_id}/shipping_pdf/{shipping_line_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetBookingShippingPdfAsync(
        string bookingId, string shippingLineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BookingsUrls.BookingShippingPdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["booking_id"] = bookingId, ["shipping_line_id"] = shippingLineId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingByIdAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingByIdAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.CreateBookingAsync</c>.</summary>
    public static Task<ApiResponse> CreateBookingAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.CreateBookingAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.PreviewBookingAsync</c>.</summary>
    public static Task<ApiResponse> PreviewBookingAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.PreviewBookingAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.DeleteBookingAsync</c>.</summary>
    public static Task<ApiResponse> DeleteBookingAsync(
        ExsitedClient client,
        string bookingId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.DeleteBookingAsync(
            bookingId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingBillingPreferencesAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingBillingPreferencesAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.UpdateBookingBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> UpdateBookingBillingPreferencesAsync(
        ExsitedClient client,
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.UpdateBookingBillingPreferencesAsync(
            bookingId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.ChangeBookingAsync</c>.</summary>
    public static Task<ApiResponse> ChangeBookingAsync(
        ExsitedClient client,
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.ChangeBookingAsync(
            bookingId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.PreviewBookingChangeAsync</c>.</summary>
    public static Task<ApiResponse> PreviewBookingChangeAsync(
        ExsitedClient client,
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.PreviewBookingChangeAsync(
            bookingId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingInformationAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingInformationAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.UpdateBookingInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateBookingInformationAsync(
        ExsitedClient client,
        string bookingId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.UpdateBookingInformationAsync(
            bookingId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingLinesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingLinesAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingLinesAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingLineAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingLineAsync(
        ExsitedClient client,
        string bookingId, string lineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingLineAsync(
            bookingId, lineUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.UpdateBookingLineAsync</c>.</summary>
    public static Task<ApiResponse> UpdateBookingLineAsync(
        ExsitedClient client,
        string bookingId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.UpdateBookingLineAsync(
            bookingId, lineUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.UpdateBookingLineBillingPreferencesAsync</c>.</summary>
    public static Task<ApiResponse> UpdateBookingLineBillingPreferencesAsync(
        ExsitedClient client,
        string bookingId, string lineUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.UpdateBookingLineBillingPreferencesAsync(
            bookingId, lineUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectsAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectsAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectAsync(
        ExsitedClient client,
        string bookingId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectAsync(
            bookingId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectInstanceAsync(
        ExsitedClient client,
        string bookingId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectInstanceAsync(
            bookingId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectsInstancesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectsInstancesAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectsInstancesAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectsInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectsInstanceAsync(
        ExsitedClient client,
        string bookingId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectsInstanceAsync(
            bookingId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingCustomObjectsInstanceInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingCustomObjectsInstanceInstanceAsync(
        ExsitedClient client,
        string bookingId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingCustomObjectsInstanceInstanceAsync(
            bookingId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingInvoicesAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingInvoicesAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingItemFulfillmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingItemFulfillmentsAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingItemFulfillmentsAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingItemFulfillmentAsync(
        ExsitedClient client,
        string bookingId, string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingItemFulfillmentAsync(
            bookingId, fulfillmentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingKpisAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingKpisAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingKpisAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingPaymentMethodsAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingPaymentMethodsAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingPaymentMethodsAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingPaymentMethodAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingPaymentMethodAsync(
        ExsitedClient client,
        string bookingId, string paymentMethodRef, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingPaymentMethodAsync(
            bookingId, paymentMethodRef, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingPaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingPaymentsAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingPaymentsAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingPaymentAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingPaymentAsync(
        ExsitedClient client,
        string bookingId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingPaymentAsync(
            bookingId, paymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingPdfAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingPdfAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingPdfAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingQuotePartialInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingQuotePartialInvoicesAsync(
        ExsitedClient client,
        string bookingId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingQuotePartialInvoicesAsync(
            bookingId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Bookings.GetBookingShippingPdfAsync</c>.</summary>
    public static Task<ApiResponse> GetBookingShippingPdfAsync(
        ExsitedClient client,
        string bookingId, string shippingLineId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Bookings.GetBookingShippingPdfAsync(
            bookingId, shippingLineId, queryParams, raiseOnError, cancellationToken, responseFormat);


    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
