namespace Exsited.Resources.Countries;

/// <summary>Path templates and body keys for the v4 countries endpoints.</summary>
public static class CountriesUrls
{
    public const string SettingsCountries = "/api/{api_version}/settings/countries";

    public const string SettingsCountry = "/api/{api_version}/settings/countries/{country_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string CountryKey = "country";
}
