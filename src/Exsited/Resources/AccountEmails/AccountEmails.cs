using Exsited.Client;

namespace Exsited.Resources.AccountEmails;

/// <summary>The v4 account emails endpoints, as a typed resource bound to one client.</summary>
public sealed class AccountEmails : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AccountEmails</c>.</summary>
    public AccountEmails(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>DELETE /api/{api_version}/accounts/{account_id}/communications/emails/{email_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteAccountCommunicationsEmailAsync(
        string accountId, string emailUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountEmailsUrls.AccountCommunicationsEmail,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["account_id"] = accountId, ["email_uuid"] = emailUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.AccountEmails.DeleteAccountCommunicationsEmailAsync</c>.</summary>
    public static Task<ApiResponse> DeleteAccountCommunicationsEmailAsync(
        ExsitedClient client,
        string accountId, string emailUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountEmails.DeleteAccountCommunicationsEmailAsync(
            accountId, emailUuid, raiseOnError, cancellationToken, responseFormat);
}
