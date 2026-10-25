namespace Exsited.Resources.QuoteOrders;

/// <summary>Path templates and body keys for the v4 quote orders endpoints.</summary>
public static class QuoteOrdersUrls
{
    public const string QuoteOrderInvoices = "/api/{api_version}/quote_orders/{quote_order_id}/invoices";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
