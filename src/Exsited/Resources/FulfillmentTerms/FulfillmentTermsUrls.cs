namespace Exsited.Resources.FulfillmentTerms;

/// <summary>Path templates and body keys for the v4 fulfillment terms endpoints.</summary>
public static class FulfillmentTermsUrls
{
    public const string SettingsFulfillmentTerms = "/api/{api_version}/settings/fulfillment_terms";

    public const string SettingsFulfillmentTerm = "/api/{api_version}/settings/fulfillment_terms/{fulfillment_term_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string FulfillmentTermKey = "fulfillment_term";
}
