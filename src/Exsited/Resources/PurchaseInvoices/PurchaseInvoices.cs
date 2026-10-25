using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchaseInvoices.PurchaseInvoicesDto;

namespace Exsited.Resources.PurchaseInvoices;

/// <summary>The v4 purchase invoices endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseInvoices : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseInvoices</c>.</summary>
    public PurchaseInvoices(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoices,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_invoices</c>.</summary>
    public Task<ApiResponse> CreatePurchaseInvoiceAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseInvoicesUrls.PurchaseInvoices,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoicesView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/notes</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicesNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoicesNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoicesNoteList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_invoices/{purchase_invoice_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseInvoiceAsync(
        string purchaseInvoiceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseInvoicesUrls.PurchaseInvoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceRead),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/amend</c>.</summary>
    public Task<ApiResponse> AmendPurchaseInvoiceAsync(
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceAmend,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceAmend),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelPurchaseInvoiceAsync(
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceCancel),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/information</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceInformationAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoice),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_invoices/{purchase_invoice_id}/information</c>.</summary>
    public Task<ApiResponse> UpdatePurchaseInvoiceInformationAsync(
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceInformation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceInformation),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceLinesAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceLines,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceLines),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceNotesAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreatePurchaseInvoiceNoteAsync(
        string purchaseInvoiceId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNotes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/pdf</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicePdfAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoicePdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_credit_note_a pplications</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicePurchaseCreditNoteApplicationsAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoicePurchaseCreditNoteApplications,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(AccountPurchaseInvoices),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_payments</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicePurchasePaymentsAsync(
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoicePurchasePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoicePurchasePaymentList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_invoices/{purchase_invoice_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivatePurchaseInvoiceAsync(
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceReactivate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/lines/{purchase_invoic e_line_uuid}</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceLineAsync(
        string purchaseInvoiceId, string purchaseInvoiceLineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceLine,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["purchase_invoice_line_uuid"] = purchaseInvoiceLineUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceLine),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdatePurchaseInvoiceNoteAsync(
        string purchaseInvoiceId, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["note_id"] = noteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceNoteAsync(
        string purchaseInvoiceId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNoteRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseInvoiceNoteAsync(
        string purchaseInvoiceId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceNoteFilesAsync(
        string purchaseInvoiceId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/notes/{note_id}/files/ {file_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoiceNoteFileAsync(
        string purchaseInvoiceId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoiceNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseInvoiceNoteFile),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_invoices/{purchase_invoice_id}/purchase_credit_note_applications/{application_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseInvoicePurchaseCreditNoteApplicationAsync(
        string purchaseInvoiceId, string applicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseInvoicesUrls.PurchaseInvoicePurchaseCreditNoteApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_invoice_id"] = purchaseInvoiceId, ["application_id"] = applicationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteApplicationRead),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.CreatePurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseInvoiceAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.CreatePurchaseInvoiceAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicesNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicesNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicesNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.DeletePurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseInvoiceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.DeletePurchaseInvoiceAsync(
            purchaseInvoiceId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.AmendPurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> AmendPurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.AmendPurchaseInvoiceAsync(
            purchaseInvoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.CancelPurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> CancelPurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.CancelPurchaseInvoiceAsync(
            purchaseInvoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceInformationAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceInformationAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceInformationAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.UpdatePurchaseInvoiceInformationAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchaseInvoiceInformationAsync(
        ExsitedClient client,
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.UpdatePurchaseInvoiceInformationAsync(
            purchaseInvoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceLinesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceLinesAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceLinesAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceNotesAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceNotesAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.CreatePurchaseInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseInvoiceNoteAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.CreatePurchaseInvoiceNoteAsync(
            purchaseInvoiceId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicePdfAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicePdfAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicePdfAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicePurchaseCreditNoteApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicePurchaseCreditNoteApplicationsAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicePurchaseCreditNoteApplicationsAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicePurchasePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicePurchasePaymentsAsync(
        ExsitedClient client,
        string purchaseInvoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicePurchasePaymentsAsync(
            purchaseInvoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.ReactivatePurchaseInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> ReactivatePurchaseInvoiceAsync(
        ExsitedClient client,
        string purchaseInvoiceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.ReactivatePurchaseInvoiceAsync(
            purchaseInvoiceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceLineAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceLineAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string purchaseInvoiceLineUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceLineAsync(
            purchaseInvoiceId, purchaseInvoiceLineUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.UpdatePurchaseInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchaseInvoiceNoteAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.UpdatePurchaseInvoiceNoteAsync(
            purchaseInvoiceId, noteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceNoteAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceNoteAsync(
            purchaseInvoiceId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.DeletePurchaseInvoiceNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseInvoiceNoteAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.DeletePurchaseInvoiceNoteAsync(
            purchaseInvoiceId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceNoteFilesAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceNoteFilesAsync(
            purchaseInvoiceId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoiceNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoiceNoteFileAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoiceNoteFileAsync(
            purchaseInvoiceId, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.PurchaseInvoices.GetPurchaseInvoicePurchaseCreditNoteApplicationAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseInvoicePurchaseCreditNoteApplicationAsync(
        ExsitedClient client,
        string purchaseInvoiceId, string applicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseInvoices.GetPurchaseInvoicePurchaseCreditNoteApplicationAsync(
            purchaseInvoiceId, applicationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
