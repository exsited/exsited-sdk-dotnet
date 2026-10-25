namespace Exsited.Resources.ActionScripts;

/// <summary>Path templates and body keys for the v4 action scripts endpoints.</summary>
public static class ActionScriptsUrls
{
    public const string ActionScripts = "/api/{api_version}/action_scripts";

    public const string ActionScript = "/api/{api_version}/action_scripts/{action_script_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string ActionScriptKey = "action_script";
}
