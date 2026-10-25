using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Timesheets.TimesheetsDto;

namespace Exsited.Resources.Timesheets;

/// <summary>The v4 timesheets endpoints, as a typed resource bound to one client.</summary>
public sealed class Timesheets : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Timesheets</c>.</summary>
    public Timesheets(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/timesheets</c>.</summary>
    public Task<ApiResponse> GetTimesheetsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TimesheetsUrls.Timesheets,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TimesheetList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/timesheets</c>.</summary>
    public Task<ApiResponse> CreateTimesheetAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(TimesheetsUrls.Timesheets,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TimesheetsView),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/timesheets/{timesheet_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteTimesheetAsync(
        string createdTimesheetId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TimesheetsUrls.Timesheet,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["timesheet_id"] = createdTimesheetId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/timesheets/{timesheet_id}</c>.</summary>
    public Task<ApiResponse> UpdateTimesheetAsync(
        string createdTimesheetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(TimesheetsUrls.Timesheet,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["timesheet_id"] = createdTimesheetId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TimesheetUpdated),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/timesheets/{timesheet_id}</c>.</summary>
    public Task<ApiResponse> GetTimesheetAsync(
        string timesheetId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TimesheetsUrls.Timesheet,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["timesheet_id"] = timesheetId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(TimesheetsView),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Timesheets.GetTimesheetsAsync</c>.</summary>
    public static Task<ApiResponse> GetTimesheetsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Timesheets.GetTimesheetsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Timesheets.CreateTimesheetAsync</c>.</summary>
    public static Task<ApiResponse> CreateTimesheetAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Timesheets.CreateTimesheetAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Timesheets.DeleteTimesheetAsync</c>.</summary>
    public static Task<ApiResponse> DeleteTimesheetAsync(
        ExsitedClient client,
        string createdTimesheetId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Timesheets.DeleteTimesheetAsync(
            createdTimesheetId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Timesheets.UpdateTimesheetAsync</c>.</summary>
    public static Task<ApiResponse> UpdateTimesheetAsync(
        ExsitedClient client,
        string createdTimesheetId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Timesheets.UpdateTimesheetAsync(
            createdTimesheetId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Timesheets.GetTimesheetAsync</c>.</summary>
    public static Task<ApiResponse> GetTimesheetAsync(
        ExsitedClient client,
        string timesheetId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Timesheets.GetTimesheetAsync(
            timesheetId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
