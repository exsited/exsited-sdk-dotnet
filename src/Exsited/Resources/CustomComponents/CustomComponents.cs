using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CustomComponents.CustomComponentsDto;

namespace Exsited.Resources.CustomComponents;

/// <summary>The v4 custom components endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomComponents : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomComponents</c>.</summary>
    public CustomComponents(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/component</c>.</summary>
    public Task<ApiResponse> GetComponentAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.Component,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/component/{component_uuid}</c>.</summary>
    public Task<ApiResponse> GetComponentByUuidAsync(
        string componentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Component),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/component/{component_uuid}</c>.</summary>
    public Task<ApiResponse> CreateComponentByUuidAsync(
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentByUuid),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/component/{component_uuid}/{component_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentByIdAsync(
        string componentUuid, string componentObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/component/{component_uuid}/{component_object_id}</c>.</summary>
    public Task<ApiResponse> UpdateComponentByIdAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentById,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentByUuid),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects</c>.</summary>
    public Task<ApiResponse> GetComponentObjectsAsync(
        string componentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjects),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}</c>.</summary>
    public Task<ApiResponse> GetComponentObjectAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObject),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/acti vity</c>.</summary>
    public Task<ApiResponse> GetComponentObjectActivityAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectActivity,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectActivityList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/cust om_objects</c>.</summary>
    public Task<ApiResponse> GetComponentObjectCustomObjectsAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectCustomObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectCustomObjectList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/pdf</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectPdfAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectPdf,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/component</c>.</summary>
    public Task<ApiResponse> CreateComponentAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.Component,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Component),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/component/{component_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateComponentAsync(
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Component),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/component/{component_uuid}</c>, the same request as
    /// <c>client.CustomFeatures.DeleteComponentByIdAsync</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentAsync(
        string componentUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects</c>.</summary>
    public Task<ApiResponse> CreateComponentObjectAsync(
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjects,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}</c>.</summary>
    public Task<ApiResponse> UpdateComponentObjectAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/components/{component_uuid}/objects/{component_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentObjectAsync(
        string componentUuid, string componentObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity</c>.</summary>
    public Task<ApiResponse> CreateComponentObjectActivityAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectActivity,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectActivityEntry),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity/{activity_id}</c>.</summary>
    public Task<ApiResponse> GetComponentObjectActivityByIdAsync(
        string componentUuid, string componentObjectId, string activityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectActivityEntry,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["activity_id"] = activityId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectActivityEntry),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/milestones</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectMilestonesAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectMilestones,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/milestones/{milestone_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectMilestoneAsync(
        string componentUuid, string componentObjectId, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectMilestone,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["milestone_id"] = milestoneId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/history</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectHistoryAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectHistory,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/history/{history_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectHistoryByIdAsync(
        string componentUuid, string componentObjectId, string historyId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectHistoryEntry,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["history_id"] = historyId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes</c>.</summary>
    public Task<ApiResponse> GetComponentObjectNotesAsync(
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNotes),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}</c>.</summary>
    public Task<ApiResponse> GetComponentObjectNoteAsync(
        string componentUuid, string componentObjectId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNote),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files</c>.</summary>
    public Task<ApiResponse> GetComponentObjectNoteFilesAsync(
        string componentUuid, string componentObjectId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNoteFiles),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files/{file_id}</c>.</summary>
    public Task<ApiResponse> GetComponentObjectNoteFileAsync(
        string componentUuid, string componentObjectId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNoteFile),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> CreateComponentObjectNoteAsync(
        string componentUuid, string componentObjectId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNote),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given.</summary>
    public Task<ApiResponse> UpdateComponentObjectNoteAsync(
        string componentUuid, string componentObjectId, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentObjectNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectNote),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentObjectNoteAsync(
        string componentUuid, string componentObjectId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentObjectNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentObjectNoteFileAsync(
        string componentUuid, string componentObjectId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentObjectNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["note_id"] = noteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectCustomObjectAsync(
        string componentUuid, string componentObjectId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["custom_object_id"] = customObjectId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateComponentObjectCustomObjectInstanceAsync(
        string componentUuid, string componentObjectId, string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectCustomObject,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["custom_object_id"] = customObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetComponentObjectCustomObjectInstanceAsync(
        string componentUuid, string componentObjectId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomComponentsUrls.ComponentObjectCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateComponentObjectCustomObjectInstanceAsync(
        string componentUuid, string componentObjectId, string customObjectId, string instanceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentObjectCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}/instances/{instance_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteComponentObjectCustomObjectInstanceAsync(
        string componentUuid, string componentObjectId, string customObjectId, string instanceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomComponentsUrls.ComponentObjectCustomObjectInstance,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId, ["custom_object_id"] = customObjectId, ["instance_id"] = instanceId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/link_domains</c>.</summary>
    public Task<ApiResponse> LinkComponentObjectDomainsAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectLinkDomains,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/link_domains</c>.</summary>
    public Task<ApiResponse> UpdateComponentObjectDomainsAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomComponentsUrls.ComponentObjectLinkDomains,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/unlink_domains</c>.</summary>
    public Task<ApiResponse> UnlinkComponentObjectDomainsAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectUnlinkDomains,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/change_status</c>.</summary>
    public Task<ApiResponse> ChangeComponentObjectStatusAsync(
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomComponentsUrls.ComponentObjectChangeStatus,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["component_uuid"] = componentUuid, ["component_object_id"] = componentObjectId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ComponentObjectRecord),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentByUuidAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentByUuidAsync(
        ExsitedClient client,
        string componentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentByUuidAsync(
            componentUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentByUuidAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentByUuidAsync(
        ExsitedClient client,
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentByUuidAsync(
            componentUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentByIdAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentByIdAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentByIdAsync(
            componentUuid, componentObjectId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentByIdAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentByIdAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentByIdAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectsAsync(
        ExsitedClient client,
        string componentUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectsAsync(
            componentUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectActivityAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectActivityAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectActivityAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectCustomObjectsAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectCustomObjectsAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectCustomObjectsAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectPdfAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectPdfAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectPdfAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentAsync(
        ExsitedClient client,
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentAsync(
            componentUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentAsync(
        ExsitedClient client,
        string componentUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentAsync(
            componentUuid, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentObjectAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentObjectAsync(
        ExsitedClient client,
        string componentUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentObjectAsync(
            componentUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentObjectAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentObjectAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentObjectAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentObjectAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentObjectAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentObjectAsync(
            componentUuid, componentObjectId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentObjectActivityAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentObjectActivityAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentObjectActivityAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectActivityByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectActivityByIdAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string activityId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectActivityByIdAsync(
            componentUuid, componentObjectId, activityId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectMilestonesAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectMilestonesAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectMilestonesAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectMilestoneAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectMilestoneAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string milestoneId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectMilestoneAsync(
            componentUuid, componentObjectId, milestoneId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectHistoryAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectHistoryAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectHistoryAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectHistoryByIdAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectHistoryByIdAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string historyId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectHistoryByIdAsync(
            componentUuid, componentObjectId, historyId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectNotesAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectNotesAsync(
            componentUuid, componentObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectNoteAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectNoteAsync(
            componentUuid, componentObjectId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectNoteFilesAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectNoteFilesAsync(
            componentUuid, componentObjectId, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectNoteFileAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectNoteFileAsync(
            componentUuid, componentObjectId, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentObjectNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentObjectNoteAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentObjectNoteAsync(
            componentUuid, componentObjectId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentObjectNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentObjectNoteAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentObjectNoteAsync(
            componentUuid, componentObjectId, noteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentObjectNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentObjectNoteAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentObjectNoteAsync(
            componentUuid, componentObjectId, noteId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentObjectNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentObjectNoteFileAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentObjectNoteFileAsync(
            componentUuid, componentObjectId, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectCustomObjectAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectCustomObjectAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string customObjectId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectCustomObjectAsync(
            componentUuid, componentObjectId, customObjectId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.CreateComponentObjectCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> CreateComponentObjectCustomObjectInstanceAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string customObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.CreateComponentObjectCustomObjectInstanceAsync(
            componentUuid, componentObjectId, customObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.GetComponentObjectCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> GetComponentObjectCustomObjectInstanceAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string customObjectId, string instanceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.GetComponentObjectCustomObjectInstanceAsync(
            componentUuid, componentObjectId, customObjectId, instanceId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentObjectCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentObjectCustomObjectInstanceAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string customObjectId, string instanceId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentObjectCustomObjectInstanceAsync(
            componentUuid, componentObjectId, customObjectId, instanceId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.DeleteComponentObjectCustomObjectInstanceAsync</c>.</summary>
    public static Task<ApiResponse> DeleteComponentObjectCustomObjectInstanceAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, string customObjectId, string instanceId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.DeleteComponentObjectCustomObjectInstanceAsync(
            componentUuid, componentObjectId, customObjectId, instanceId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.LinkComponentObjectDomainsAsync</c>.</summary>
    public static Task<ApiResponse> LinkComponentObjectDomainsAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.LinkComponentObjectDomainsAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UpdateComponentObjectDomainsAsync</c>.</summary>
    public static Task<ApiResponse> UpdateComponentObjectDomainsAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UpdateComponentObjectDomainsAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.UnlinkComponentObjectDomainsAsync</c>.</summary>
    public static Task<ApiResponse> UnlinkComponentObjectDomainsAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.UnlinkComponentObjectDomainsAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomComponents.ChangeComponentObjectStatusAsync</c>.</summary>
    public static Task<ApiResponse> ChangeComponentObjectStatusAsync(
        ExsitedClient client,
        string componentUuid, string componentObjectId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomComponents.ChangeComponentObjectStatusAsync(
            componentUuid, componentObjectId, payload, raiseOnError, cancellationToken, responseFormat);

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
