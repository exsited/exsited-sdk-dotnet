using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.NoteGroups.NoteGroupsDto;

namespace Exsited.Resources.NoteGroups;

/// <summary>The v4 note groups endpoints, as a typed resource bound to one client.</summary>
public sealed class NoteGroups : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.NoteGroups</c>.</summary>
    public NoteGroups(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/note_groups</c>.</summary>
    public Task<ApiResponse> GetNoteGroupsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(NoteGroupsUrls.NoteGroups,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteGroupList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/note_groups</c>.</summary>
    public Task<ApiResponse> CreateNoteGroupAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(NoteGroupsUrls.NoteGroups,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteGroupsView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/note_groups/{note_group_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteNoteGroupAsync(
        string noteGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(NoteGroupsUrls.NoteGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["note_group_id"] = noteGroupId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/note_groups/{note_group_id}</c>.</summary>
    public Task<ApiResponse> GetNoteGroupAsync(
        string noteGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(NoteGroupsUrls.NoteGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["note_group_id"] = noteGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteGroup),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/note_groups/{note_group_id}</c>.</summary>
    public Task<ApiResponse> UpdateNoteGroupAsync(
        string noteGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(NoteGroupsUrls.NoteGroup,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["note_group_id"] = noteGroupId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteGroupUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/note_groups/{note_group_id}/notes</c>.</summary>
    public Task<ApiResponse> GetNoteGroupNotesAsync(
        string noteGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(NoteGroupsUrls.NoteGroupNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["note_group_id"] = noteGroupId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(NoteGroupNotes),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/note_groups/{note_group_id}/notes/user/{note_user}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetNoteGroupNotesByUserAsync(
        string noteGroupId, string noteUser, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(NoteGroupsUrls.NoteGroupNotesByUser,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["note_group_id"] = noteGroupId, ["note_user"] = noteUser },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.NoteGroups.GetNoteGroupsAsync</c>.</summary>
    public static Task<ApiResponse> GetNoteGroupsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.GetNoteGroupsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.CreateNoteGroupAsync</c>.</summary>
    public static Task<ApiResponse> CreateNoteGroupAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.CreateNoteGroupAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.DeleteNoteGroupAsync</c>.</summary>
    public static Task<ApiResponse> DeleteNoteGroupAsync(
        ExsitedClient client,
        string noteGroupId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.DeleteNoteGroupAsync(
            noteGroupId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.GetNoteGroupAsync</c>.</summary>
    public static Task<ApiResponse> GetNoteGroupAsync(
        ExsitedClient client,
        string noteGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.GetNoteGroupAsync(
            noteGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.UpdateNoteGroupAsync</c>.</summary>
    public static Task<ApiResponse> UpdateNoteGroupAsync(
        ExsitedClient client,
        string noteGroupId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.UpdateNoteGroupAsync(
            noteGroupId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.GetNoteGroupNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetNoteGroupNotesAsync(
        ExsitedClient client,
        string noteGroupId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.GetNoteGroupNotesAsync(
            noteGroupId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.NoteGroups.GetNoteGroupNotesByUserAsync</c>.</summary>
    public static Task<ApiResponse> GetNoteGroupNotesByUserAsync(
        ExsitedClient client,
        string noteGroupId, string noteUser, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.NoteGroups.GetNoteGroupNotesByUserAsync(
            noteGroupId, noteUser, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
