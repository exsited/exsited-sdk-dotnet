namespace Exsited.Resources.ShippingPackages;

/// <summary>Path templates and body keys for the v4 shipping packages endpoints.</summary>
public static class ShippingPackagesUrls
{
    public const string SettingsShippingPackages = "/api/{api_version}/settings/shipping_packages";

    public const string SettingsShippingPackage = "/api/{api_version}/settings/shipping_packages/{shipping_package_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ShippingPackageKey = "shipping_package";
}
