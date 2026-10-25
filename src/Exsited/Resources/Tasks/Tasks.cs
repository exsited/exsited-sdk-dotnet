using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Tasks.TasksDto;

namespace Exsited.Resources.Tasks;

/// <summary>The v4 tasks endpoints, as a typed resource bound to one client.</summary>
public sealed class Tasks : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Tasks</c>.</summary>
    public Tasks(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/tasks</c>.</summary>
    public Task<ApiResponse> GetTasksAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.Tasks,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskList),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/tasks/{task_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteTaskAsync(
        string taskId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TasksUrls.Task,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/tasks/{task_id}</c>.</summary>
    public Task<ApiResponse> GetTaskAsync(
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.Task,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/tasks/{task_id}</c>.</summary>
    public Task<ApiResponse> UpdateTaskAsync(
        string taskId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(TasksUrls.Task,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/tasks/{task_id}/checklist</c>.</summary>
    public Task<ApiResponse> GetTaskChecklistAsync(
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskChecklist,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskChecklist),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/tasks/{task_id}/checklist</c>.</summary>
    public Task<ApiResponse> CreateTaskChecklistAsync(
        string taskId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(TasksUrls.TaskChecklist,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskChecklist),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/tasks/{task_code}/notes</c>.</summary>
    public Task<ApiResponse> GetTaskNotesAsync(
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskNoteList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/tasks/{task_code}/notes</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateTaskNoteAsync(
        string taskId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPostRequestAsync(TasksUrls.TaskNotes,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}</c>.</summary>
    public Task<ApiResponse> GetTaskChecklistByUuidAsync(
        string taskId, string taskChecklistUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskChecklistByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId, ["task_checklist_uuid"] = taskChecklistUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskChecklist),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/tasks/{task_code}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteTaskNoteAsync(
        string taskId, string taskNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TasksUrls.TaskNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskId, ["note_id"] = taskNoteId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/tasks</c>.</summary>
    public Task<ApiResponse> CreateTaskAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(TasksUrls.Tasks,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskView),
            }, cancellationToken);
    }

    /// <summary><c>PATCH /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateTaskChecklistByUuidAsync(
        string taskId, string taskChecklistUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(TasksUrls.TaskChecklistByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId, ["task_checklist_uuid"] = taskChecklistUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TaskView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteTaskChecklistByUuidAsync(
        string taskId, string taskChecklistUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TasksUrls.TaskChecklistByUuid,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_id"] = taskId, ["task_checklist_uuid"] = taskChecklistUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/tasks/{task_code}/notes/{note_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetTaskNoteAsync(
        string taskCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskCode, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/tasks/{task_code}/notes/{note_id}</c>; a form, the text as the <c>note</c> field, multipart when <c>files</c> are given; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateTaskNoteAsync(
        string taskCode, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequireNote(note);
        return Client.SendPatchRequestAsync(TasksUrls.TaskNote,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskCode, ["note_id"] = noteId },
                FormData = new Dictionary<string, object?> { ["note"] = note },
                Files = files,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/tasks/{task_code}/notes/{note_id}/files</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetTaskNoteFilesAsync(
        string taskCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskNoteFiles,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskCode, ["note_id"] = noteId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/tasks/{task_code}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetTaskNoteFileAsync(
        string taskCode, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TasksUrls.TaskNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskCode, ["note_id"] = noteId, ["file_id"] = fileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/tasks/{task_code}/notes/{note_id}/files/{file_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteTaskNoteFileAsync(
        string taskCode, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TasksUrls.TaskNoteFile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["task_code"] = taskCode, ["note_id"] = noteId, ["file_id"] = fileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Tasks.GetTasksAsync</c>.</summary>
    public static Task<ApiResponse> GetTasksAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTasksAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.DeleteTaskAsync</c>.</summary>
    public static Task<ApiResponse> DeleteTaskAsync(
        ExsitedClient client,
        string taskId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.DeleteTaskAsync(
            taskId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskAsync(
        ExsitedClient client,
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskAsync(
            taskId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.UpdateTaskAsync</c>.</summary>
    public static Task<ApiResponse> UpdateTaskAsync(
        ExsitedClient client,
        string taskId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.UpdateTaskAsync(
            taskId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskChecklistAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskChecklistAsync(
        ExsitedClient client,
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskChecklistAsync(
            taskId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.CreateTaskChecklistAsync</c>.</summary>
    public static Task<ApiResponse> CreateTaskChecklistAsync(
        ExsitedClient client,
        string taskId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.CreateTaskChecklistAsync(
            taskId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskNotesAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskNotesAsync(
        ExsitedClient client,
        string taskId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskNotesAsync(
            taskId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.CreateTaskNoteAsync</c>.</summary>
    public static Task<ApiResponse> CreateTaskNoteAsync(
        ExsitedClient client,
        string taskId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.CreateTaskNoteAsync(
            taskId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskChecklistByUuidAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskChecklistByUuidAsync(
        ExsitedClient client,
        string taskId, string taskChecklistUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskChecklistByUuidAsync(
            taskId, taskChecklistUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.DeleteTaskNoteAsync</c>.</summary>
    public static Task<ApiResponse> DeleteTaskNoteAsync(
        ExsitedClient client,
        string taskId, string taskNoteId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.DeleteTaskNoteAsync(
            taskId, taskNoteId, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }

    /// <summary>The client-first form of <c>client.Tasks.CreateTaskAsync</c>.</summary>
    public static Task<ApiResponse> CreateTaskAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.CreateTaskAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.UpdateTaskChecklistByUuidAsync</c>.</summary>
    public static Task<ApiResponse> UpdateTaskChecklistByUuidAsync(
        ExsitedClient client,
        string taskId, string taskChecklistUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.UpdateTaskChecklistByUuidAsync(
            taskId, taskChecklistUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.DeleteTaskChecklistByUuidAsync</c>.</summary>
    public static Task<ApiResponse> DeleteTaskChecklistByUuidAsync(
        ExsitedClient client,
        string taskId, string taskChecklistUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.DeleteTaskChecklistByUuidAsync(
            taskId, taskChecklistUuid, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskNoteAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskNoteAsync(
        ExsitedClient client,
        string taskCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskNoteAsync(
            taskCode, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.UpdateTaskNoteAsync</c>.</summary>
    public static Task<ApiResponse> UpdateTaskNoteAsync(
        ExsitedClient client,
        string taskCode, string noteId, string note, IReadOnlyDictionary<string, object?>? files = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.UpdateTaskNoteAsync(
            taskCode, noteId, note, files, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskNoteFilesAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskNoteFilesAsync(
        ExsitedClient client,
        string taskCode, string noteId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskNoteFilesAsync(
            taskCode, noteId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.GetTaskNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> GetTaskNoteFileAsync(
        ExsitedClient client,
        string taskCode, string noteId, string fileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.GetTaskNoteFileAsync(
            taskCode, noteId, fileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Tasks.DeleteTaskNoteFileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteTaskNoteFileAsync(
        ExsitedClient client,
        string taskCode, string noteId, string fileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Tasks.DeleteTaskNoteFileAsync(
            taskCode, noteId, fileId, raiseOnError, cancellationToken, responseFormat);

    private static void RequireNote(string note)
    {
        if (note is null)
            throw new SdkUsageError("note is required: the note text is the body of this request, "
                + "and null would send the form with no note at all");
    }
}
