namespace Exsited.Resources.UserSettings;

/// <summary>Path templates and body keys for the v4 user settings endpoints.</summary>
public static class UserSettingsUrls
{
    public const string UserSettings = "/api/{api_version}/user_settings/{user_id}";

    public const string UserSettingsProfileImage = "/api/{api_version}/user_settings/{user_id}/profile_image";

    /// <summary>The key one record arrives under.</summary>
    public const string UserSettingsKey = "user_settings";
}
