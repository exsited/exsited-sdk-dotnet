using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Countries.CountriesDto;

namespace Exsited.Resources.Countries;

/// <summary>The v4 countries endpoints, as a typed resource bound to one client.</summary>
public sealed class Countries : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Countries</c>.</summary>
    public Countries(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/countries</c>.</summary>
    public Task<ApiResponse> GetSettingsCountriesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CountriesUrls.SettingsCountries,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCountryList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/countries/{country_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCountryAsync(
        string countryId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CountriesUrls.SettingsCountry,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["country_id"] = countryId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCountry),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/countries/{country_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCountryAsync(
        string countryId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CountriesUrls.SettingsCountry,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["country_id"] = countryId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCountry),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Countries.GetSettingsCountriesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCountriesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Countries.GetSettingsCountriesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Countries.GetSettingsCountryAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCountryAsync(
        ExsitedClient client,
        string countryId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Countries.GetSettingsCountryAsync(
            countryId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Countries.UpdateSettingsCountryAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCountryAsync(
        ExsitedClient client,
        string countryId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Countries.UpdateSettingsCountryAsync(
            countryId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
