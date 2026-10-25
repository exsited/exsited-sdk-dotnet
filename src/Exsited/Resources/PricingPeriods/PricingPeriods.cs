using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PricingPeriods.PricingPeriodsDto;

namespace Exsited.Resources.PricingPeriods;

/// <summary>The v4 pricing periods endpoints, as a typed resource bound to one client.</summary>
public sealed class PricingPeriods : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PricingPeriods</c>.</summary>
    public PricingPeriods(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/pricing_periods</c>.</summary>
    public Task<ApiResponse> GetSettingsPricingPeriodsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PricingPeriodsUrls.SettingsPricingPeriods,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingPeriodList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/pricing_periods</c>.</summary>
    public Task<ApiResponse> CreateSettingsPricingPeriodAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PricingPeriodsUrls.SettingsPricingPeriods,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingPeriod),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/pricing_periods/{pricing_period_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsPricingPeriodAsync(
        string pricingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PricingPeriodsUrls.SettingsPricingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_period_id"] = pricingPeriodId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingPeriod),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/pricing_periods/{pricing_period_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsPricingPeriodAsync(
        string pricingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(PricingPeriodsUrls.SettingsPricingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_period_id"] = pricingPeriodId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/pricing_periods/{pricing_period_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsPricingPeriodAsync(
        string pricingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(PricingPeriodsUrls.SettingsPricingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["pricing_period_id"] = pricingPeriodId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsPricingPeriod),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.PricingPeriods.GetSettingsPricingPeriodsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPricingPeriodsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PricingPeriods.GetSettingsPricingPeriodsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PricingPeriods.CreateSettingsPricingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsPricingPeriodAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PricingPeriods.CreateSettingsPricingPeriodAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PricingPeriods.GetSettingsPricingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsPricingPeriodAsync(
        ExsitedClient client,
        string pricingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PricingPeriods.GetSettingsPricingPeriodAsync(
            pricingPeriodId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PricingPeriods.DeleteSettingsPricingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsPricingPeriodAsync(
        ExsitedClient client,
        string pricingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PricingPeriods.DeleteSettingsPricingPeriodAsync(
            pricingPeriodId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PricingPeriods.UpdateSettingsPricingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsPricingPeriodAsync(
        ExsitedClient client,
        string pricingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PricingPeriods.UpdateSettingsPricingPeriodAsync(
            pricingPeriodId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
