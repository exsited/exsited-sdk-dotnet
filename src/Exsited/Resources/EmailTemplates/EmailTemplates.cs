using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.EmailTemplates.EmailTemplatesDto;

namespace Exsited.Resources.EmailTemplates;

/// <summary>The v4 email templates endpoints, as a typed resource bound to one client.</summary>
public sealed class EmailTemplates : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.EmailTemplates</c>.</summary>
    public EmailTemplates(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/email_templates</c>.</summary>
    public Task<ApiResponse> GetSettingsEmailTemplatesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EmailTemplatesUrls.SettingsEmailTemplates,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsEmailTemplateList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/email_templates</c>.</summary>
    public Task<ApiResponse> CreateSettingsEmailTemplateAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(EmailTemplatesUrls.SettingsEmailTemplates,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsEmailTemplate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/email_templates/{email_template_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsEmailTemplateAsync(
        string emailTemplateId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(EmailTemplatesUrls.SettingsEmailTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["email_template_id"] = emailTemplateId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsEmailTemplate),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/email_templates/{email_template_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsEmailTemplateAsync(
        string emailTemplateId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(EmailTemplatesUrls.SettingsEmailTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["email_template_id"] = emailTemplateId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/email_templates/{email_template_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsEmailTemplateAsync(
        string emailTemplateId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(EmailTemplatesUrls.SettingsEmailTemplate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["email_template_id"] = emailTemplateId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsEmailTemplate),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.EmailTemplates.GetSettingsEmailTemplatesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsEmailTemplatesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.EmailTemplates.GetSettingsEmailTemplatesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.EmailTemplates.CreateSettingsEmailTemplateAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsEmailTemplateAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.EmailTemplates.CreateSettingsEmailTemplateAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.EmailTemplates.GetSettingsEmailTemplateAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsEmailTemplateAsync(
        ExsitedClient client,
        string emailTemplateId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.EmailTemplates.GetSettingsEmailTemplateAsync(
            emailTemplateId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.EmailTemplates.DeleteSettingsEmailTemplateAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsEmailTemplateAsync(
        ExsitedClient client,
        string emailTemplateId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.EmailTemplates.DeleteSettingsEmailTemplateAsync(
            emailTemplateId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.EmailTemplates.UpdateSettingsEmailTemplateAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsEmailTemplateAsync(
        ExsitedClient client,
        string emailTemplateId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.EmailTemplates.UpdateSettingsEmailTemplateAsync(
            emailTemplateId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
