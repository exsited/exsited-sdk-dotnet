using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchaseCreditNotes.PurchaseCreditNotesDto;

namespace Exsited.Resources.PurchaseCreditNotes;

/// <summary>The v4 purchase credit notes endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseCreditNotes : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseCreditNotes</c>.</summary>
    public PurchaseCreditNotes(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_credit_notes</c>.</summary>
    public Task<ApiResponse> GetPurchaseCreditNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseCreditNoteAsync(
        string purchaseCreditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}</c>.</summary>
    public Task<ApiResponse> UpdatePurchaseCreditNoteAsync(
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_credit_notes</c>.</summary>
    public Task<ApiResponse> CreatePurchaseCreditNoteAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNotes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteCreated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseCreditNoteAsync(
        string purchaseCreditNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/apply</c>.</summary>
    public Task<ApiResponse> ApplyPurchaseCreditNoteAsync(
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNoteApply,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteCreated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreatePurchaseCreditNoteNoteAsync(
        string purchaseCreditNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNoteNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeletePurchaseCreditNoteNoteAsync(
        string purchaseCreditNoteId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PurchaseCreditNotesUrls.PurchaseCreditNoteNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_id"] = purchaseCreditNoteId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.GetPurchaseCreditNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseCreditNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.GetPurchaseCreditNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.GetPurchaseCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseCreditNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.GetPurchaseCreditNoteAsync(
            purchaseCreditNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.UpdatePurchaseCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdatePurchaseCreditNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.UpdatePurchaseCreditNoteAsync(
            purchaseCreditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.CreatePurchaseCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseCreditNoteAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.CreatePurchaseCreditNoteAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.DeletePurchaseCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseCreditNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.DeletePurchaseCreditNoteAsync(
            purchaseCreditNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.ApplyPurchaseCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> ApplyPurchaseCreditNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.ApplyPurchaseCreditNoteAsync(
            purchaseCreditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.CreatePurchaseCreditNoteNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseCreditNoteNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.CreatePurchaseCreditNoteNoteAsync(
            purchaseCreditNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNotes.DeletePurchaseCreditNoteNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeletePurchaseCreditNoteNoteAsync(
        ExsitedClient client,
        string purchaseCreditNoteId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNotes.DeletePurchaseCreditNoteNoteAsync(
            purchaseCreditNoteId, noteId, raiseOnError, cancellationToken, responseFormat);

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
