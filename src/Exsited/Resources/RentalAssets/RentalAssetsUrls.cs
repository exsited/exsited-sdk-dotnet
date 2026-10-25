namespace Exsited.Resources.RentalAssets;

/// <summary>Path templates and body keys for the v4 rental assets endpoints.</summary>
public static class RentalAssetsUrls
{
    public const string RentalAssetAvailability = "/api/{api_version}/rental_asset_availability";

    public const string RentalAssetProfiles = "/api/{api_version}/rental_asset_profiles";

    public const string RentalAssets = "/api/{api_version}/rental_assets";

    public const string RentalAssetProfile = "/api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}";

    public const string RentalAsset = "/api/{api_version}/rental_assets/{rental_asset_uuid}";

    public const string RentalAssetCancel = "/api/{api_version}/rental_assets/{rental_asset_id}/cancel";

    public const string RentalAssetReactivate = "/api/{api_version}/rental_assets/{rental_asset_id}/reactivate";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 6 endpoints its views were measured from.</summary>
    public const string RentalAssetKey = "rental_asset";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/rental_asset_profiles</c> and <c>GET /api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}</c>.</summary>
    public const string RentalAssetProfileKey = "rental_asset_profile";
}
