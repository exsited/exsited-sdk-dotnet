using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Teams.TeamsDto;

namespace Exsited.Resources.Teams;

/// <summary>The v4 teams endpoints, as a typed resource bound to one client.</summary>
public sealed class Teams : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Teams</c>.</summary>
    public Teams(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/teams</c>.</summary>
    public Task<ApiResponse> GetSettingsTeamsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TeamsUrls.SettingsTeams,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTeamList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/teams</c>.</summary>
    public Task<ApiResponse> CreateSettingsTeamAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(TeamsUrls.SettingsTeams,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTeam),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/teams/{team_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsTeamAsync(
        string teamId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(TeamsUrls.SettingsTeam,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["team_id"] = teamId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTeam),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/teams/{team_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsTeamAsync(
        string teamId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(TeamsUrls.SettingsTeam,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["team_id"] = teamId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/teams/{team_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsTeamAsync(
        string teamId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(TeamsUrls.SettingsTeam,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["team_id"] = teamId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsTeam),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Teams.GetSettingsTeamsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTeamsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Teams.GetSettingsTeamsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Teams.CreateSettingsTeamAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsTeamAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Teams.CreateSettingsTeamAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Teams.GetSettingsTeamAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsTeamAsync(
        ExsitedClient client,
        string teamId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Teams.GetSettingsTeamAsync(
            teamId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Teams.DeleteSettingsTeamAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsTeamAsync(
        ExsitedClient client,
        string teamId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Teams.DeleteSettingsTeamAsync(
            teamId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Teams.UpdateSettingsTeamAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsTeamAsync(
        ExsitedClient client,
        string teamId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Teams.UpdateSettingsTeamAsync(
            teamId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
