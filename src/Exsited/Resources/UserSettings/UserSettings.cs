using Exsited.Client;
using Exsited.Resources.UserSettings.UserSettingsDto;

namespace Exsited.Resources.UserSettings;

/// <summary>The v4 user settings endpoints, as a typed resource bound to one client.</summary>
public sealed class UserSettings : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.UserSettings</c>.</summary>
    public UserSettings(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/user_settings/{user_id}</c>; <c>userId</c> is the <c>usr_</c> id, which carries the same hex as the user's <c>op_</c> id.</summary>
    public Task<ApiResponse> GetUserSettingsAsync(
        string userId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UserSettingsUrls.UserSettings,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["user_id"] = userId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UserSettingsDto.UserSettings),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/user_settings/{user_id}/profile_image</c>; <c>base64</c> is the image without a data URI prefix, and empty when the read has none to serve.</summary>
    public Task<ApiResponse> GetUserSettingsProfileImageAsync(
        string userId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(UserSettingsUrls.UserSettingsProfileImage,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["user_id"] = userId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(UserSettingsProfileImage),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.UserSettings.GetUserSettingsAsync</c>.</summary>
    public static Task<ApiResponse> GetUserSettingsAsync(
        ExsitedClient client,
        string userId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.UserSettings.GetUserSettingsAsync(
            userId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.UserSettings.GetUserSettingsProfileImageAsync</c>.</summary>
    public static Task<ApiResponse> GetUserSettingsProfileImageAsync(
        ExsitedClient client,
        string userId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.UserSettings.GetUserSettingsProfileImageAsync(
            userId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
