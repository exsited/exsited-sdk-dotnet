using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.BillingPeriods.BillingPeriodsDto;

namespace Exsited.Resources.BillingPeriods;

/// <summary>The v4 billing periods endpoints, as a typed resource bound to one client.</summary>
public sealed class BillingPeriods : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.BillingPeriods</c>.</summary>
    public BillingPeriods(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/billing_periods</c>.</summary>
    public Task<ApiResponse> GetSettingsBillingPeriodsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BillingPeriodsUrls.SettingsBillingPeriods,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsBillingPeriodList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/billing_periods</c>.</summary>
    public Task<ApiResponse> CreateSettingsBillingPeriodAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(BillingPeriodsUrls.SettingsBillingPeriods,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsBillingPeriod),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/billing_periods/{billing_period_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsBillingPeriodAsync(
        string billingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(BillingPeriodsUrls.SettingsBillingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["billing_period_id"] = billingPeriodId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsBillingPeriod),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/billing_periods/{billing_period_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsBillingPeriodAsync(
        string billingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(BillingPeriodsUrls.SettingsBillingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["billing_period_id"] = billingPeriodId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/billing_periods/{billing_period_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsBillingPeriodAsync(
        string billingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(BillingPeriodsUrls.SettingsBillingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["billing_period_id"] = billingPeriodId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsBillingPeriod),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.BillingPeriods.GetSettingsBillingPeriodsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsBillingPeriodsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.BillingPeriods.GetSettingsBillingPeriodsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.BillingPeriods.CreateSettingsBillingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsBillingPeriodAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.BillingPeriods.CreateSettingsBillingPeriodAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.BillingPeriods.GetSettingsBillingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsBillingPeriodAsync(
        ExsitedClient client,
        string billingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.BillingPeriods.GetSettingsBillingPeriodAsync(
            billingPeriodId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.BillingPeriods.DeleteSettingsBillingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsBillingPeriodAsync(
        ExsitedClient client,
        string billingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.BillingPeriods.DeleteSettingsBillingPeriodAsync(
            billingPeriodId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.BillingPeriods.UpdateSettingsBillingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsBillingPeriodAsync(
        ExsitedClient client,
        string billingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.BillingPeriods.UpdateSettingsBillingPeriodAsync(
            billingPeriodId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
