using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.TimePeriods.TimePeriodsDto;

namespace Exsited.Resources.TimePeriods;

/// <summary>The v4 time periods endpoints, as a typed resource bound to one client.</summary>
public sealed class TimePeriods : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.TimePeriods</c>.</summary>
    public TimePeriods(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/time_periods</c>.</summary>
    public Task<ApiResponse> GetSettingsTimePeriodsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TimePeriodsUrls.SettingsTimePeriods,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimePeriodList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/time_periods</c>.</summary>
    public Task<ApiResponse> CreateSettingsTimePeriodAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(TimePeriodsUrls.SettingsTimePeriods,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimePeriod),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/time_periods/{time_period_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsTimePeriodAsync(
        string timePeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TimePeriodsUrls.SettingsTimePeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["time_period_id"] = timePeriodId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimePeriod),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/time_periods/{time_period_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsTimePeriodAsync(
        string timePeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TimePeriodsUrls.SettingsTimePeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["time_period_id"] = timePeriodId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/time_periods/{time_period_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsTimePeriodAsync(
        string timePeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(TimePeriodsUrls.SettingsTimePeriod,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["time_period_id"] = timePeriodId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTimePeriod),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.TimePeriods.GetSettingsTimePeriodsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTimePeriodsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.TimePeriods.GetSettingsTimePeriodsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.TimePeriods.CreateSettingsTimePeriodAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsTimePeriodAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.TimePeriods.CreateSettingsTimePeriodAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.TimePeriods.GetSettingsTimePeriodAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTimePeriodAsync(
        ExsitedClient client,
        string timePeriodId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.TimePeriods.GetSettingsTimePeriodAsync(
            timePeriodId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.TimePeriods.DeleteSettingsTimePeriodAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsTimePeriodAsync(
        ExsitedClient client,
        string timePeriodId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.TimePeriods.DeleteSettingsTimePeriodAsync(
            timePeriodId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.TimePeriods.UpdateSettingsTimePeriodAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsTimePeriodAsync(
        ExsitedClient client,
        string timePeriodId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.TimePeriods.UpdateSettingsTimePeriodAsync(
            timePeriodId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
