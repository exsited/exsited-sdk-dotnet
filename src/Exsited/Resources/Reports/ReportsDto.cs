namespace Exsited.Resources.Reports.ReportsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsAccountsAccountOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/accounts/account_overview",
    };

    protected override string? EnvelopeKey => "report";

    public IReadOnlyDictionary<string, object?>? Accounts { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsInvoicesInvoiceOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/invoices/invoice_overview",
    };

    protected override string? EnvelopeKey => "report";

    public Invoices? Invoices { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsOrdersOrderOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/orders/order_overview",
    };

    protected override string? EnvelopeKey => "report";

    public Orders? Orders { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsPurchaseInvoicesPurchaseInvoiceOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/purchase_invoices/purchase_invoice_overview",
    };

    protected override string? EnvelopeKey => "report";

    public PurchaseInvoices? PurchaseInvoices { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsPurchaseOrdersPurchaseOrderOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/purchase_orders/purchase_order_overview",
    };

    protected override string? EnvelopeKey => "report";

    public PurchaseOrders? PurchaseOrders { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsPurchaseTransactionsPurchasePaymentAndRefundOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/purchase_transactions/purchase_payment_and_refund_overview",
    };

    protected override string? EnvelopeKey => "report";

    public PurchasePaymentAndRefundOverview? PurchasePaymentAndRefundOverview { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReportsTransactionsPaymentAndRefundOverview : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/reports/transactions/payment_and_refund_overview",
    };

    protected override string? EnvelopeKey => "report";

    public PaymentAndRefundOverview? PaymentAndRefundOverview { get; set; }
}

/// <summary>An object sent as <c>invoices</c>, merged over every record measured.</summary>
public sealed class Invoices : Dto
{
    public IReadOnlyList<InvoiceOverview>? InvoiceOverview { get; set; }
}

/// <summary>An object sent as <c>orders</c>, merged over every record measured.</summary>
public sealed class Orders : Dto
{
    public IReadOnlyList<OrderOverview>? OrderOverview { get; set; }
}

/// <summary>An object sent as <c>purchase_invoices</c>, merged over every record measured.</summary>
public sealed class PurchaseInvoices : Dto
{
    public IReadOnlyList<PurchaseInvoiceOverview>? PurchaseInvoiceOverview { get; set; }
}

/// <summary>An object sent as <c>purchase_orders</c>, merged over every record measured.</summary>
public sealed class PurchaseOrders : Dto
{
    public IReadOnlyList<PurchaseOrderOverview>? PurchaseOrderOverview { get; set; }
}

/// <summary>An object sent as <c>purchase_payment_and_refund_overview</c>, merged over every record measured.</summary>
public sealed class PurchasePaymentAndRefundOverview : Dto
{
    public IReadOnlyList<PurchasePayment>? PurchasePayments { get; set; }

    public IReadOnlyList<PurchaseRefund>? PurchaseRefunds { get; set; }
}

/// <summary>An object sent as <c>payment_and_refund_overview</c>, merged over every record measured.</summary>
public sealed class PaymentAndRefundOverview : Dto
{
    public IReadOnlyList<Payment>? Payments { get; set; }

    public IReadOnlyList<Refund>? Refunds { get; set; }
}

/// <summary>One entry of a list sent as <c>invoice_overview</c>, merged over every record measured.</summary>
public sealed class InvoiceOverview : Dto
{
    public Amended? Amended { get; set; }

    public Cancelled? Cancelled { get; set; }

    public string? Date { get; set; }

    public string? InvoiceTotal { get; set; }

    public NetGain? NetGain { get; set; }

    public New? New { get; set; }

    public Reactivated? Reactivated { get; set; }

    public Voided? Voided { get; set; }
}

/// <summary>One entry of a list sent as <c>order_overview</c>, merged over every record measured.</summary>
public sealed class OrderOverview : Dto
{
    public Cancelled? Cancelled { get; set; }

    public Changed? Changed { get; set; }

    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public NetGain? NetGain { get; set; }

    public New? New { get; set; }

    public string? OrderTotal { get; set; }

    public Reactivated? Reactivated { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_invoice_overview</c>, merged over every record measured.</summary>
public sealed class PurchaseInvoiceOverview : Dto
{
    public Amended? Amended { get; set; }

    public Cancelled? Cancelled { get; set; }

    public string? Date { get; set; }

    public NetGain? NetGain { get; set; }

    public New? New { get; set; }

    public string? PurchaseInvoiceTotal { get; set; }

    public Reactivated? Reactivated { get; set; }

    public Voided? Voided { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_order_overview</c>, merged over every record measured.</summary>
public sealed class PurchaseOrderOverview : Dto
{
    public Cancelled? Cancelled { get; set; }

    public Changed? Changed { get; set; }

    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public NetPurchases? NetPurchases { get; set; }

    public New? New { get; set; }

    public string? PurchaseOrderTotal { get; set; }

    public Reactivated? Reactivated { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_payments</c>, merged over every record measured.</summary>
public sealed class PurchasePayment : Dto
{
    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public New? New { get; set; }

    public string? PurchasePaymentApplied { get; set; }
}

/// <summary>One entry of a list sent as <c>purchase_refunds</c>, merged over every record measured.</summary>
public sealed class PurchaseRefund : Dto
{
    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public New? New { get; set; }
}

/// <summary>One entry of a list sent as <c>payments</c>, merged over every record measured.</summary>
public sealed class Payment : Dto
{
    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public New? New { get; set; }

    public string? PaymentApplied { get; set; }
}

/// <summary>One entry of a list sent as <c>refunds</c>, merged over every record measured.</summary>
public sealed class Refund : Dto
{
    public string? Date { get; set; }

    public Deleted? Deleted { get; set; }

    public New? New { get; set; }
}

/// <summary>An object sent as <c>new</c>, merged over every record measured.</summary>
public sealed class New : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>cancelled</c>, merged over every record measured.</summary>
public sealed class Cancelled : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>reactivated</c>, merged over every record measured.</summary>
public sealed class Reactivated : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>voided</c>, merged over every record measured.</summary>
public sealed class Voided : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>amended</c>, merged over every record measured.</summary>
public sealed class Amended : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>net_gain</c>, merged over every record measured.</summary>
public sealed class NetGain : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>changed</c>, merged over every record measured.</summary>
public sealed class Changed : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>deleted</c>, merged over every record measured.</summary>
public sealed class Deleted : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}

/// <summary>An object sent as <c>net_purchases</c>, merged over every record measured.</summary>
public sealed class NetPurchases : Dto
{
    public string? Amount { get; set; }

    public string? Count { get; set; }
}
