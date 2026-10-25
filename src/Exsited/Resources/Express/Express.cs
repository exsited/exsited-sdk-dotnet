using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Express.ExpressDto;

namespace Exsited.Resources.Express;

/// <summary>The v4 express endpoints, as a typed resource bound to one client.</summary>
public sealed class Express : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Express</c>.</summary>
    public Express(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/express</c>.</summary>
    public Task<ApiResponse> CreateExpressAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ExpressUrls.Express,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ExpressView),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Express.CreateExpressAsync</c>.</summary>
    public static Task<ApiResponse> CreateExpressAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Express.CreateExpressAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
