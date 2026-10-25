namespace Exsited.Resources.SalesReps;

/// <summary>Path templates and body keys for the v4 sales reps endpoints.</summary>
public static class SalesRepsUrls
{
    public const string SettingsSalesReps = "/api/{api_version}/settings/sales_reps";

    public const string SettingsSalesRep = "/api/{api_version}/settings/sales_reps/{sales_rep_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/sales_reps</c> and <c>GET /api/{api_version}/settings/sales_reps/{sales_rep_id}</c>.</summary>
    public const string SalesRepKey = "sales_rep";
}
