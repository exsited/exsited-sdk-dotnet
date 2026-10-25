using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ShippingRules.ShippingRulesDto;

namespace Exsited.Resources.ShippingRules;

/// <summary>The v4 shipping rules endpoints, as a typed resource bound to one client.</summary>
public sealed class ShippingRules : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ShippingRules</c>.</summary>
    public ShippingRules(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/shipping_rules</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingRulesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ShippingRulesUrls.SettingsShippingRules,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingRuleList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/shipping_rules</c>.</summary>
    public Task<ApiResponse> CreateSettingsShippingRuleAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ShippingRulesUrls.SettingsShippingRules,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingRule),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/shipping_rules/{shipping_rule_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsShippingRuleAsync(
        string shippingRuleId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ShippingRulesUrls.SettingsShippingRule,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_rule_id"] = shippingRuleId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingRule),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/shipping_rules/{shipping_rule_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsShippingRuleAsync(
        string shippingRuleId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ShippingRulesUrls.SettingsShippingRule,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_rule_id"] = shippingRuleId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/shipping_rules/{shipping_rule_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsShippingRuleAsync(
        string shippingRuleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ShippingRulesUrls.SettingsShippingRule,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_rule_id"] = shippingRuleId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingRule),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/settings/shipping_rules/{shipping_rule_id}/configuration</c>.</summary>
    public Task<ApiResponse> CreateSettingsShippingRuleConfigurationAsync(
        string shippingRuleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ShippingRulesUrls.SettingsShippingRuleConfiguration,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["shipping_rule_id"] = shippingRuleId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsShippingRule),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ShippingRules.GetSettingsShippingRulesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingRulesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.GetSettingsShippingRulesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingRules.CreateSettingsShippingRuleAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsShippingRuleAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.CreateSettingsShippingRuleAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingRules.GetSettingsShippingRuleAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsShippingRuleAsync(
        ExsitedClient client,
        string shippingRuleId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.GetSettingsShippingRuleAsync(
            shippingRuleId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingRules.DeleteSettingsShippingRuleAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsShippingRuleAsync(
        ExsitedClient client,
        string shippingRuleId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.DeleteSettingsShippingRuleAsync(
            shippingRuleId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingRules.UpdateSettingsShippingRuleAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsShippingRuleAsync(
        ExsitedClient client,
        string shippingRuleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.UpdateSettingsShippingRuleAsync(
            shippingRuleId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ShippingRules.CreateSettingsShippingRuleConfigurationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsShippingRuleConfigurationAsync(
        ExsitedClient client,
        string shippingRuleId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ShippingRules.CreateSettingsShippingRuleConfigurationAsync(
            shippingRuleId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
