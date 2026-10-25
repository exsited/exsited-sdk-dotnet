namespace Exsited.Resources.Reports;

/// <summary>Path templates and body keys for the v4 reports endpoints.</summary>
public static class ReportsUrls
{
    public const string ReportsAccountsAccountOverview = "/api/{api_version}/reports/accounts/account_overview";

    public const string ReportsInvoicesInvoiceOverview = "/api/{api_version}/reports/invoices/invoice_overview";

    public const string ReportsOrdersOrderOverview = "/api/{api_version}/reports/orders/order_overview";

    public const string ReportsPurchaseInvoicesPurchaseInvoiceOverview = "/api/{api_version}/reports/purchase_invoices/purchase_invoice_overview";

    public const string ReportsPurchaseOrdersPurchaseOrderOverview = "/api/{api_version}/reports/purchase_orders/purchase_order_overview";

    public const string ReportsPurchaseTransactionsPurchasePaymentAndRefundOverview = "/api/{api_version}/reports/purchase_transactions/purchase_payment_and_refund_overview";

    public const string ReportsTransactionsPaymentAndRefundOverview = "/api/{api_version}/reports/transactions/payment_and_refund_overview";

    /// <summary>The key one record arrives under, on the 7 endpoints its views were measured from.</summary>
    public const string ReportKey = "report";
}
