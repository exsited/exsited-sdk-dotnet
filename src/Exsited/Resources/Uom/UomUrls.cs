namespace Exsited.Resources.Uom;

/// <summary>Path templates and body keys for the v4 uom endpoints.</summary>
public static class UomUrls
{
    public const string SettingsUoms = "/api/{api_version}/settings/uom";

    public const string SettingsUom = "/api/{api_version}/settings/uom/{uom_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/settings/uom</c> and <c>GET /api/{api_version}/settings/uom/{uom_id}</c>.</summary>
    public const string UomKey = "uom";
}
