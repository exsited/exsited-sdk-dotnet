namespace Exsited.Resources.Settings.SettingsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsDiscountProfile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/discount_profiles",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DiscountType { get; set; }

    public string? DisplayName { get; set; }

    public string? EndTime { get; set; }

    public double? FixedAmount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? MaxUsePerAccount { get; set; }

    public long? MaxUsePerOrder { get; set; }

    public long? MaxUseTotal { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? OwnerType { get; set; }

    public double? PercentageAmount { get; set; }

    public bool? PriceIsInclusiveOfDiscount { get; set; }

    public long? Priority { get; set; }

    public bool? RedemptionRequired { get; set; }

    public bool? Stackable { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? TaxCode { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsDiscountProfile"/> records, under <c>data</c>.</summary>
public sealed class SettingsDiscountProfileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/discount_profiles",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsDiscountProfile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentProcessor : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_processors",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public double? ConversionRate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public bool? Disconnected { get; set; }

    public string? DisplayName { get; set; }

    public string? GatewayType { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IntegrationState { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsForeignCurrency { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Provider { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsPaymentProcessor"/> records, under <c>data</c>.</summary>
public sealed class SettingsPaymentProcessorList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_processors",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsPaymentProcessor>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsShippingProfile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_profiles",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public double? FixedAmount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? IntegrationConnection { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public double? SalesTaxRate { get; set; }

    public string? ShippingType { get; set; }

    public string? Status { get; set; }

    public bool? TaxExempt { get; set; }

    public IReadOnlyDictionary<string, object?>? TaxRule { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsShippingProfile"/> records, under <c>data</c>.</summary>
public sealed class SettingsShippingProfileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_profiles",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsShippingProfile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPricingLevel : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/pricing_levels",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BuiltInItem { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? IsDefault { get; set; }

    public bool? IsTaxInclusive { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Ordering { get; set; }

    public string? Status { get; set; }

    public TaxCode? TaxCode { get; set; }

    public bool? TaxExempt { get; set; }

    public string? TaxInclusiveBasedOn { get; set; }
}

/// <summary>One page of <see cref="SettingsPricingLevel"/> records, under <c>data</c>.</summary>
public sealed class SettingsPricingLevelList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/pricing_levels",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsPricingLevel>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsTimeZone : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/time_zones",
    };

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public bool? DstEnabled { get; set; }

    public long? Hour { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? Minute { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Offset { get; set; }

    public bool? Positive { get; set; }

    public string? Status { get; set; }

    public string? TimeZonePattern { get; set; }
}

/// <summary>One page of <see cref="SettingsTimeZone"/> records, under <c>data</c>.</summary>
public sealed class SettingsTimeZoneList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/time_zones",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsTimeZone>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsWarehouse : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/warehouses",
    };

    public string? City { get; set; }

    public IReadOnlyDictionary<string, object?>? Country { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsDefault { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? PostCode { get; set; }

    public string? State { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsWarehouse"/> records, under <c>data</c>.</summary>
public sealed class SettingsWarehouseList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/warehouses",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsWarehouse>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCurrency : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/currencies",
    };

    public double? CashRoundingInterval { get; set; }

    public string? Code { get; set; }

    public double? ConversionRate { get; set; }

    public IReadOnlyDictionary<string, object?>? Country { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public long? DecimalPlaces { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Rounding { get; set; }

    public string? Status { get; set; }

    public string? Symbol { get; set; }
}

/// <summary>One page of <see cref="SettingsCurrency"/> records, under <c>data</c>.</summary>
public sealed class SettingsCurrencyList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/currencies",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsCurrency>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsItemGroup : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/item_groups",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsItemGroup"/> records, under <c>data</c>.</summary>
public sealed class SettingsItemGroupList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/item_groups",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsItemGroup>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class CustomObject : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_objects",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? UseIn { get; set; }
}

/// <summary>One page of <see cref="CustomObject"/> records, under <c>data</c>.</summary>
public sealed class CustomObjectList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_objects",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<CustomObject>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsTax : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/taxes",
    };

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? Country { get; set; }

    public IReadOnlyList<object?>? CountryTaxByStates { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Rate { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsTax"/> records, under <c>data</c>.</summary>
public sealed class SettingsTaxList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/taxes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsTax>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsVariation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/variations",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsVariation"/> records, under <c>data</c>.</summary>
public sealed class SettingsVariationList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/variations",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsVariation>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentTerm : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_terms",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public IReadOnlyDictionary<string, object?>? Duration { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsPaymentTerm"/> records, under <c>data</c>.</summary>
public sealed class SettingsPaymentTermList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_terms",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsPaymentTerm>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsItemGroups : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/item_groups",
        "GET /api/{api_version}/settings/item_groups/{item_group_id}",
        "PATCH /api/{api_version}/settings/item_groups/{item_group_id}",
        "POST /api/{api_version}/settings/item_groups/{item_group_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "item_group";

    public AccountingCode? AccountingCode { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? Code { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? ImageUri { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomLogicScript : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}",
    };

    protected override string? EnvelopeKey => "custom_logic_script";

    public string? ActionName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? ObjectName { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }
}

/// <summary>The record the currency listing serves, unwrapped from <c>currency</c>.</summary>
public sealed class SettingsCurrencyRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/currencies/{currency_id}",
    };

    protected override string? EnvelopeKey => "currency";

    public double? CashRoundingInterval { get; set; }

    public string? Code { get; set; }

    public double? ConversionRate { get; set; }

    public IReadOnlyDictionary<string, object?>? Country { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public long? DecimalPlaces { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Rounding { get; set; }

    public string? Status { get; set; }

    public string? Symbol { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomObjectCustomize : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/custom_objects/{custom_object_id}/customize",
    };

    protected override string? EnvelopeKey => "custom_object";

    public IReadOnlyDictionary<string, object?>? Configuration { get; set; }

    public string? Created { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? Updated { get; set; }

    public string? UseIn { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomObjects : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/custom_objects/{custom_object_id}",
        "POST /api/{api_version}/settings/custom_objects",
        "PATCH /api/{api_version}/settings/custom_objects/{custom_object_id}",
    };

    protected override string? EnvelopeKey => "custom_object";

    public string? Created { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? Updated { get; set; }

    public string? UseIn { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsVariations : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/variations",
        "GET /api/{api_version}/settings/variations/{variation_id}",
        "PATCH /api/{api_version}/settings/variations/{variation_id}",
    };

    protected override string? EnvelopeKey => "variation";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Options { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>The record the time zone listing serves, unwrapped from <c>time_zone</c>; <c>Id</c> is its identifier.</summary>
public sealed class SettingsTimeZoneRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/time_zones/{time_zone_id}",
    };

    protected override string? EnvelopeKey => "time_zone";

    public string? Code { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public bool? DstEnabled { get; set; }

    public long? Hour { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? Minute { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Offset { get; set; }

    public bool? Positive { get; set; }

    public string? Status { get; set; }

    public string? TimeZonePattern { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomLogicScripts : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_logic_scripts",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings",
    };

    protected override string? EnvelopeKey => "settings";

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Resources { get; set; }
}

/// <summary>No endpoint names this view; the endpoints it was measured from answer <see cref="SettingsFieldSettingsAccountList"/> and <see cref="SettingsFieldSettingsItemList"/> and <see cref="SettingsGeneralSettingsAccount"/>.</summary>
public sealed class SettingsFieldSettingsItem : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/field_settings/account",
        "PATCH /api/{api_version}/settings/field_settings/item",
        "PATCH /api/{api_version}/settings/general_settings/account",
    };

    public string? Message { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsGeneralSettingsAccount : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/general_settings/account",
    };

    protected override string? EnvelopeKey => "general_settings";

    public Account? Account { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsGeneralSettingsItem : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/general_settings/item",
    };

    protected override string? EnvelopeKey => "general_settings";

    public Item? Item { get; set; }

    public Product? Product { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsFieldSettingsAccount : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/field_settings/account",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Editable { get; set; }

    public bool? Enabled { get; set; }

    public string? Entity { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public bool? GlobalSearch { get; set; }

    public string? GroupKey { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public bool? Mandatory { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Note { get; set; }

    public string? Object { get; set; }

    public long? SortOrder { get; set; }
}

/// <summary>One page of <see cref="SettingsFieldSettingsAccount"/> records, under <c>data</c>.</summary>
public sealed class SettingsFieldSettingsAccountList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/field_settings/account",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsFieldSettingsAccount>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsFieldSettingsItemRow : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/field_settings/item",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Editable { get; set; }

    public bool? Enabled { get; set; }

    public string? Entity { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public bool? GlobalSearch { get; set; }

    public string? GroupKey { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public bool? Mandatory { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Note { get; set; }

    public string? Object { get; set; }

    public long? SortOrder { get; set; }
}

/// <summary>One page of <see cref="SettingsFieldSettingsItemRow"/> records, under <c>data</c>.</summary>
public sealed class SettingsFieldSettingsItemList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/field_settings/item",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsFieldSettingsItemRow>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>accounting_code</c>, merged over every record measured.</summary>
public sealed class AccountingCode : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class Account : Dto
{
    public AccountGrouping? AccountGrouping { get; set; }

    public AccountManagement? AccountManagement { get; set; }

    public AdditionalContact1? AdditionalContact1 { get; set; }

    public AdditionalContact2? AdditionalContact2 { get; set; }

    public AdditionalContact3? AdditionalContact3 { get; set; }

    public BillingContact? BillingContact { get; set; }

    public CreationOfSubsidiaryAccount? CreationOfSubsidiaryAccount { get; set; }

    public string? EnableWorkflowApprovalForAccount { get; set; }

    public ReferralTrackingAtAccountLevel? ReferralTrackingAtAccountLevel { get; set; }

    public string? RequireEmailAddressForAccount { get; set; }

    public string? RequireNameToBeUnique { get; set; }

    public SalesRepTrackingAtAccountLevel? SalesRepTrackingAtAccountLevel { get; set; }

    public string? SendCommunicationAsGroups { get; set; }

    public ShippingContact? ShippingContact { get; set; }

    public string? UniqueEmailAddressForAccount { get; set; }

    public string? UniqueEmailAddressForContacts { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class Item : Dto
{
    public AvailableChargeTypes? AvailableChargeTypes { get; set; }

    public AvailablePricingMethods? AvailablePricingMethods { get; set; }

    public string? ChargingPeriodCanVaryFromBillingPeriod { get; set; }

    public string? ChargingStartDateCanVaryFromBillingStartDate { get; set; }

    public string? EnableBackOrder { get; set; }

    public string? EnableBatchTracking { get; set; }

    public string? EnableBundleItem { get; set; }

    public string? EnableDirectCostItem { get; set; }

    public string? EnableFamilyCostItem { get; set; }

    public string? EnableFixedAssetItem { get; set; }

    public string? EnableGiftCertificateBasedItem { get; set; }

    public string? EnableInventoryCosting { get; set; }

    public string? EnableInventoryManagement { get; set; }

    public string? EnablePricingProfile { get; set; }

    public string? EnablePurchase { get; set; }

    public string? EnableSales { get; set; }

    public string? EnableSerialization { get; set; }

    public string? EnableSupplierManagement { get; set; }

    public string? EnableVariation { get; set; }

    public string? EnableVariationBasedItem { get; set; }

    public string? EnableWarehouseManagement { get; set; }

    public string? EnableWorkflowApprovalForItem { get; set; }

    public InventoryAdjustmentRules? InventoryAdjustmentRules { get; set; }

    public ItemGrouping? ItemGrouping { get; set; }

    public ItemManagement? ItemManagement { get; set; }

    public PreOrder? PreOrder { get; set; }

    public PricingPeriodCanVaryFromChargingPeriod? PricingPeriodCanVaryFromChargingPeriod { get; set; }

    public PurchasePriceEnteredIsInclusiveOfTax? PurchasePriceEnteredIsInclusiveOfTax { get; set; }

    public string? RequireNameToBeUnique { get; set; }

    public SalePriceEnteredIsInclusiveOfTax? SalePriceEnteredIsInclusiveOfTax { get; set; }

    public string? UseOnSalePrice { get; set; }

    public string? UsePricingLevel { get; set; }

    public string? UseSchedulingOfFuturePricing { get; set; }

    public string? UseShippingProfile { get; set; }

    public UseVolumePricing? UseVolumePricing { get; set; }
}

/// <summary>An object sent as <c>product</c>, merged over every record measured.</summary>
public sealed class Product : Dto
{
    public string? AllowItemSellMultiQuantity { get; set; }

    public string? AllowPlanSellMultiQuantity { get; set; }

    public string? AllowProductSellMultiQuantity { get; set; }

    public string? AllowRateSellMultiQuantity { get; set; }

    public string? ItemQuantityUse { get; set; }

    public string? PlanQuantityUse { get; set; }

    public string? ProductQuantityUse { get; set; }

    public string? RateQuantityUse { get; set; }
}

/// <summary>An object sent as <c>account_grouping</c>, merged over every record measured.</summary>
public sealed class AccountGrouping : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>creation_of_subsidiary_account</c>, merged over every record measured.</summary>
public sealed class CreationOfSubsidiaryAccount : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>account_management</c>, merged over every record measured.</summary>
public sealed class AccountManagement : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultManager { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>sales_rep_tracking_at_account_level</c>, merged over every record measured.</summary>
public sealed class SalesRepTrackingAtAccountLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultSalesRepTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>referral_tracking_at_account_level</c>, merged over every record measured.</summary>
public sealed class ReferralTrackingAtAccountLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultReferralTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>billing_contact</c>, merged over every record measured.</summary>
public sealed class BillingContact : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForBillingContact { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>shipping_contact</c>, merged over every record measured.</summary>
public sealed class ShippingContact : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForShippingContact { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_1</c>, merged over every record measured.</summary>
public sealed class AdditionalContact1 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact1 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_2</c>, merged over every record measured.</summary>
public sealed class AdditionalContact2 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact2 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_3</c>, merged over every record measured.</summary>
public sealed class AdditionalContact3 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact3 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>available_charge_types</c>, merged over every record measured.</summary>
public sealed class AvailableChargeTypes : Dto
{
    public string? Metered { get; set; }

    public string? OneOff { get; set; }

    public string? Recurring { get; set; }
}

/// <summary>An object sent as <c>available_pricing_methods</c>, merged over every record measured.</summary>
public sealed class AvailablePricingMethods : Dto
{
    public string? DiscountBased { get; set; }

    public string? MarkupBased { get; set; }

    public string? Standard { get; set; }
}

/// <summary>An object sent as <c>item_grouping</c>, merged over every record measured.</summary>
public sealed class ItemGrouping : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>item_management</c>, merged over every record measured.</summary>
public sealed class ItemManagement : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultManager { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>use_volume_pricing</c>, merged over every record measured.</summary>
public sealed class UseVolumePricing : Dto
{
    public string? AllUnitsFixedPricing { get; set; }

    public string? AllUnitsPerUnitPricing { get; set; }

    public string? Enabled { get; set; }

    public string? IncrementalFixedPricing { get; set; }

    public string? IncrementalPerUnitPricing { get; set; }
}

/// <summary>An object sent as <c>pricing_period_can_vary_from_charging_period</c>, merged over every record measured.</summary>
public sealed class PricingPeriodCanVaryFromChargingPeriod : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultPricingPeriod { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>sale_price_entered_is_inclusive_of_tax</c>, merged over every record measured.</summary>
public sealed class SalePriceEnteredIsInclusiveOfTax : Dto
{
    public string? Enabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    public string? TaxIncludedInSalesPriceIsBasedOn { get; set; }
}

/// <summary>An object sent as <c>purchase_price_entered_is_inclusive_of_tax</c>, merged over every record measured.</summary>
public sealed class PurchasePriceEnteredIsInclusiveOfTax : Dto
{
    public string? Enabled { get; set; }

    public Tax? Tax { get; set; }
}

/// <summary>An object sent as <c>inventory_adjustment_rules</c>, merged over every record measured.</summary>
public sealed class InventoryAdjustmentRules : Dto
{
    public string? QuantityAvailableForSale { get; set; }

    public string? QuantityAvailableForSaleDetermination { get; set; }
}

/// <summary>An object sent as <c>pre_order</c>, merged over every record measured.</summary>
public sealed class PreOrder : Dto
{
    public string? Enabled { get; set; }

    public string? NumberOfPeriod { get; set; }

    public string? Period { get; set; }
}

/// <summary>An object sent as <c>tax</c>, merged over every record measured.</summary>
public sealed class Tax : Dto
{
    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>, merged over every record measured.</summary>
public sealed class TaxCode : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemData : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Editable { get; set; }

    public bool? Enabled { get; set; }

    public string? Entity { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public bool? GlobalSearch { get; set; }

    public string? GroupKey { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public bool? Mandatory { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Note { get; set; }

    public string? Object { get; set; }

    public long? SortOrder { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetail : Dto
{
    public SettingsGeneralSettingsItemUpdatedDetailAvailableChargeTypes? AvailableChargeTypes { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailAvailablePricingMethods? AvailablePricingMethods { get; set; }

    public string? ChargingPeriodCanVaryFromBillingPeriod { get; set; }

    public string? ChargingStartDateCanVaryFromBillingStartDate { get; set; }

    public string? EnableBackOrder { get; set; }

    public string? EnableBatchTracking { get; set; }

    public string? EnableBundleItem { get; set; }

    public string? EnableDirectCostItem { get; set; }

    public string? EnableFamilyCostItem { get; set; }

    public string? EnableFixedAssetItem { get; set; }

    public string? EnableGiftCertificateBasedItem { get; set; }

    public string? EnableInventoryCosting { get; set; }

    public string? EnableInventoryManagement { get; set; }

    public string? EnablePricingProfile { get; set; }

    public string? EnablePurchase { get; set; }

    public string? EnableSales { get; set; }

    public string? EnableSerialization { get; set; }

    public string? EnableSupplierManagement { get; set; }

    public string? EnableVariation { get; set; }

    public string? EnableVariationBasedItem { get; set; }

    public string? EnableWarehouseManagement { get; set; }

    public string? EnableWorkflowApprovalForItem { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailInventoryAdjustmentRules? InventoryAdjustmentRules { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailItemGrouping? ItemGrouping { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailItemManagement? ItemManagement { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailPreOrder? PreOrder { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailPricingPeriodCanVaryFromChargingPeriod? PricingPeriodCanVaryFromChargingPeriod { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailPurchasePriceEnteredIsInclusiveOfTax? PurchasePriceEnteredIsInclusiveOfTax { get; set; }

    public string? RequireNameToBeUnique { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailSalePriceEnteredIsInclusiveOfTax? SalePriceEnteredIsInclusiveOfTax { get; set; }

    public string? UseOnSalePrice { get; set; }

    public string? UsePricingLevel { get; set; }

    public string? UseSchedulingOfFuturePricing { get; set; }

    public string? UseShippingProfile { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailUseVolumePricing? UseVolumePricing { get; set; }
}

/// <summary>An object sent as <c>product</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedProduct : Dto
{
    public string? AllowItemSellMultiQuantity { get; set; }

    public string? AllowPlanSellMultiQuantity { get; set; }

    public string? AllowProductSellMultiQuantity { get; set; }

    public string? AllowRateSellMultiQuantity { get; set; }

    public string? ItemQuantityUse { get; set; }

    public string? PlanQuantityUse { get; set; }

    public string? ProductQuantityUse { get; set; }

    public string? RateQuantityUse { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccount : Dto
{
    public SettingsFieldSettingsItemGeneralSettingsAccountAccountGrouping? AccountGrouping { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountAccountManagement? AccountManagement { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact1? AdditionalContact1 { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact2? AdditionalContact2 { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact3? AdditionalContact3 { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountBillingContact? BillingContact { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountCreationOfSubsidiaryAccount? CreationOfSubsidiaryAccount { get; set; }

    public string? EnableWorkflowApprovalForAccount { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountReferralTrackingAtAccountLevel? ReferralTrackingAtAccountLevel { get; set; }

    public string? RequireEmailAddressForAccount { get; set; }

    public string? RequireNameToBeUnique { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountSalesRepTrackingAtAccountLevel? SalesRepTrackingAtAccountLevel { get; set; }

    public string? SendCommunicationAsGroups { get; set; }

    public SettingsFieldSettingsItemGeneralSettingsAccountShippingContact? ShippingContact { get; set; }

    public string? UniqueEmailAddressForAccount { get; set; }

    public string? UniqueEmailAddressForContacts { get; set; }
}

/// <summary>An object sent as <c>available_charge_types</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailAvailableChargeTypes : Dto
{
    public string? Metered { get; set; }

    public string? OneOff { get; set; }

    public string? Recurring { get; set; }
}

/// <summary>An object sent as <c>available_pricing_methods</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailAvailablePricingMethods : Dto
{
    public string? DiscountBased { get; set; }

    public string? MarkupBased { get; set; }

    public string? Standard { get; set; }
}

/// <summary>An object sent as <c>item_grouping</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailItemGrouping : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>item_management</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailItemManagement : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultManager { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>use_volume_pricing</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailUseVolumePricing : Dto
{
    public string? AllUnitsFixedPricing { get; set; }

    public string? AllUnitsPerUnitPricing { get; set; }

    public string? Enabled { get; set; }

    public string? IncrementalFixedPricing { get; set; }

    public string? IncrementalPerUnitPricing { get; set; }
}

/// <summary>An object sent as <c>pricing_period_can_vary_from_charging_period</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailPricingPeriodCanVaryFromChargingPeriod : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultPricingPeriod { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>sale_price_entered_is_inclusive_of_tax</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailSalePriceEnteredIsInclusiveOfTax : Dto
{
    public string? Enabled { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    public string? TaxIncludedInSalesPriceIsBasedOn { get; set; }
}

/// <summary>An object sent as <c>purchase_price_entered_is_inclusive_of_tax</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailPurchasePriceEnteredIsInclusiveOfTax : Dto
{
    public string? Enabled { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetailPurchasePriceEnteredIsInclusiveOfTaxDetail? Tax { get; set; }
}

/// <summary>An object sent as <c>inventory_adjustment_rules</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailInventoryAdjustmentRules : Dto
{
    public string? QuantityAvailableForSale { get; set; }

    public string? QuantityAvailableForSaleDetermination { get; set; }
}

/// <summary>An object sent as <c>pre_order</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailPreOrder : Dto
{
    public string? Enabled { get; set; }

    public string? NumberOfPeriod { get; set; }

    public string? Period { get; set; }
}

/// <summary>An object sent as <c>account_grouping</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountAccountGrouping : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>creation_of_subsidiary_account</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountCreationOfSubsidiaryAccount : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultGroup { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>account_management</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountAccountManagement : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultManager { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>sales_rep_tracking_at_account_level</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountSalesRepTrackingAtAccountLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultSalesRepTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>referral_tracking_at_account_level</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountReferralTrackingAtAccountLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultReferralTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>billing_contact</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountBillingContact : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForBillingContact { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>shipping_contact</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountShippingContact : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForShippingContact { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_1</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact1 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact1 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_2</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact2 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact2 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>additional_contact_3</c>, merged over every record measured.</summary>
public sealed class SettingsFieldSettingsItemGeneralSettingsAccountAdditionalContact3 : Dto
{
    public string? DisplayName { get; set; }

    public string? Enabled { get; set; }

    public string? RequireEmailAddressForAdditionalContact3 { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>tax</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsItemUpdatedDetailPurchasePriceEnteredIsInclusiveOfTaxDetail : Dto
{
    public string? Uuid { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomObjectDefinition : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_objects",
        "GET /api/{api_version}/settings/custom_objects/{custom_object_id}",
    };

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Relation { get; set; }

    public string? Status { get; set; }

    public string? UseIn { get; set; }
}

/// <summary>One page of <see cref="SettingsCustomObjectDefinition"/> records, under <c>data</c>.</summary>
public sealed class SettingsCustomObjectDefinitionList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_objects",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsCustomObjectDefinition>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomObjectDefinitionRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_objects/{custom_object_id}",
    };

    protected override string? EnvelopeKey => "custom_object";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsDiscountProfileRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/discount_profiles/{discount_profile_id}",
        "POST /api/{api_version}/settings/discount_profiles",
        "PATCH /api/{api_version}/settings/discount_profiles/{discount_profile_id}",
    };

    protected override string? EnvelopeKey => "discount_profile";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentProcessorRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_processors/{payment_processor_id}",
    };

    protected override string? EnvelopeKey => "payment_processor";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentTermRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/payment_terms/{payment_term_id}",
    };

    protected override string? EnvelopeKey => "payment_term";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPricingLevelRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/pricing_levels/{pricing_level_id}",
        "PATCH /api/{api_version}/settings/pricing_levels/{pricing_level_id}",
    };

    protected override string? EnvelopeKey => "pricing_level";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsShippingProfileRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_profiles/{shipping_profile_id}",
        "POST /api/{api_version}/settings/shipping_profiles",
    };

    protected override string? EnvelopeKey => "shipping_profile";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsTaxRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/taxes/{tax_id}",
    };

    protected override string? EnvelopeKey => "tax";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsWarehouseRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/warehouses/{warehouse_id}",
        "POST /api/{api_version}/settings/warehouses",
        "PATCH /api/{api_version}/settings/warehouses/{warehouse_id}",
    };

    protected override string? EnvelopeKey => "warehouse";
}

/// <summary>One page of <see cref="SettingsFieldSettingsItemData"/> records, under <c>data</c>.</summary>
public sealed class SettingsFieldSettingList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/field_settings",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsFieldSettingsItemData>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsFieldSettingRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/field_settings/{field_setting_id}",
    };

    protected override string? EnvelopeKey => "field_setting";
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsCustomLogicScriptSaved : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/custom_logic_scripts",
        "PATCH /api/{api_version}/settings/custom_logic_scripts/{custom_logic_script_id}",
    };

    protected override string? EnvelopeKey => "custom_logic_script";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Code { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentTermUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/settings/payment_terms/{payment_term_id}",
    };

    protected override string? EnvelopeKey => "payment_term";

    public long? DisplayOrder { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentProcessorSaved : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/payment_processors",
        "PATCH /api/{api_version}/settings/payment_processors/{payment_processor_id}",
    };

    protected override string? EnvelopeKey => "payment_processor";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public double? ConversionRate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Credentials { get; set; }

    public SettingsPaymentProcessorSavedCurrency? Currency { get; set; }

    public string? Description { get; set; }

    public bool? Disconnected { get; set; }

    public string? DisplayName { get; set; }

    public string? GatewayName { get; set; }

    public string? GatewayType { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? IntegrationState { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsForeignCurrency { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Provider { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class SettingsPaymentProcessorSavedCurrency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPaymentTermCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/payment_terms",
    };

    protected override string? EnvelopeKey => "payment_term";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public long? Duration { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Ordering { get; set; }

    public string? Period { get; set; }

    public string? Status { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsPricingLevelCreated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/settings/pricing_levels",
    };

    protected override string? EnvelopeKey => "pricing_level";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BuiltInItem { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? IsDefault { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public long? Ordering { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxExempt { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsGeneralSettings : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/general_settings/{group}",
    };

    protected override string? EnvelopeKey => "general_settings";

    public SettingsFieldSettingsItemGeneralSettingsAccount? Account { get; set; }

    public SettingsGeneralSettingsDashboard? Dashboard { get; set; }

    public SettingsGeneralSettingsDateAndTime? DateAndTime { get; set; }

    /// <summary>Keys are the instance's own setting names, so a mapping.</summary>
    public IReadOnlyDictionary<string, object?>? Display { get; set; }

    /// <summary>Keys are the instance's own setting names, so a mapping.</summary>
    public IReadOnlyDictionary<string, object?>? General { get; set; }

    public SettingsGeneralSettingsItemUpdatedDetail? Item { get; set; }

    public SettingsGeneralSettingsLabour? Labour { get; set; }

    public SettingsGeneralSettingsOrder? Order { get; set; }

    public SettingsGeneralSettingsPortal? Portal { get; set; }

    public SettingsGeneralSettingsItemUpdatedProduct? Product { get; set; }

    public SettingsGeneralSettingsPurchase? Purchase { get; set; }

    public SettingsGeneralSettingsSecurity? Security { get; set; }

    public SettingsGeneralSettingsTransaction? Transaction { get; set; }
}

/// <summary>An object sent as <c>dashboard</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsDashboard : Dto
{
    public string? Accounting { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("defaultDashboard")]
    public object? DefaultDashboard { get; set; }

    public string? Executive { get; set; }

    public string? Finance { get; set; }

    public string? Production { get; set; }

    public string? Purchase { get; set; }

    public string? Sales { get; set; }
}

/// <summary>An object sent as <c>date_and_time</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsDateAndTime : Dto
{
    public string? DateFormat { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? FirstDayOfWeek { get; set; }

    public string? TimeFormat { get; set; }

    public string? TimeZone { get; set; }
}

/// <summary>An object sent as <c>labour</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsLabour : Dto
{
    public string? RequireEmailAddressForLabour { get; set; }

    public string? UniqueEmailAddress { get; set; }

    public string? UniqueLabourName { get; set; }
}

/// <summary>An object sent as <c>order</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsOrder : Dto
{
    public string? AllowNameToBeChangedInOrder { get; set; }

    public string? AllowUnitPriceToBeChangedInOrder { get; set; }

    public string? DefaultFulfillmentStatus { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultShippingProfile { get; set; }

    public string? DisplayedPriceIsInclusiveOfTax { get; set; }

    public string? EnableBooking { get; set; }

    public string? EnableLastSalePriceLookUpForAnAccount { get; set; }

    public string? EnableOrderBackdating { get; set; }

    public string? EnableQuote { get; set; }

    public SettingsGeneralSettingsOrderOrderManagement? OrderManagement { get; set; }

    public SettingsGeneralSettingsOrderReferralTrackingAtOrderLevel? ReferralTrackingAtOrderLevel { get; set; }

    public SettingsGeneralSettingsOrderSalesRepTrackingAtOrderLevel? SalesRepTrackingAtOrderLevel { get; set; }

    public string? UseGlobalWarehouse { get; set; }
}

/// <summary>An object sent as <c>order_management</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsOrderOrderManagement : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultManager { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>referral_tracking_at_order_level</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsOrderReferralTrackingAtOrderLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultReferralTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>sales_rep_tracking_at_order_level</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsOrderSalesRepTrackingAtOrderLevel : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultSalesRepTracking { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>portal</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPortal : Dto
{
    /// <summary>Keys are the instance's own setting names, so a mapping.</summary>
    public IReadOnlyDictionary<string, object?>? Contacts { get; set; }

    [WireName("enableCustomerPortal")]
    public string? EnableCustomerPortal { get; set; }

    [WireName("enableInviteToActivePortalForContact")]
    public string? EnableInviteToActivePortalForContact { get; set; }

    [WireName("enableSpecifyPortalPasswordForContact")]
    public string? EnableSpecifyPortalPasswordForContact { get; set; }

    /// <summary>Keys are the instance's own setting names, so a mapping.</summary>
    public IReadOnlyDictionary<string, object?>? Settings { get; set; }
}

/// <summary>An object sent as <c>purchase</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPurchase : Dto
{
    public SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseCreditNoteFields? AllowModificationOfFollowingPurchaseCreditNoteFields { get; set; }

    public SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseInvoiceFields? AllowModificationOfFollowingPurchaseInvoiceFields { get; set; }

    public SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchasePaymentFields? AllowModificationOfFollowingPurchasePaymentFields { get; set; }

    public SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseRefundFields? AllowModificationOfFollowingPurchaseRefundFields { get; set; }

    public string? EnableLastPurchasePriceLookUp { get; set; }

    public string? EnablePurchaseQuote { get; set; }

    public string? EnableWorkflowApprovalForPurchaseCreditNote { get; set; }

    public string? EnableWorkflowApprovalForPurchaseInvoice { get; set; }

    public string? EnableWorkflowApprovalForPurchaseOrder { get; set; }

    public string? EnableWorkflowApprovalForPurchasePayment { get; set; }

    public string? EnableWorkflowApprovalForPurchaseRefund { get; set; }

    public string? InventoryIsAdjustedWhen { get; set; }

    public string? SupplierInvoiceIdShouldBeUnique { get; set; }

    public string? UseGlobalWarehouse { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_purchase_credit_note_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseCreditNoteFields : Dto
{
    public string? Refundable { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_purchase_invoice_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseInvoiceFields : Dto
{
    public string? DueDate { get; set; }

    public string? IssueDate { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_purchase_payment_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchasePaymentFields : Dto
{
    public string? PaymentDate { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? PaymentReference { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_purchase_refund_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsPurchaseAllowModificationOfFollowingPurchaseRefundFields : Dto
{
    public string? RefundDate { get; set; }

    public string? RefundReference { get; set; }
}

/// <summary>An object sent as <c>security</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsSecurity : Dto
{
    public string? EnableForceSessionExpire { get; set; }

    public string? EnableTwoFactorAuthentication { get; set; }

    [WireName("implementerLogin")]
    public string? ImplementerLogin { get; set; }

    public string? SessionExpireLimitHour { get; set; }
}

/// <summary>An object sent as <c>transaction</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransaction : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingMethod { get; set; }

    public SettingsGeneralSettingsTransactionAllowModificationOfFollowingCreditNoteFields? AllowModificationOfFollowingCreditNoteFields { get; set; }

    public SettingsGeneralSettingsTransactionAllowModificationOfFollowingInvoiceFields? AllowModificationOfFollowingInvoiceFields { get; set; }

    public SettingsGeneralSettingsTransactionAllowModificationOfFollowingPaymentFields? AllowModificationOfFollowingPaymentFields { get; set; }

    public SettingsGeneralSettingsTransactionAllowModificationOfFollowingRefundFields? AllowModificationOfFollowingRefundFields { get; set; }

    public SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreference? AvailableMediumsForCommunicationPreference { get; set; }

    public string? CreateNegativeChargeToAccommodateAdjustmentRequiredForOrderCancelOrChange { get; set; }

    public SettingsGeneralSettingsTransactionDefaultAccountingCodes? DefaultAccountingCodes { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DefaultShippingProfile { get; set; }

    public string? DisableNotificationForInvoiceWithChargesOfZeroAmount { get; set; }

    public string? DisplayedPriceIsInclusiveOfTax { get; set; }

    public string? EnableCreationOfAutomaticPaymentSurcharge { get; set; }

    public string? EnableDiscountProfile { get; set; }

    public string? UpdateCurrentInvoiceToIncludeChargeAdjustments { get; set; }

    public string? UpdateInvoiceToIncludeCurrentPaymentSurcharge { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_credit_note_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAllowModificationOfFollowingCreditNoteFields : Dto
{
    public string? CreditNoteDate { get; set; }

    public string? Refundable { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_invoice_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAllowModificationOfFollowingInvoiceFields : Dto
{
    public string? BillingPeriod { get; set; }

    public string? ChargePeriod { get; set; }

    public string? DueDate { get; set; }

    public string? IssueDate { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_payment_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAllowModificationOfFollowingPaymentFields : Dto
{
    public string? PaymentDate { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? PaymentReference { get; set; }
}

/// <summary>An object sent as <c>allow_modification_of_following_refund_fields</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAllowModificationOfFollowingRefundFields : Dto
{
    public string? RefundDate { get; set; }

    public string? RefundReference { get; set; }
}

/// <summary>An object sent as <c>available_mediums_for_communication_preference</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreference : Dto
{
    public SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceEmail? Email { get; set; }

    public SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferencePostalMail? PostalMail { get; set; }

    public SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceTextMessage? TextMessage { get; set; }

    public SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceVoiceMail? VoiceMail { get; set; }
}

/// <summary>An object sent as <c>email</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceEmail : Dto
{
    public string? Default { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>postal_mail</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferencePostalMail : Dto
{
    public string? Default { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>text_message</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceTextMessage : Dto
{
    public string? Default { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>voice_mail</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionAvailableMediumsForCommunicationPreferenceVoiceMail : Dto
{
    public string? Default { get; set; }

    public string? Enabled { get; set; }
}

/// <summary>An object sent as <c>default_accounting_codes</c>, merged over every record measured.</summary>
public sealed class SettingsGeneralSettingsTransactionDefaultAccountingCodes : Dto
{
    public string? AccountPayable { get; set; }

    public string? AccountReceivable { get; set; }

    public string? CashAndCashEquivalent { get; set; }

    public string? CostOfGoodsSold { get; set; }

    public string? CreditNotePayable { get; set; }

    public string? Deduction { get; set; }

    public string? EventCharge { get; set; }

    public string? Inventory { get; set; }

    public string? PaymentSurcharge { get; set; }

    public string? Rounding { get; set; }

    public string? SalesRevenue { get; set; }

    public string? Tax { get; set; }
}
