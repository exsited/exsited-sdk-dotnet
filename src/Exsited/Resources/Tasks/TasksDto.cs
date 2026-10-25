namespace Exsited.Resources.Tasks.TasksDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Task : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActualHours { get; set; }

    public string? Code { get; set; }

    public string? CompletedAt { get; set; }

    public CompletedByEntry? CompletedBy { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? DueDate { get; set; }

    public long? EstimatedHours { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Milestone { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentTask { get; set; }

    public string? Priority { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Resource { get; set; }

    public long? SortOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartAfter { get; set; }

    public string? StartDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? TaskStatus { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Workflow { get; set; }
}

/// <summary>One page of <see cref="Task"/> records, under <c>data</c>.</summary>
public sealed class TaskList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Task>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class TaskRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks/{task_id}",
    };

    protected override string? EnvelopeKey => "work_task";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActualHours { get; set; }

    public IReadOnlyList<object?>? Alerts { get; set; }

    public Assignees? Assignees { get; set; }

    public IReadOnlyList<Checklist>? Checklist { get; set; }

    public string? Code { get; set; }

    public string? CompletedAt { get; set; }

    public CompletedBy? CompletedBy { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? DueDate { get; set; }

    public long? EstimatedHours { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Milestone { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentTask { get; set; }

    public string? Priority { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Resource { get; set; }

    public long? SortOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartAfter { get; set; }

    public string? StartDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? TaskStatus { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Workflow { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class TaskChecklist : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks/{task_id}/checklist",
        "POST /api/{api_version}/tasks/{task_id}/checklist",
        "GET /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}",
    };

    protected override string? EnvelopeKey => "work_task";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActualHours { get; set; }

    public IReadOnlyList<object?>? Alerts { get; set; }

    public Assignees? Assignees { get; set; }

    /// <summary>Untyped: the records measured disagree on its type.</summary>
    public object? Checklist { get; set; }

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CompletedAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CompletedBy { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EstimatedHours { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Milestone { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentTask { get; set; }

    public string? Priority { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Resource { get; set; }

    public long? SortOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartAfter { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? TaskStatus { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Workflow { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class TaskNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks/{task_code}/notes",
    };
}

/// <summary>One page of <see cref="TaskNote"/> records, under <c>data</c>.</summary>
public sealed class TaskNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks/{task_code}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<TaskNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class TaskUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/tasks/{task_id}",
    };

    protected override string? EnvelopeKey => "work_task";

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActualHours { get; set; }

    public IReadOnlyList<object?>? Alerts { get; set; }

    public Assignees? Assignees { get; set; }

    public IReadOnlyList<object?>? Checklist { get; set; }

    public string? Code { get; set; }

    public string? CompletedAt { get; set; }

    public CompletedBy? CompletedBy { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EstimatedHours { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Milestone { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentTask { get; set; }

    public string? Priority { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Resource { get; set; }

    public long? SortOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartAfter { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? TaskStatus { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Workflow { get; set; }
}

/// <summary>An object sent as <c>completed_by</c>, merged over every record measured.</summary>
public sealed class CompletedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>checklist</c>, merged over every record measured.</summary>
public sealed class Checklist : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CompletedAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CompletedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? SortOrder { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>assignees</c>, merged over every record measured.</summary>
public sealed class Assignees : Dto
{
    public IReadOnlyList<object?>? ManuallyAddedAccountContacts { get; set; }

    public IReadOnlyList<object?>? SelectedAccountContacts { get; set; }

    public IReadOnlyList<SelectedEmployee>? SelectedEmployees { get; set; }

    public IReadOnlyList<SelectedLabour>? SelectedLabours { get; set; }

    public IReadOnlyList<object?>? SelectedOperators { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>, merged over every record measured.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>One entry of a list sent as <c>selected_labours</c>, merged over every record measured.</summary>
public sealed class SelectedLabour : Dto
{
    public long? DisplayOrder { get; set; }

    public string? Email { get; set; }

    public string? LabourCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Responsibility { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>selected_employees</c>, merged over every record measured.</summary>
public sealed class SelectedEmployee : Dto
{
    public long? DisplayOrder { get; set; }

    public string? Email { get; set; }

    public string? EmployeeCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Responsibility { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>completed_by</c>, merged over every record measured.</summary>
public sealed class CompletedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class TaskView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/tasks/{task_id}",
        "GET /api/{api_version}/tasks/{task_id}/checklist",
        "GET /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}",
        "PATCH /api/{api_version}/tasks/{task_id}",
        "POST /api/{api_version}/tasks/{task_id}/checklist",
        "POST /api/{api_version}/tasks",
        "PATCH /api/{api_version}/tasks/{task_id}/checklist/{task_checklist_uuid}",
    };

    protected override string? EnvelopeKey => "work_task";

    public IReadOnlyList<TaskViewActivityLog>? ActivityLogs { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ActualHours { get; set; }

    public IReadOnlyList<object?>? Alerts { get; set; }

    public TaskViewAssignees? Assignees { get; set; }

    public object? Checklist { get; set; }

    public string? Code { get; set; }

    public string? CompletedAt { get; set; }

    public TaskViewCompletedBy? CompletedBy { get; set; }

    public TaskViewCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? DueDate { get; set; }

    public long? EstimatedHours { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public TaskViewLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Milestone { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentTask { get; set; }

    public string? Priority { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Resource { get; set; }

    public long? SortOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartAfter { get; set; }

    public string? StartDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? TaskStatus { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Workflow { get; set; }
}

/// <summary>An object sent as <c>completed_by</c>, merged over every record measured.</summary>
public sealed class TaskViewCompletedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>assignees</c>, merged over every record measured.</summary>
public sealed class TaskViewAssignees : Dto
{
    public IReadOnlyList<object?>? ManuallyAddedAccountContacts { get; set; }

    public IReadOnlyList<object?>? SelectedAccountContacts { get; set; }

    public IReadOnlyList<TaskViewAssigneesSelectedEmployee>? SelectedEmployees { get; set; }

    public IReadOnlyList<TaskViewAssigneesSelectedLabour>? SelectedLabours { get; set; }

    public IReadOnlyList<object?>? SelectedOperators { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class TaskViewCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class TaskViewLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>, merged over every record measured.</summary>
public sealed class TaskViewActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>One entry of a list sent as <c>selected_labours</c>, merged over every record measured.</summary>
public sealed class TaskViewAssigneesSelectedLabour : Dto
{
    public long? DisplayOrder { get; set; }

    public string? Email { get; set; }

    public string? LabourCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Responsibility { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>selected_employees</c>, merged over every record measured.</summary>
public sealed class TaskViewAssigneesSelectedEmployee : Dto
{
    public long? DisplayOrder { get; set; }

    public string? Email { get; set; }

    public string? EmployeeCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Responsibility { get; set; }

    public string? Uuid { get; set; }
}
