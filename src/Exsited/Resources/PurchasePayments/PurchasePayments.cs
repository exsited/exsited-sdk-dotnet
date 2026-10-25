using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchasePayments.PurchasePaymentsDto;

namespace Exsited.Resources.PurchasePayments;

/// <summary>The v4 purchase payments endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchasePayments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchasePayments</c>.</summary>
    public PurchasePayments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_payments</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePayments,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_payments</c>.</summary>
    public Task<ApiResponse> CreatePurchasePaymentAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchasePaymentsUrls.PurchasePayments,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentsView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/purchase_payments/{purchase_payment_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchasePaymentAsync(
        string purchasePaymentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchasePaymentsUrls.PurchasePayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentAsync(
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_payments/{purchase_payment_id}</c>.</summary>
    public Task<ApiResponse> UpdatePurchasePaymentAsync(
        string purchasePaymentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PurchasePaymentsUrls.PurchasePayment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments</c>.</summary>
    public Task<ApiResponse> CreatePurchaseInvoicePurchasePaymentAsync(
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchasePaymentsUrls.PurchaseInvoicePurchasePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentsView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentNotesAsync(
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePaymentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_payments/{purchase_payment_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreatePurchasePaymentNoteAsync(
        string purchasePaymentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(PurchasePaymentsUrls.PurchasePaymentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentNoteAsync(
        string purchasePaymentId, string ppNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePaymentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNoteRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchasePaymentNoteAsync(
        string purchasePaymentId, string ppNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchasePaymentsUrls.PurchasePaymentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentNoteFilesAsync(
        string purchasePaymentId, string ppNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePaymentNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/fil es/{file_id}</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentNoteFileAsync(
        string purchasePaymentId, string ppNoteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePaymentNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_payments/{purchase_payment_id}/purchase_credit_notes</c>.</summary>
    public Task<ApiResponse> GetPurchasePaymentPurchaseCreditNotesAsync(
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchasePaymentsUrls.PurchasePaymentPurchaseCreditNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteList),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdatePurchasePaymentNoteAsync(
        string purchasePaymentId, string ppNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(PurchasePaymentsUrls.PurchasePaymentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchasePaymentNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/purchase_payments/{purchase_payment_id}/notes/{pp_note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchasePaymentNoteFileAsync(
        string purchasePaymentId, string ppNoteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchasePaymentsUrls.PurchasePaymentNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_payment_id"] = purchasePaymentId, ["pp_note_id"] = ppNoteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.CreatePurchasePaymentAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchasePaymentAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.CreatePurchasePaymentAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.DeletePurchasePaymentAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchasePaymentAsync(
        ExsitedClient client,
        string purchasePaymentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.DeletePurchasePaymentAsync(
            purchasePaymentId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentAsync(
        ExsitedClient client,
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentAsync(
            purchasePaymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.UpdatePurchasePaymentAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchasePaymentAsync(
        ExsitedClient client,
        string purchasePaymentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.UpdatePurchasePaymentAsync(
            purchasePaymentId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.CreatePurchaseInvoicePurchasePaymentAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseInvoicePurchasePaymentAsync(
        ExsitedClient client,
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.CreatePurchaseInvoicePurchasePaymentAsync(
            purchaseInvoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentNotesAsync(
        ExsitedClient client,
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentNotesAsync(
            purchasePaymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.CreatePurchasePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchasePaymentNoteAsync(
        ExsitedClient client,
        string purchasePaymentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.CreatePurchasePaymentNoteAsync(
            purchasePaymentId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentNoteAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentNoteAsync(
            purchasePaymentId, ppNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.DeletePurchasePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchasePaymentNoteAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.DeletePurchasePaymentNoteAsync(
            purchasePaymentId, ppNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentNoteFilesAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentNoteFilesAsync(
            purchasePaymentId, ppNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentNoteFileAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentNoteFileAsync(
            purchasePaymentId, ppNoteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.PurchasePayments.GetPurchasePaymentPurchaseCreditNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchasePaymentPurchaseCreditNotesAsync(
        ExsitedClient client,
        string purchasePaymentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.GetPurchasePaymentPurchaseCreditNotesAsync(
            purchasePaymentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.UpdatePurchasePaymentNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchasePaymentNoteAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.UpdatePurchasePaymentNoteAsync(
            purchasePaymentId, ppNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchasePayments.DeletePurchasePaymentNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchasePaymentNoteFileAsync(
        ExsitedClient client,
        string purchasePaymentId, string ppNoteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchasePayments.DeletePurchasePaymentNoteFileAsync(
            purchasePaymentId, ppNoteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
