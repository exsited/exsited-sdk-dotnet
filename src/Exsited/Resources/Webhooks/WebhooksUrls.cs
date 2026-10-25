namespace Exsited.Resources.Webhooks;

/// <summary>Path templates and body keys for the v4 webhooks endpoints.</summary>
public static class WebhooksUrls
{
    public const string Webhook = "/api/{api_version}/webhooks/{webhook_id}";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string WebhookKey = "webhook";
}
