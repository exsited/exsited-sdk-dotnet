namespace Exsited.Resources.Tasks;

/// <summary>Path templates and body keys for the v4 tasks endpoints.</summary>
public static class TasksUrls
{
    public const string Tasks = "/api/{api_version}/tasks";

    public const string Task = "/api/{api_version}/tasks/{task_id}";

    public const string TaskChecklist = "/api/{api_version}/tasks/{task_id}/checklist";

    public const string TaskNotes = "/api/{api_version}/tasks/{task_code}/notes";

    public const string TaskChecklistByUuid = "/api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}";

    public const string TaskNote = "/api/{api_version}/tasks/{task_code}/notes/{note_id}";

    public const string TaskNoteFiles = "/api/{api_version}/tasks/{task_code}/notes/{note_id}/files";

    public const string TaskNoteFile = "/api/{api_version}/tasks/{task_code}/notes/{note_id}/files/{file_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 5 endpoints its views were measured from.</summary>
    public const string WorkTaskKey = "work_task";
}
