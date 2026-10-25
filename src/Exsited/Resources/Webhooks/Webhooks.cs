using Exsited.Client;

namespace Exsited.Resources.Webhooks;

/// <summary>The v4 webhooks endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class Webhooks : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Webhooks</c>.</summary>
    public Webhooks(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/webhooks/{webhook_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetWebhookAsync(
        string webhookId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(WebhooksUrls.Webhook,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["webhook_id"] = webhookId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Webhooks.GetWebhookAsync</c>.</summary>
    public static Task<ApiResponse> GetWebhookAsync(
        ExsitedClient client,
        string webhookId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Webhooks.GetWebhookAsync(
            webhookId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
