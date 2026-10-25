namespace Exsited.Resources.CustomFeatures;

/// <summary>Path templates and body keys for the v4 custom features endpoints.</summary>
public static class CustomFeaturesUrls
{
    public const string CustomFeature = "/api/{api_version}/custom_feature";

    public const string ComponentById = "/api/{api_version}/component/{custom_feature_id}";

    public const string CustomFeatureById = "/api/{api_version}/custom_feature/{custom_feature_id}";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string CustomFeatureKey = "custom_feature";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
