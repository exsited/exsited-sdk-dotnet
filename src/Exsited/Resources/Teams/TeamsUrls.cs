namespace Exsited.Resources.Teams;

/// <summary>Path templates and body keys for the v4 teams endpoints.</summary>
public static class TeamsUrls
{
    public const string SettingsTeams = "/api/{api_version}/settings/teams";

    public const string SettingsTeam = "/api/{api_version}/settings/teams/{team_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string TeamKey = "team";
}
