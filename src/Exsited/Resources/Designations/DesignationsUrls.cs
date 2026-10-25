namespace Exsited.Resources.Designations;

/// <summary>Path templates and body keys for the v4 designations endpoints.</summary>
public static class DesignationsUrls
{
    public const string SettingsDesignations = "/api/{api_version}/settings/designations";

    public const string SettingsDesignation = "/api/{api_version}/settings/designations/{designation_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/designations</c> and <c>GET /api/{api_version}/settings/designations/{designation_id}</c>.</summary>
    public const string DesignationKey = "designation";
}
