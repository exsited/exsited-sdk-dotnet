using Exsited.Client;
using Exsited.Resources.DayOfMonth.DayOfMonthDto;

namespace Exsited.Resources.DayOfMonth;

/// <summary>The v4 day of month endpoints, as a typed resource bound to one client.</summary>
public sealed class DayOfMonth : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.DayOfMonth</c>.</summary>
    public DayOfMonth(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/day_of_month</c>.</summary>
    public Task<ApiResponse> GetSettingsDaysOfMonthAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DayOfMonthUrls.SettingsDaysOfMonth,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDayOfMonthList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/day_of_month/{day_of_month_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsDayOfMonthAsync(
        string dayOfMonthId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(DayOfMonthUrls.SettingsDayOfMonth,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["day_of_month_id"] = dayOfMonthId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsDayOfMonth),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.DayOfMonth.GetSettingsDaysOfMonthAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDaysOfMonthAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DayOfMonth.GetSettingsDaysOfMonthAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.DayOfMonth.GetSettingsDayOfMonthAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsDayOfMonthAsync(
        ExsitedClient client,
        string dayOfMonthId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.DayOfMonth.GetSettingsDayOfMonthAsync(
            dayOfMonthId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
