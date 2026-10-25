namespace Exsited.Resources.Timesheets;

/// <summary>Path templates and body keys for the v4 timesheets endpoints.</summary>
public static class TimesheetsUrls
{
    public const string Timesheets = "/api/{api_version}/timesheets";

    public const string Timesheet = "/api/{api_version}/timesheets/{timesheet_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/timesheets</c> and <c>PATCH /api/{api_version}/timesheets/{timesheet_id}</c>.</summary>
    public const string TimesheetKey = "timesheet";
}
