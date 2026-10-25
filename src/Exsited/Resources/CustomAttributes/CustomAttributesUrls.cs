namespace Exsited.Resources.CustomAttributes;

/// <summary>Path templates and body keys for the v4 custom attributes endpoints.</summary>
public static class CustomAttributesUrls
{
    public const string CustomAttributes = "/api/{api_version}/custom_attributes";

    public const string CustomAttribute = "/api/{api_version}/custom_attributes/{custom_attribute_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string CustomAttributeKey = "custom_attribute";
}
