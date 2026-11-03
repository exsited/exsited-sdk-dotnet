namespace Exsited.Resources.Express.ExpressDto;

/// <summary>A typed view of the response body.</summary>
public sealed class ExpressView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/express",
    };

    protected override string? EnvelopeKey => "express";

    public Account? Account { get; set; }

    public IReadOnlyList<ActivityLog>? ActivityLogs { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? InvoiceNote { get; set; }

    public Kpis? Kpis { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<Line>? Lines { get; set; }

    /// <summary>Untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Untyped.</summary>
    public object? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>currency</c>.</summary>
public sealed class Currency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>time_zone</c>.</summary>
public sealed class TimeZone : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>billing_preferences</c>.</summary>
public sealed class BillingPreferences : Dto
{
    public string? BillingPeriod { get; set; }

    public string? CommunicationProfile { get; set; }

    public bool? ConsolidateInvoice { get; set; }

    public string? FulfillmentMode { get; set; }

    public string? FulfillmentTerm { get; set; }

    public string? InvoiceMode { get; set; }

    public string? InvoiceTerm { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? PaymentTerm { get; set; }

    public string? PaymentTermAlignment { get; set; }

    public ProformaProperties? ProformaProperties { get; set; }
}

/// <summary>One entry of a list sent as <c>lines</c>.</summary>
public sealed class Line : Dto
{
    public string? ChargeItemUuid { get; set; }

    public string? ExpectedDeliveryDate { get; set; }

    public string? Id { get; set; }

    public Item? Item { get; set; }

    public ItemAccountingCode? ItemAccountingCode { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<object?>? ItemCustomAttributes { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemInvoiceNote { get; set; }

    public long? ItemOrderQuantity { get; set; }

    public ItemPriceSnapshot? ItemPriceSnapshot { get; set; }

    public ItemPriceTax? ItemPriceTax { get; set; }

    public ItemSaleTaxConfiguration? ItemSaleTaxConfiguration { get; set; }

    public string? ItemType { get; set; }

    public string? Object { get; set; }

    public PreOrderStockDetails? PreOrderStockDetails { get; set; }

    public double? ShippingCost { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>kpis</c>.</summary>
public sealed class Kpis : Dto
{
    /// <summary>Untyped.</summary>
    public object? DeletedAt { get; set; }

    public string? EstimatedTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastCancelledAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastChangedAt { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastReactivatedAt { get; set; }

    public string? MonthlyRecurringRevenue { get; set; }

    /// <summary>Untyped.</summary>
    public object? NextInvoiceIssueDate { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? StartDate { get; set; }

    public string? TotalCollected { get; set; }

    public string? TotalDue { get; set; }

    public long? TotalInvoice { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalRevenue { get; set; }
}

/// <summary>One entry of a list sent as <c>activity_logs</c>.</summary>
public sealed class ActivityLog : Dto
{
    public string? Activity { get; set; }
}

/// <summary>An object sent as <c>proforma_properties</c>.</summary>
public sealed class ProformaProperties : Dto
{
    /// <summary>Untyped.</summary>
    public object? AcceptanceDate { get; set; }

    public bool? AcceptanceRequired { get; set; }

    /// <summary>Untyped.</summary>
    public object? AcceptanceTerm { get; set; }

    public bool? PaymentRequired { get; set; }

    /// <summary>Untyped.</summary>
    public object? TermsAndConditions { get; set; }
}

/// <summary>An object sent as <c>item</c>.</summary>
public sealed class Item : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>item_price_snapshot</c>.</summary>
public sealed class ItemPriceSnapshot : Dto
{
    public PricingRule? PricingRule { get; set; }
}

/// <summary>An object sent as <c>item_price_tax</c>.</summary>
public sealed class ItemPriceTax : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Rate { get; set; }
}

/// <summary>An object sent as <c>item_sale_tax_configuration</c>.</summary>
public sealed class ItemSaleTaxConfiguration : Dto
{
    public string? SalePriceIsBasedOn { get; set; }

    public TaxCode? TaxCode { get; set; }
}

/// <summary>An object sent as <c>item_accounting_code</c>.</summary>
public sealed class ItemAccountingCode : Dto
{
    public string? SalesRevenue { get; set; }
}

/// <summary>An object sent as <c>pre_order_stock_details</c>.</summary>
public sealed class PreOrderStockDetails : Dto
{
    public string? PendingReserve { get; set; }

    public string? Reserved { get; set; }

    public string? Sold { get; set; }
}

/// <summary>An object sent as <c>pricing_rule</c>.</summary>
public sealed class PricingRule : Dto
{
    public double? Price { get; set; }

    public string? PricePeriod { get; set; }

    public string? PriceType { get; set; }

    public string? PricingLevel { get; set; }

    public string? PricingMethod { get; set; }

    public string? PricingSchedule { get; set; }

    public string? Uom { get; set; }

    public string? Uuid { get; set; }

    public string? Version { get; set; }

    public string? Warehouse { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>.</summary>
public sealed class TaxCode : Dto
{
    public string? Code { get; set; }

    public string? Link { get; set; }

    public string? Rate { get; set; }

    public string? Uuid { get; set; }
}
