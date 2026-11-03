namespace Exsited.Resources.UserSettings.UserSettingsDto;

/// <summary>A typed view of the response body: one user's settings.</summary>
public sealed class UserSettings : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/user_settings/{user_id}",
    };

    protected override string? EnvelopeKey => "user_settings";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public UserSettingsDashboard? Dashboard { get; set; }

    public UserSettingsDisplaySettings? DisplaySettings { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public UserSettingsProfile? Profile { get; set; }
}

/// <summary>A typed view of the response body: a user's profile image.</summary>
public sealed class UserSettingsProfileImage : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/user_settings/{user_id}/profile_image",
    };

    protected override string? EnvelopeKey => "user_settings";

    [WireName("base64")]
    public string? Base64 { get; set; }
}

/// <summary>An object sent as <c>profile</c>.</summary>
public sealed class UserSettingsProfile : Dto
{
    public string? DisplayName { get; set; }

    public string? Email { get; set; }

    public string? ImageLink { get; set; }

    public string? Name { get; set; }

    /// <summary>Untyped.</summary>
    public object? TimeZone { get; set; }
}

/// <summary>An object sent as <c>dashboard</c>.</summary>
public sealed class UserSettingsDashboard : Dto
{
    /// <summary>Untyped.</summary>
    public object? DefaultDashboard { get; set; }

    /// <summary>Entries are untyped.</summary>
    public IReadOnlyDictionary<string, object?>? EnabledDashboards { get; set; }

    public bool? UseDefault { get; set; }
}

/// <summary>An object sent as <c>display_settings</c>.</summary>
public sealed class UserSettingsDisplaySettings : Dto
{
    /// <summary>Entries are untyped.</summary>
    public IReadOnlyList<object?>? Modules { get; set; }

    public bool? UseDefault { get; set; }
}
