using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Refunds.RefundsDto;

namespace Exsited.Resources.Refunds;

/// <summary>The v4 refunds endpoints, as a typed resource bound to one client.</summary>
public sealed class Refunds : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Refunds</c>.</summary>
    public Refunds(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/refunds</c>.</summary>
    public Task<ApiResponse> GetRefundsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.Refunds,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/refunds/{refund_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteRefundAsync(
        string refundId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RefundsUrls.Refund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/refunds/{refund_id}</c>.</summary>
    public Task<ApiResponse> GetRefundAsync(
        string refundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.Refund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Refund),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/refunds/{refund_id}</c>.</summary>
    public Task<ApiResponse> UpdateRefundAsync(
        string refundId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(RefundsUrls.Refund,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/credit_notes/{credit_note_id}/refunds</c>.</summary>
    public Task<ApiResponse> CreateCreditNoteRefundAsync(
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(RefundsUrls.CreditNoteRefunds,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/refunds/{refund_id}/notes</c>.</summary>
    public Task<ApiResponse> GetRefundNotesAsync(
        string refundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.RefundNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}</c>.</summary>
    public Task<ApiResponse> GetRefundNoteAsync(
        string refundId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.RefundNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundNote),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/refunds/{refund_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateRefundNoteAsync(
        string refundId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(RefundsUrls.RefundNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundNote),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/refunds/{refund_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteRefundNoteAsync(
        string refundId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RefundsUrls.RefundNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}/files</c>.</summary>
    public Task<ApiResponse> GetRefundNoteFilesAsync(
        string refundId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.RefundNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteFileList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/refunds/{refund_id}/notes/{note_id}/files/{file_id}</c>.</summary>
    public Task<ApiResponse> GetRefundNoteFileAsync(
        string refundId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(RefundsUrls.RefundNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(RefundNoteFile),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/refunds/{refund_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteRefundNoteFileAsync(
        string refundId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(RefundsUrls.RefundNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["refund_id"] = refundId, ["note_id"] = noteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundsAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.DeleteRefundAsync</c>.</summary>
    public static Task<ApiResponse> DeleteRefundAsync(
        ExsitedClient client,
        string refundId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.DeleteRefundAsync(
            refundId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundAsync(
        ExsitedClient client,
        string refundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundAsync(
            refundId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.UpdateRefundAsync</c>.</summary>
    public static Task<ApiResponse> UpdateRefundAsync(
        ExsitedClient client,
        string refundId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.UpdateRefundAsync(
            refundId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.CreateCreditNoteRefundAsync</c>.</summary>
    public static Task<ApiResponse> CreateCreditNoteRefundAsync(
        ExsitedClient client,
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.CreateCreditNoteRefundAsync(
            creditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundNotesAsync(
        ExsitedClient client,
        string refundId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundNotesAsync(
            refundId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundNoteAsync(
        ExsitedClient client,
        string refundId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundNoteAsync(
            refundId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.CreateRefundNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateRefundNoteAsync(
        ExsitedClient client,
        string refundId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.CreateRefundNoteAsync(
            refundId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.DeleteRefundNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteRefundNoteAsync(
        ExsitedClient client,
        string refundId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.DeleteRefundNoteAsync(
            refundId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundNoteFilesAsync(
        ExsitedClient client,
        string refundId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundNoteFilesAsync(
            refundId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.GetRefundNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetRefundNoteFileAsync(
        ExsitedClient client,
        string refundId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.GetRefundNoteFileAsync(
            refundId, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Refunds.DeleteRefundNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteRefundNoteFileAsync(
        ExsitedClient client,
        string refundId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Refunds.DeleteRefundNoteFileAsync(
            refundId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
