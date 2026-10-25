using Exsited.Client;
using Exsited.Errors;

namespace Exsited.Resources.Communications;

/// <summary>The v4 communications endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class Communications : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Communications</c>.</summary>
    public Communications(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/communications/send_email</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> SendEmailAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(CommunicationsUrls.CommunicationsSendEmail,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Communications.SendEmailAsync</c>.</summary>
    public static Task<ApiResponse> SendEmailAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Communications.SendEmailAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
