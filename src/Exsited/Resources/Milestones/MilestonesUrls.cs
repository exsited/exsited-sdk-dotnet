namespace Exsited.Resources.Milestones;

/// <summary>Path templates and body keys for the v4 milestones endpoints.</summary>
public static class MilestonesUrls
{
    public const string Milestones = "/api/{api_version}/milestones";

    public const string MilestonesAccountById = "/api/{api_version}/milestones/account/{account_id}";

    public const string MilestonesLabourById = "/api/{api_version}/milestones/labour/{labour_id}";

    public const string MilestonesEmployeeByCode = "/api/{api_version}/milestones/employee/{employee_code}";

    public const string Milestone = "/api/{api_version}/milestones/{milestone_uuid}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
