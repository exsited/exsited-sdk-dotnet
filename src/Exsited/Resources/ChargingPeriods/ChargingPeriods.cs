using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ChargingPeriods.ChargingPeriodsDto;

namespace Exsited.Resources.ChargingPeriods;

/// <summary>The v4 charging periods endpoints, as a typed resource bound to one client.</summary>
public sealed class ChargingPeriods : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ChargingPeriods</c>.</summary>
    public ChargingPeriods(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/charging_periods</c>.</summary>
    public Task<ApiResponse> GetSettingsChargingPeriodsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ChargingPeriodsUrls.SettingsChargingPeriods,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsChargingPeriodList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/charging_periods</c>.</summary>
    public Task<ApiResponse> CreateSettingsChargingPeriodAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ChargingPeriodsUrls.SettingsChargingPeriods,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsChargingPeriod),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/charging_periods/{charging_period_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsChargingPeriodAsync(
        string chargingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ChargingPeriodsUrls.SettingsChargingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["charging_period_id"] = chargingPeriodId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsChargingPeriod),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/charging_periods/{charging_period_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsChargingPeriodAsync(
        string chargingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ChargingPeriodsUrls.SettingsChargingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["charging_period_id"] = chargingPeriodId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/charging_periods/{charging_period_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsChargingPeriodAsync(
        string chargingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ChargingPeriodsUrls.SettingsChargingPeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["charging_period_id"] = chargingPeriodId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsChargingPeriod),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ChargingPeriods.GetSettingsChargingPeriodsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsChargingPeriodsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ChargingPeriods.GetSettingsChargingPeriodsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ChargingPeriods.CreateSettingsChargingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsChargingPeriodAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ChargingPeriods.CreateSettingsChargingPeriodAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ChargingPeriods.GetSettingsChargingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsChargingPeriodAsync(
        ExsitedClient client,
        string chargingPeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ChargingPeriods.GetSettingsChargingPeriodAsync(
            chargingPeriodId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ChargingPeriods.DeleteSettingsChargingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsChargingPeriodAsync(
        ExsitedClient client,
        string chargingPeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ChargingPeriods.DeleteSettingsChargingPeriodAsync(
            chargingPeriodId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ChargingPeriods.UpdateSettingsChargingPeriodAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsChargingPeriodAsync(
        ExsitedClient client,
        string chargingPeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ChargingPeriods.UpdateSettingsChargingPeriodAsync(
            chargingPeriodId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
