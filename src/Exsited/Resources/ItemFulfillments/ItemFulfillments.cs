using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ItemFulfillments.ItemFulfillmentsDto;

namespace Exsited.Resources.ItemFulfillments;

/// <summary>The v4 item fulfillments endpoints, as a typed resource bound to one client.</summary>
public sealed class ItemFulfillments : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ItemFulfillments</c>.</summary>
    public ItemFulfillments(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/item_fulfillments</c>.</summary>
    public Task<ApiResponse> GetItemFulfillmentsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemFulfillmentsUrls.ItemFulfillments,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/item_fulfillments</c>.</summary>
    public Task<ApiResponse> CreateItemFulfillmentAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ItemFulfillmentsUrls.ItemFulfillments,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentsView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public Task<ApiResponse> GetItemFulfillmentAsync(
        string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemFulfillmentsUrls.ItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/item_fulfillments/{fulfillment_id}</c>.</summary>
    public Task<ApiResponse> UpdateItemFulfillmentAsync(
        string fulfillmentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ItemFulfillmentsUrls.ItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentUpdated),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/item_fulfillments/{fulfillment_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateItemFulfillmentNoteAsync(
        string fulfillmentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(ItemFulfillmentsUrls.ItemFulfillmentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentNotes),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/item_fulfillments/{fulfillment_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemFulfillmentAsync(
        string fulfillmentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemFulfillmentsUrls.ItemFulfillment,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/item_fulfillments/{fulfillment_id}/notes</c>.</summary>
    public Task<ApiResponse> GetItemFulfillmentNotesAsync(
        string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemFulfillmentsUrls.ItemFulfillmentNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentNoteList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/item_fulfillments/{fulfillment_id}/notes/{note_id}</c>.</summary>
    public Task<ApiResponse> GetItemFulfillmentNoteAsync(
        string fulfillmentId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ItemFulfillmentsUrls.ItemFulfillmentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ItemFulfillmentNoteRead),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/item_fulfillments/{fulfillment_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteItemFulfillmentNoteAsync(
        string fulfillmentId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ItemFulfillmentsUrls.ItemFulfillmentNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_id"] = fulfillmentId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.ItemFulfillments.GetItemFulfillmentsAsync</c>.</summary>
    public static Task<ApiResponse> GetItemFulfillmentsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.GetItemFulfillmentsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.CreateItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemFulfillmentAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.CreateItemFulfillmentAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.GetItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> GetItemFulfillmentAsync(
        ExsitedClient client,
        string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.GetItemFulfillmentAsync(
            fulfillmentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.UpdateItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> UpdateItemFulfillmentAsync(
        ExsitedClient client,
        string fulfillmentId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.UpdateItemFulfillmentAsync(
            fulfillmentId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.CreateItemFulfillmentNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateItemFulfillmentNoteAsync(
        ExsitedClient client,
        string fulfillmentId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.CreateItemFulfillmentNoteAsync(
            fulfillmentId, note, files, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.ItemFulfillments.DeleteItemFulfillmentAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemFulfillmentAsync(
        ExsitedClient client,
        string fulfillmentId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.DeleteItemFulfillmentAsync(
            fulfillmentId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.GetItemFulfillmentNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetItemFulfillmentNotesAsync(
        ExsitedClient client,
        string fulfillmentId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.GetItemFulfillmentNotesAsync(
            fulfillmentId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.GetItemFulfillmentNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetItemFulfillmentNoteAsync(
        ExsitedClient client,
        string fulfillmentId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.GetItemFulfillmentNoteAsync(
            fulfillmentId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ItemFulfillments.DeleteItemFulfillmentNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteItemFulfillmentNoteAsync(
        ExsitedClient client,
        string fulfillmentId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ItemFulfillments.DeleteItemFulfillmentNoteAsync(
            fulfillmentId, noteId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
