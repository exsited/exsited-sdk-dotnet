using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CreditNotes.CreditNotesDto;

namespace Exsited.Resources.CreditNotes;

/// <summary>The v4 credit notes endpoints, as a typed resource bound to one client.</summary>
public sealed class CreditNotes : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CreditNotes</c>.</summary>
    public CreditNotes(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/credit_notes</c>.</summary>
    public Task<ApiResponse> GetCreditNotesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNotes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}</c>.</summary>
    public Task<ApiResponse> GetCreditNoteAsync(
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/credit_notes/{credit_note_id}</c>.</summary>
    public Task<ApiResponse> UpdateCreditNoteAsync(
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CreditNotesUrls.CreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/credit_notes</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateCreditNoteAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CreditNotesUrls.CreditNotes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/credit_notes/{credit_note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteCreditNoteAsync(
        string creditNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CreditNotesUrls.CreditNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/credit_notes/{credit_note_id}/apply</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> ApplyCreditNoteAsync(
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CreditNotesUrls.CreditNoteApply,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/items</c>.</summary>
    public Task<ApiResponse> GetCreditNoteItemsAsync(
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteItems,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteItems),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/credit_note_applications</c>.</summary>
    public Task<ApiResponse> GetCreditNoteCreditNoteApplicationsAsync(
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteCreditNoteApplications,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteApplicationsView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes</c>.</summary>
    public Task<ApiResponse> GetCreditNoteNotesAsync(
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}</c>.</summary>
    public Task<ApiResponse> GetCreditNoteNoteAsync(
        string creditNoteId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteNote),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/credit_notes/{credit_note_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateCreditNoteNoteAsync(
        string creditNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(CreditNotesUrls.CreditNoteNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteCreditNoteNoteAsync(
        string creditNoteId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CreditNotesUrls.CreditNoteNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}/files</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetCreditNoteNoteFilesAsync(
        string creditNoteId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_notes/{credit_note_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetCreditNoteNoteFileAsync(
        string creditNoteId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNotesUrls.CreditNoteNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_id"] = creditNoteId, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNotesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNotesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteAsync(
        ExsitedClient client,
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteAsync(
            creditNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.UpdateCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateCreditNoteAsync(
        ExsitedClient client,
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.UpdateCreditNoteAsync(
            creditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.CreateCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateCreditNoteAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.CreateCreditNoteAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.DeleteCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteCreditNoteAsync(
        ExsitedClient client,
        string creditNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.DeleteCreditNoteAsync(
            creditNoteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.ApplyCreditNoteAsync</c>.</summary>
    public static Task<ApiResponse> ApplyCreditNoteAsync(
        ExsitedClient client,
        string creditNoteId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.ApplyCreditNoteAsync(
            creditNoteId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteItemsAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteItemsAsync(
        ExsitedClient client,
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteItemsAsync(
            creditNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteCreditNoteApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteCreditNoteApplicationsAsync(
        ExsitedClient client,
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteCreditNoteApplicationsAsync(
            creditNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteNotesAsync(
        ExsitedClient client,
        string creditNoteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteNotesAsync(
            creditNoteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteNoteAsync(
        ExsitedClient client,
        string creditNoteId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteNoteAsync(
            creditNoteId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.CreateCreditNoteNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateCreditNoteNoteAsync(
        ExsitedClient client,
        string creditNoteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.CreateCreditNoteNoteAsync(
            creditNoteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.DeleteCreditNoteNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteCreditNoteNoteAsync(
        ExsitedClient client,
        string creditNoteId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.DeleteCreditNoteNoteAsync(
            creditNoteId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteNoteFilesAsync(
        ExsitedClient client,
        string creditNoteId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteNoteFilesAsync(
            creditNoteId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNotes.GetCreditNoteNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteNoteFileAsync(
        ExsitedClient client,
        string creditNoteId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNotes.GetCreditNoteNoteFileAsync(
            creditNoteId, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

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
