using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.CustomForms.CustomFormsDto;

namespace Exsited.Resources.CustomForms;

/// <summary>The v4 custom forms endpoints, as a typed resource bound to one client.</summary>
public sealed class CustomForms : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CustomForms</c>.</summary>
    public CustomForms(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_forms</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomFormsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFormsUrls.SettingsCustomForms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomFormList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/custom_forms</c>.</summary>
    public Task<ApiResponse> CreateSettingsCustomFormAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CustomFormsUrls.SettingsCustomForms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomForm),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/custom_forms/{custom_form_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsCustomFormAsync(
        string customFormId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CustomFormsUrls.SettingsCustomForm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_form_id"] = customFormId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomForm),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/custom_forms/{custom_form_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsCustomFormAsync(
        string customFormId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(CustomFormsUrls.SettingsCustomForm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_form_id"] = customFormId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/custom_forms/{custom_form_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsCustomFormAsync(
        string customFormId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(CustomFormsUrls.SettingsCustomForm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["custom_form_id"] = customFormId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsCustomForm),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.CustomForms.GetSettingsCustomFormsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomFormsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomForms.GetSettingsCustomFormsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomForms.CreateSettingsCustomFormAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsCustomFormAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomForms.CreateSettingsCustomFormAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomForms.GetSettingsCustomFormAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsCustomFormAsync(
        ExsitedClient client,
        string customFormId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomForms.GetSettingsCustomFormAsync(
            customFormId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomForms.DeleteSettingsCustomFormAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsCustomFormAsync(
        ExsitedClient client,
        string customFormId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomForms.DeleteSettingsCustomFormAsync(
            customFormId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CustomForms.UpdateSettingsCustomFormAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsCustomFormAsync(
        ExsitedClient client,
        string customFormId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CustomForms.UpdateSettingsCustomFormAsync(
            customFormId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
