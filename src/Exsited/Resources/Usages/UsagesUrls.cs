namespace Exsited.Resources.Usages;

/// <summary>Path templates and body keys for the v4 usages endpoints.</summary>
public static class UsagesUrls
{
    public const string Usages = "/api/{api_version}/usages";

    public const string Usage = "/api/{api_version}/usages/{usage_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 5 endpoints its views were measured from.</summary>
    public const string UsageKey = "usage";
}
