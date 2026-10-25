namespace Exsited.Resources.Bookings.BookingsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Booking : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public bool? AllowContract { get; set; }

    public BillingAddress? BillingAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public string? BillingStartDayOfMonth { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public ContractProperties? ContractProperties { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    public DiscountProfile? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    public string? Origin { get; set; }

    public string? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    public ReferralAccount? ReferralAccount { get; set; }

    public SalesRep? SalesRep { get; set; }

    public ShippingAddress? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public ShippingProfile? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Booking"/> records, under <c>data</c>.</summary>
public sealed class BookingList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Booking>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingById : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}",
        "GET /api/{api_version}/booking/{booking_id}/information",
        "GET /api/{api_version}/booking/{booking_id}/lines",
        "PATCH /api/{api_version}/booking/{booking_id}/information",
        "PATCH /api/{api_version}/booking/{booking_id}/billing_preferences",
        "PATCH /api/{api_version}/booking/{booking_id}/lines/{line_uuid}",
        "PATCH /api/{api_version}/booking/{booking_id}/lines/{line_uuid}/billing_preferences",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public bool? AllowContract { get; set; }

    public BillingAddress? BillingAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? CustomerPurchaseOrderId { get; set; }

    public string? Description { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? InvoiceNote { get; set; }

    public IReadOnlyDictionary<string, object?>? Kpis { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? NextBillingFromDateUtc { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? OriginalTotal { get; set; }

    public bool? PreOrder { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public bool? QuoteConverted { get; set; }

    public bool? QuoteOrder { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralAccount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ShippingAddress { get; set; }

    public double? ShippingCost { get; set; }

    public IReadOnlyList<object?>? ShippingLineItems { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }

    /// <summary>Empty in every record measured; sent by the writes, not by the reads.</summary>
    public IReadOnlyList<object?>? ActivityLogs { get; set; }
}

/// <summary>An object sent as <c>contract_properties</c>, merged over every record measured.</summary>
public sealed class ContractProperties : Dto
{
    public bool? AllowDowngrade { get; set; }

    public bool? AllowDowngradeCharge { get; set; }

    public bool? AllowEarlyTermination { get; set; }

    public bool? AllowPostponement { get; set; }

    public bool? AllowTrial { get; set; }

    public bool? AllowUpgrade { get; set; }

    public string? AutoRenewalEndsOn { get; set; }

    public bool? AutoRenewalRequireCustomerAcceptance { get; set; }

    public string? AutoRenewalTerm { get; set; }

    public string? DowngradeChargeFixed { get; set; }

    public string? DowngradeChargeType { get; set; }

    public string? InitialContractTerm { get; set; }

    public string? PeriodBeforeDowngrade { get; set; }

    public string? RenewAutomatically { get; set; }

    public bool? RequireCustomerAcceptance { get; set; }

    public bool? RequiresPaymentMethod { get; set; }

    public string? TerminationAccountingCode { get; set; }

    public string? TerminationNoticePeriod { get; set; }
}

/// <summary>An object sent as <c>billing_address</c>, merged over every record measured.</summary>
public sealed class BillingAddress : Dto
{
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? AddressLine5 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }
}

/// <summary>An object sent as <c>sales_rep</c>, merged over every record measured.</summary>
public sealed class SalesRep : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>shipping_profile</c>, merged over every record measured.</summary>
public sealed class ShippingProfile : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>referral_account</c>, merged over every record measured.</summary>
public sealed class ReferralAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>discount_profile</c>, merged over every record measured.</summary>
public sealed class DiscountProfile : Dto
{
    public string? Amount { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? RedemptionCode { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>shipping_address</c>, merged over every record measured.</summary>
public sealed class ShippingAddress : Dto
{
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? AddressLine5 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? Name { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingNoteList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/notes",
    };

    public IReadOnlyList<BookingNote>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingBillingPreferencesView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "order";

    public BookingBillingPreferencesDetail? BillingPreferences { get; set; }

    public string? Object { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingCustomObjectList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/custom_objects",
        "GET /api/{api_version}/booking/{booking_id}/custom_objects_instances",
    };

    public IReadOnlyList<BookingCustomObjectEntry>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingCustomObject : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/custom_objects/{custom_object_id}",
        "GET /api/{api_version}/booking/{booking_id}/custom_objects_instances/{custom_object_id}",
    };

    protected override string? EnvelopeKey => "custom_object";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Instances { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Relation { get; set; }

    public string? UseIn { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingInvoiceList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/invoices",
    };

    public IReadOnlyList<BookingInvoice>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingItemFulfillment : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/item_fulfillments/{fulfillment_id}",
    };

    protected override string? EnvelopeKey => "item_fulfillment";

    public BookingItemFulfillmentAccount? Account { get; set; }

    public string? Code { get; set; }

    public BookingItemFulfillmentCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomAttributes { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DeliveryStatus { get; set; }

    public bool? FulfillmentCompleted { get; set; }

    public string? FulfillmentDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? FulfillmentNote { get; set; }

    public string? FulfillmentStatus { get; set; }

    public IReadOnlyList<BookingItemFulfillmentFulfillment>? Fulfillments { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public BookingItemFulfillmentInvoice? Invoice { get; set; }

    public BookingItemFulfillmentLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Order { get; set; }

    public string? Status { get; set; }

    public string? TrackingNumber { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingKpis : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/kpis",
    };

    protected override string? EnvelopeKey => "order_kpis";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DeletedAt { get; set; }

    public string? EstimatedTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastCancelledAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastChangedAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastInvoiceIssueDate { get; set; }

    public string? LastInvoiceTotal { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastReactivatedAt { get; set; }

    public string? MonthlyRecurringRevenue { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? NextInvoiceIssueDate { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? StartDate { get; set; }

    public string? TotalCollected { get; set; }

    public string? TotalDue { get; set; }

    public long? TotalInvoice { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalRevenue { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingPaymentMethods : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/payment_methods",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyList<BookingPaymentMethodsPaymentMethod>? PaymentMethods { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingPaymentMethod : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/payment_methods/{payment_method_ref}",
    };

    protected override string? EnvelopeKey => "order";

    public BookingPaymentMethodPaymentMethod? PaymentMethod { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingPaymentList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/payments",
    };

    public IReadOnlyList<BookingPayment>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingPaymentView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/payments/{payment_id}",
    };

    protected override string? EnvelopeKey => "payment";

    public BookingPaymentViewAccount? Account { get; set; }

    public BookingPaymentViewCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditApplied { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyList<object?>? GiftCertificateApplied { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<BookingPaymentViewInvoice>? Invoices { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public IReadOnlyList<BookingPaymentViewPaymentApplied>? PaymentApplied { get; set; }

    public string? PaymentNote { get; set; }

    public string? ReconcileStatus { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingPdf : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/pdf",
    };

    protected override string? EnvelopeKey => "order";

    public BookingPdfPdf? Pdf { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingQuotePartialInvoices : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/quote_partial_invoices",
    };

    protected override string? EnvelopeKey => "order";

    public IReadOnlyList<object?>? PartialInvoices { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class BookingNote : Dto
{
    public IReadOnlyList<BookingNoteAttachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public BookingNoteCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public BookingNoteLastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<BookingNoteWatcher>? Watchers { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class BookingNoteAttachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class BookingNoteCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class BookingNoteLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>, merged over every record measured.</summary>
public sealed class BookingNoteWatcher : Dto
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>billing_preferences</c>, merged over every record measured.</summary>
public sealed class BookingBillingPreferencesDetail : Dto
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

    public BookingBillingPreferencesDetailProformaProperties? ProformaProperties { get; set; }
}

/// <summary>An object sent as <c>proforma_properties</c>, merged over every record measured.</summary>
public sealed class BookingBillingPreferencesDetailProformaProperties : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AcceptanceDate { get; set; }

    public bool? AcceptanceRequired { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AcceptanceTerm { get; set; }

    public bool? PaymentRequired { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TermsAndConditions { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class BookingCustomObjectEntry : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomComponent { get; set; }

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

    public string? Relation { get; set; }

    public string? UseIn { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class BookingInvoice : Dto
{
    public BookingInvoiceAccount? Account { get; set; }

    public string? AlternateBillingEndDate { get; set; }

    public string? AlternateBillingStartDate { get; set; }

    public string? AlternateDueDate { get; set; }

    public string? AlternateIssueDate { get; set; }

    public string? BillingEndDate { get; set; }

    public string? BillingStartDate { get; set; }

    public BookingInvoiceCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public BookingInvoiceCurrency? Currency { get; set; }

    public BookingInvoiceCustomForm? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    public double? DiscountAmount { get; set; }

    public string? Due { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    public string? IssueDate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastPayment { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public BookingInvoiceOrder? Order { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public string? Paid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? PriceTaxInclusive { get; set; }

    public string? Status { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public string? TaxTotal { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class BookingInvoiceAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class BookingInvoiceCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class BookingInvoiceCurrency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class BookingInvoiceCustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>order</c>, merged over every record measured.</summary>
public sealed class BookingInvoiceOrder : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentAccount : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>fulfillments</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentFulfillment : Dto
{
    public long? FulfillmentIndex { get; set; }

    public double? FulfillmentQty { get; set; }

    public double? FulfillmentSentQty { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InventoryTracking { get; set; }

    public BookingItemFulfillmentFulfillmentItem? Item { get; set; }

    public string? Object { get; set; }

    public double? PendingReturn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Returned { get; set; }

    public string? ServingStatus { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Uom { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UomPrecision { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentFulfillmentItem : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>invoice</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentInvoice : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class BookingItemFulfillmentLastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_methods</c>, merged over every record measured.</summary>
public sealed class BookingPaymentMethodsPaymentMethod : Dto
{
    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public bool? Default { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? LastUsedAt { get; set; }

    public string? Object { get; set; }

    public long? PaymentCount { get; set; }

    public BookingPaymentMethodsPaymentMethodProcessor? Processor { get; set; }

    public string? ProcessorType { get; set; }

    public string? Reference { get; set; }

    public bool? RestrictedToOrders { get; set; }

    public string? SpecifiedOrderIds { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>processor</c>, merged over every record measured.</summary>
public sealed class BookingPaymentMethodsPaymentMethodProcessor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>payment_method</c>, merged over every record measured.</summary>
public sealed class BookingPaymentMethodPaymentMethod : Dto
{
    public string? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public bool? Default { get; set; }

    public string? Id { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? LastUsedAt { get; set; }

    public string? Object { get; set; }

    public long? PaymentCount { get; set; }

    public BookingPaymentMethodPaymentMethodProcessor? Processor { get; set; }

    public string? ProcessorType { get; set; }

    public string? Reference { get; set; }

    public bool? RestrictedToOrders { get; set; }

    public string? SpecifiedOrderIds { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>processor</c>, merged over every record measured.</summary>
public sealed class BookingPaymentMethodPaymentMethodProcessor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class BookingPayment : Dto
{
    public BookingPaymentAccount? Account { get; set; }

    public BookingPaymentCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CreditApplied { get; set; }

    public IReadOnlyList<object?>? GiftCertificateApplied { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<BookingPaymentInvoice>? Invoices { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    public IReadOnlyList<BookingPaymentPaymentApplied>? PaymentApplied { get; set; }

    public string? PaymentNote { get; set; }

    public string? ReconcileStatus { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class BookingPaymentAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class BookingPaymentCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>invoices</c>, merged over every record measured.</summary>
public sealed class BookingPaymentInvoice : Dto
{
    public string? Applied { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? Outstanding { get; set; }

    public string? Total { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_applied</c>, merged over every record measured.</summary>
public sealed class BookingPaymentPaymentApplied : Dto
{
    public string? Amount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? GatewayResponse { get; set; }

    public string? Method { get; set; }

    public string? Processor { get; set; }

    public string? Reference { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class BookingPaymentViewAccount : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class BookingPaymentViewCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>invoices</c>, merged over every record measured.</summary>
public sealed class BookingPaymentViewInvoice : Dto
{
    public string? Applied { get; set; }

    public string? DueDate { get; set; }

    public string? Id { get; set; }

    public string? IssueDate { get; set; }

    public string? Outstanding { get; set; }

    public string? Total { get; set; }
}

/// <summary>One entry of a list sent as <c>payment_applied</c>, merged over every record measured.</summary>
public sealed class BookingPaymentViewPaymentApplied : Dto
{
    public string? Amount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? GatewayResponse { get; set; }

    public string? Method { get; set; }

    public string? Processor { get; set; }

    public string? Reference { get; set; }
}

/// <summary>An object sent as <c>pdf</c>, merged over every record measured.</summary>
public sealed class BookingPdfPdf : Dto
{
    public string? DownloadUrl { get; set; }

    public long? FileSize { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreviewUrl { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class BookingLine : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/booking/{booking_id}/lines/{line_uuid}",
    };

    protected override string? EnvelopeKey => "order_line";

    public string? ChargeItemUuid { get; set; }

    public string? ExpectedDeliveryDate { get; set; }

    public string? Id { get; set; }

    public BookingLineItem? Item { get; set; }

    public BookingLineItemAccountingCode? ItemAccountingCode { get; set; }

    public string? ItemChargeType { get; set; }

    public IReadOnlyList<object?>? ItemCustomAttributes { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemInvoiceNote { get; set; }

    public long? ItemOrderQuantity { get; set; }

    public BookingLineItemPriceSnapshot? ItemPriceSnapshot { get; set; }

    public BookingLineItemPriceTax? ItemPriceTax { get; set; }

    public BookingLineItemProperties? ItemProperties { get; set; }

    public BookingLineItemSaleTaxConfiguration? ItemSaleTaxConfiguration { get; set; }

    public string? ItemType { get; set; }

    public string? Object { get; set; }

    public BookingLinePreOrderStockDetails? PreOrderStockDetails { get; set; }

    public double? ShippingCost { get; set; }

    public string? Subtotal { get; set; }

    public string? Tax { get; set; }

    public bool? TaxExemptWhenSold { get; set; }

    public string? Total { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>item</c>, merged over every record measured.</summary>
public sealed class BookingLineItem : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>item_accounting_code</c>, merged over every record measured.</summary>
public sealed class BookingLineItemAccountingCode : Dto
{
    public string? SalesRevenue { get; set; }
}

/// <summary>An object sent as <c>item_price_snapshot</c>, merged over every record measured.</summary>
public sealed class BookingLineItemPriceSnapshot : Dto
{
    public BookingLineItemPriceSnapshotPricingRule? PricingRule { get; set; }
}

/// <summary>An object sent as <c>pricing_rule</c>, merged over every record measured.</summary>
public sealed class BookingLineItemPriceSnapshotPricingRule : Dto
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

/// <summary>An object sent as <c>item_price_tax</c>, merged over every record measured.</summary>
public sealed class BookingLineItemPriceTax : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public double? Rate { get; set; }
}

/// <summary>An object sent as <c>item_properties</c>, merged over every record measured.</summary>
public sealed class BookingLineItemProperties : Dto
{
    public string? BillingMode { get; set; }

    public string? ChargingAndBillingAlignment { get; set; }

    public string? ChargingStartDate { get; set; }

    public string? ProRataPartialPricingPeriod { get; set; }
}

/// <summary>An object sent as <c>item_sale_tax_configuration</c>, merged over every record measured.</summary>
public sealed class BookingLineItemSaleTaxConfiguration : Dto
{
    public string? SalePriceIsBasedOn { get; set; }

    public BookingLineItemSaleTaxConfigurationTaxCode? TaxCode { get; set; }
}

/// <summary>An object sent as <c>tax_code</c>, merged over every record measured.</summary>
public sealed class BookingLineItemSaleTaxConfigurationTaxCode : Dto
{
    public string? Code { get; set; }

    public string? Link { get; set; }

    public string? Rate { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>pre_order_stock_details</c>, merged over every record measured.</summary>
public sealed class BookingLinePreOrderStockDetails : Dto
{
    public string? PendingReserve { get; set; }

    public string? Reserved { get; set; }

    public string? Sold { get; set; }
}
