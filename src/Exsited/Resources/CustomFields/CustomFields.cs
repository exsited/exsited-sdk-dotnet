using Exsited.Client;
using Exsited.Resources.CustomFields.CustomFieldsDto;

namespace Exsited.Resources.CustomFields;

/// <summary>The v4 custom fields endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomFields : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomFields</c>.</summary>
    public CustomFields(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_fields</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomFieldsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFieldsUrls.SettingsCustomFields,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomFieldList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/settings/custom_fields/{custom_field_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomFieldAsync(
        string customFieldId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFieldsUrls.SettingsCustomField,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_field_id"] = customFieldId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomField),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.CustomFields.GetSettingsCustomFieldsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomFieldsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFields.GetSettingsCustomFieldsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomFields.GetSettingsCustomFieldAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomFieldAsync(
        ExsitedClient client,
        string customFieldId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomFields.GetSettingsCustomFieldAsync(
            customFieldId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
