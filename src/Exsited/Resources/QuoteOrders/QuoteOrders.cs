using Exsited.Client;
using Exsited.Resources.QuoteOrders.QuoteOrdersDto;

namespace Exsited.Resources.QuoteOrders;

/// <summary>The v4 quote orders endpoints, as a typed resource bound to one client.</summary>
public sealed class QuoteOrders : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.QuoteOrders</c>.</summary>
    public QuoteOrders(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/quote_orders/{quote_order_id}/invoices</c>.</summary>
    public Task<ApiResponse> GetQuoteOrderInvoicesAsync(
        string quoteOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(QuoteOrdersUrls.QuoteOrderInvoices,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["quote_order_id"] = quoteOrderId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(QuoteOrderInvoiceList),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.QuoteOrders.GetQuoteOrderInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetQuoteOrderInvoicesAsync(
        ExsitedClient client,
        string quoteOrderId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.QuoteOrders.GetQuoteOrderInvoicesAsync(
            quoteOrderId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
