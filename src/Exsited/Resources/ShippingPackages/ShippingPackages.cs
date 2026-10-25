using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ShippingPackages.ShippingPackagesDto;

namespace Exsited.Resources.ShippingPackages;

/// <summary>The v4 shipping packages endpoints, as a typed resource bound to one client.</summary>
public sealed class ShippingPackages : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ShippingPackages</c>.</summary>
    public ShippingPackages(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/shipping_packages</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingPackagesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ShippingPackagesUrls.SettingsShippingPackages,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingPackageList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/shipping_packages</c>.</summary>
    public Task<ApiResponse> CreateSettingsShippingPackageAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ShippingPackagesUrls.SettingsShippingPackages,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingPackage),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/shipping_packages/{shipping_package_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingPackageAsync(
        string shippingPackageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ShippingPackagesUrls.SettingsShippingPackage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_package_id"] = shippingPackageId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingPackage),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/shipping_packages/{shipping_package_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsShippingPackageAsync(
        string shippingPackageId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ShippingPackagesUrls.SettingsShippingPackage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_package_id"] = shippingPackageId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/shipping_packages/{shipping_package_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsShippingPackageAsync(
        string shippingPackageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ShippingPackagesUrls.SettingsShippingPackage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_package_id"] = shippingPackageId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingPackage),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ShippingPackages.GetSettingsShippingPackagesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingPackagesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingPackages.GetSettingsShippingPackagesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingPackages.CreateSettingsShippingPackageAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsShippingPackageAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingPackages.CreateSettingsShippingPackageAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingPackages.GetSettingsShippingPackageAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingPackageAsync(
        ExsitedClient client,
        string shippingPackageId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingPackages.GetSettingsShippingPackageAsync(
            shippingPackageId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingPackages.DeleteSettingsShippingPackageAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsShippingPackageAsync(
        ExsitedClient client,
        string shippingPackageId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingPackages.DeleteSettingsShippingPackageAsync(
            shippingPackageId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingPackages.UpdateSettingsShippingPackageAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsShippingPackageAsync(
        ExsitedClient client,
        string shippingPackageId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingPackages.UpdateSettingsShippingPackageAsync(
            shippingPackageId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
