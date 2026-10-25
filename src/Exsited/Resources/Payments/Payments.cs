using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Payments.PaymentsDto;

namespace Exsited.Resources.Payments;

/// <summary>The v4 payments endpoints, as a typed resource bound to one client.</summary>
public sealed class Payments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Payments</c>.</summary>
    public Payments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/payments</c>.</summary>
    public Task<ApiResponse> GetPaymentsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.Payments,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/payments/notes</c>.</summary>
    public Task<ApiResponse> GetPaymentsNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.PaymentsNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentsNoteList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/payments/{payment_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePaymentAsync(
        string paymentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PaymentsUrls.Payment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/payments/{payment_id}</c>.</summary>
    public Task<ApiResponse> UpdatePaymentAsync(
        string paymentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PaymentsUrls.Payment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/payments/{payment_id}</c>.</summary>
    public Task<ApiResponse> GetPaymentAsync(
        string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.Payment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/payments</c>.</summary>
    public Task<ApiResponse> GetInvoicePaymentsAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.InvoicePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/orders/{order_id}/payments</c>.</summary>
    public Task<ApiResponse> GetOrderPaymentsAsync(
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.OrderPayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["order_id"] = orderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/payments/{payment_id}/notes</c>.</summary>
    public Task<ApiResponse> GetPaymentNotesAsync(
        string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.PaymentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/payments/{payment_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreatePaymentNoteAsync(
        string paymentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(PaymentsUrls.PaymentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}</c>.</summary>
    public Task<ApiResponse> GetPaymentNoteAsync(
        string paymentId, string paymentNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.PaymentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId, ["payment_note_id"] = paymentNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentNoteRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePaymentNoteAsync(
        string paymentId, string paymentNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PaymentsUrls.PaymentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId, ["payment_note_id"] = paymentNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}/files/{payment_f ile_id}</c>.</summary>
    public Task<ApiResponse> GetPaymentNoteFileAsync(
        string paymentId, string paymentNoteId, string paymentFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.PaymentNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId, ["payment_note_id"] = paymentNoteId, ["payment_file_id"] = paymentFileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentNoteFile),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/payments</c>.</summary>
    public Task<ApiResponse> CreatePaymentAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PaymentsUrls.Payments,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentRead),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/payments/{payment_id}</c>.</summary>
    public Task<ApiResponse> GetInvoicePaymentAsync(
        string invoiceId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.InvoicePayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId, ["payment_id"] = paymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PaymentRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/payments/{payment_id}/notes/{payment_note_id}/files</c>.</summary>
    public Task<ApiResponse> GetPaymentNoteFilesAsync(
        string paymentId, string paymentNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PaymentsUrls.PaymentNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["payment_id"] = paymentId, ["payment_note_id"] = paymentNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteFileList),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentsNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentsNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentsNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.DeletePaymentAsync</c>.</summary>
    public static Task<ApiResponse> DeletePaymentAsync(
        ExsitedClient client,
        string paymentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.DeletePaymentAsync(
            paymentId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.UpdatePaymentAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePaymentAsync(
        ExsitedClient client,
        string paymentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.UpdatePaymentAsync(
            paymentId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentAsync(
        ExsitedClient client,
        string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentAsync(
            paymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetInvoicePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoicePaymentsAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetInvoicePaymentsAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetOrderPaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetOrderPaymentsAsync(
        ExsitedClient client,
        string orderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetOrderPaymentsAsync(
            orderId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentNotesAsync(
        ExsitedClient client,
        string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentNotesAsync(
            paymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.CreatePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePaymentNoteAsync(
        ExsitedClient client,
        string paymentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.CreatePaymentNoteAsync(
            paymentId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentNoteAsync(
        ExsitedClient client,
        string paymentId, string paymentNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentNoteAsync(
            paymentId, paymentNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.DeletePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePaymentNoteAsync(
        ExsitedClient client,
        string paymentId, string paymentNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.DeletePaymentNoteAsync(
            paymentId, paymentNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentNoteFileAsync(
        ExsitedClient client,
        string paymentId, string paymentNoteId, string paymentFileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentNoteFileAsync(
            paymentId, paymentNoteId, paymentFileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Payments.CreatePaymentAsync</c>.</summary>
    public static Task<ApiResponse> CreatePaymentAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.CreatePaymentAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetInvoicePaymentAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoicePaymentAsync(
        ExsitedClient client,
        string invoiceId, string paymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetInvoicePaymentAsync(
            invoiceId, paymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Payments.GetPaymentNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetPaymentNoteFilesAsync(
        ExsitedClient client,
        string paymentId, string paymentNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Payments.GetPaymentNoteFilesAsync(
            paymentId, paymentNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
