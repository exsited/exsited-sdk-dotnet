using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.PurchaseExpress.PurchaseExpressDto;

namespace Exsited.Resources.PurchaseExpress;

/// <summary>The v4 purchase express endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseExpress : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseExpress</c>.</summary>
    public PurchaseExpress(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/purchase_express</c>.</summary>
    public Task<ApiResponse> CreatePurchaseExpressAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(PurchaseExpressUrls.PurchaseExpress,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseExpressView),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.PurchaseExpress.CreatePurchaseExpressAsync</c>.</summary>
    public static Task<ApiResponse> CreatePurchaseExpressAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseExpress.CreatePurchaseExpressAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
