using Exsited.Client;
using Exsited.Resources.Reports.ReportsDto;

namespace Exsited.Resources.Reports;

/// <summary>The v4 reports endpoints, as a typed resource bound to one client.</summary>
public sealed class Reports : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Reports</c>.</summary>
    public Reports(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/reports/accounts/account_overview</c>.</summary>
    public Task<ApiResponse> GetReportsAccountsAccountOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsAccountsAccountOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsAccountsAccountOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/invoices/invoice_overview</c>.</summary>
    public Task<ApiResponse> GetReportsInvoicesInvoiceOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsInvoicesInvoiceOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsInvoicesInvoiceOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/orders/order_overview</c>.</summary>
    public Task<ApiResponse> GetReportsOrdersOrderOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsOrdersOrderOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsOrdersOrderOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/purchase_invoices/purchase_invoice_overview</c>.</summary>
    public Task<ApiResponse> GetReportsPurchaseInvoicesPurchaseInvoiceOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsPurchaseInvoicesPurchaseInvoiceOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsPurchaseInvoicesPurchaseInvoiceOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/purchase_orders/purchase_order_overview</c>.</summary>
    public Task<ApiResponse> GetReportsPurchaseOrdersPurchaseOrderOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsPurchaseOrdersPurchaseOrderOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsPurchaseOrdersPurchaseOrderOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/purchase_transactions/purchase_payment_and_refund_overview</c>.</summary>
    public Task<ApiResponse> GetReportsPurchaseTransactionsPurchasePaymentAndRefundOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsPurchaseTransactionsPurchasePaymentAndRefundOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsPurchaseTransactionsPurchasePaymentAndRefundOverview),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reports/transactions/payment_and_refund_overview</c>.</summary>
    public Task<ApiResponse> GetReportsTransactionsPaymentAndRefundOverviewAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReportsUrls.ReportsTransactionsPaymentAndRefundOverview,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(ReportsTransactionsPaymentAndRefundOverview),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Reports.GetReportsAccountsAccountOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsAccountsAccountOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsAccountsAccountOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsInvoicesInvoiceOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsInvoicesInvoiceOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsInvoicesInvoiceOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsOrdersOrderOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsOrdersOrderOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsOrdersOrderOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsPurchaseInvoicesPurchaseInvoiceOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsPurchaseInvoicesPurchaseInvoiceOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsPurchaseInvoicesPurchaseInvoiceOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsPurchaseOrdersPurchaseOrderOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsPurchaseOrdersPurchaseOrderOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsPurchaseOrdersPurchaseOrderOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsPurchaseTransactionsPurchasePaymentAndRefundOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsPurchaseTransactionsPurchasePaymentAndRefundOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsPurchaseTransactionsPurchasePaymentAndRefundOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reports.GetReportsTransactionsPaymentAndRefundOverviewAsync</c>.</summary>
    public static Task<ApiResponse> GetReportsTransactionsPaymentAndRefundOverviewAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reports.GetReportsTransactionsPaymentAndRefundOverviewAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);
}
