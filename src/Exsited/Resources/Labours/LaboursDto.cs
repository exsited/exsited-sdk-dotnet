namespace Exsited.Resources.Labours.LaboursDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Labour : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labours",
        "GET /api/{api_version}/labours/available_for_booking",
        "GET /api/{api_version}/labours/{labour_uuid}",
    };

    protected override string? EnvelopeKey => "labour";

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageName { get; set; }

    public IReadOnlyList<object?>? LabourAvailability { get; set; }

    public IReadOnlyList<object?>? LabourContacts { get; set; }

    public IReadOnlyList<object?>? LabourCustomAvailability { get; set; }

    public IReadOnlyDictionary<string, object?>? LabourProfile { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="Labour"/> records, under <c>data</c>.</summary>
public sealed class LabourList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labours",
        "GET /api/{api_version}/labours/available_for_booking",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Labour>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourProfile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_profiles",
    };

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Labours { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Sessions { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? Tax { get; set; }

    public bool? TaxInclusive { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="LabourProfile"/> records, under <c>data</c>.</summary>
public sealed class LabourProfileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_profiles",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<LabourProfile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourAvailability : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_availability",
    };

    public IReadOnlyList<object?>? AvailableList { get; set; }

    public string? Code { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Id { get; set; }

    public IReadOnlyDictionary<string, object?>? LabourProfile { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? ProcessedScheduleList { get; set; }

    public IReadOnlyList<object?>? ScheduleList { get; set; }

    public IReadOnlyList<object?>? SessionList { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<object?>? UnavailableList { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="LabourAvailability"/> records, under <c>data</c>.</summary>
public sealed class LabourAvailabilityList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_availability",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<LabourAvailability>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourProfileRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_profiles/{labour_profile_id}",
    };

    protected override string? EnvelopeKey => "labour_profile";

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<LabourEntry>? Labours { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public long? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Session>? Sessions { get; set; }

    public string? Status { get; set; }

    public Tax? Tax { get; set; }

    public bool? TaxInclusive { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourOrder : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labours/{labour_uuid}/orders",
    };

    public Account? Account { get; set; }

    public bool? AllowContract { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? BillingAddress { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public string? BillingStartDate { get; set; }

    public IReadOnlyList<CommunicationPreference>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomerPurchaseOrderId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DiscountProfile { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? InvoiceNote { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? NextBillingFromDate { get; set; }

    public string? Object { get; set; }

    public string? OrderStartDate { get; set; }

    public string? OrderType { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

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

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ShippingProfile { get; set; }

    public string? Status { get; set; }

    public TimeZone? TimeZone { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="LabourOrder"/> records, under <c>data</c>.</summary>
public sealed class LabourOrderList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labours/{labour_uuid}/orders",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<LabourOrder>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourProfiles : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/labour_profiles",
    };

    protected override string? EnvelopeKey => "labour_profile";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Labours { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public long? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Session>? Sessions { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    public bool? TaxInclusive { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LaboursView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/labours",
    };

    protected override string? EnvelopeKey => "labour";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageName { get; set; }

    public IReadOnlyList<object?>? LabourAvailability { get; set; }

    public IReadOnlyList<object?>? LabourContacts { get; set; }

    public IReadOnlyList<LabourCustomAvailability>? LabourCustomAvailability { get; set; }

    public LabourProfileEntry? LabourProfile { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/labours/{labour_uuid}",
    };

    protected override string? EnvelopeKey => "labour";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageName { get; set; }

    public IReadOnlyList<object?>? LabourAvailability { get; set; }

    public IReadOnlyList<object?>? LabourContacts { get; set; }

    public IReadOnlyList<object?>? LabourCustomAvailability { get; set; }

    public LabourProfileEntry? LabourProfile { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourCancel : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/labours/{labour_id}/cancel",
    };

    protected override string? EnvelopeKey => "labour";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageName { get; set; }

    public IReadOnlyList<object?>? LabourAvailability { get; set; }

    public IReadOnlyList<object?>? LabourContacts { get; set; }

    public IReadOnlyList<object?>? LabourCustomAvailability { get; set; }

    public LabourProfileEntry? LabourProfile { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourReactivate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/labours/{labour_id}/reactivate",
    };

    protected override string? EnvelopeKey => "labour";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageName { get; set; }

    public IReadOnlyList<object?>? LabourAvailability { get; set; }

    public IReadOnlyList<object?>? LabourContacts { get; set; }

    public IReadOnlyList<object?>? LabourCustomAvailability { get; set; }

    public LabourProfileEntry? LabourProfile { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>currency</c>, merged over every record measured.</summary>
public sealed class Currency : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>tax</c>, merged over every record measured.</summary>
public sealed class Tax : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>labours</c>, merged over every record measured.</summary>
public sealed class LabourEntry : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>sessions</c>, merged over every record measured.</summary>
public sealed class Session : Dto
{
    public bool? AllowOvertime { get; set; }

    public IReadOnlyList<Availability>? Availability { get; set; }

    public string? EndDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<Price>? Prices { get; set; }

    public string? StartDate { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<WorkingHour>? WorkingHours { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>labour_profile</c>, merged over every record measured.</summary>
public sealed class LabourProfileEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>labour_custom_availability</c>, merged over every record measured.</summary>
public sealed class LabourCustomAvailability : Dto
{
    public bool? Available { get; set; }

    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreferredDay { get; set; }

    public string? StartTime { get; set; }
}

/// <summary>One entry of a list sent as <c>prices</c>, merged over every record measured.</summary>
public sealed class Price : Dto
{
    public bool? EnabledProRata { get; set; }

    public IReadOnlyList<Hour>? Hours { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? PeakHourly { get; set; }

    public string? PriceType { get; set; }

    [WireName("price")]
    public double? PriceValue { get; set; }

    public PricingLevel? PricingLevel { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>availability</c>, merged over every record measured.</summary>
public sealed class Availability : Dto
{
    public bool? Available { get; set; }

    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreferredDay { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>working_hours</c>, merged over every record measured.</summary>
public sealed class WorkingHour : Dto
{
    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>time_zone</c>, merged over every record measured.</summary>
public sealed class TimeZone : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class Account : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>communication_preferences</c>, merged over every record measured.</summary>
public sealed class CommunicationPreference : Dto
{
    public string? Channel { get; set; }

    public bool? Enabled { get; set; }
}

/// <summary>An object sent as <c>billing_preferences</c>, merged over every record measured.</summary>
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

/// <summary>An object sent as <c>pricing_level</c>, merged over every record measured.</summary>
public sealed class PricingLevel : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>hours</c>, merged over every record measured.</summary>
public sealed class Hour : Dto
{
    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public double? Price { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>proforma_properties</c>, merged over every record measured.</summary>
public sealed class ProformaProperties : Dto
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

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourCalendar : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labours/{labour_id}/availability",
    };

    protected override string? EnvelopeKey => "labour_calendar";
}

/// <summary>One entry of a list sent as <c>sessions</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSession : Dto
{
    public bool? AllowOvertime { get; set; }

    public IReadOnlyList<LabourProfileViewSessionAvailability>? Availability { get; set; }

    public string? EndDate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<LabourProfileViewSessionPrice>? Prices { get; set; }

    public string? StartDate { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<LabourProfileViewSessionWorkingHour>? WorkingHours { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourProfileSessionList : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_profiles/{labour_profile_id}/sessions",
    };

    public IReadOnlyList<LabourProfileViewSession>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class LabourProfileSessionView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/labour_profiles/{labour_profile_id}/sessions/{session_id}",
    };

    protected override string? EnvelopeKey => "labour_profile_session";
}

/// <summary>One entry of a list sent as <c>prices</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSessionPrice : Dto
{
    public bool? EnabledProRata { get; set; }

    public IReadOnlyList<LabourProfileViewSessionPriceHour>? Hours { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? PeakHourly { get; set; }

    public double? Price { get; set; }

    public string? PriceType { get; set; }

    public LabourProfileViewSessionPricePricingLevel? PricingLevel { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>availability</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSessionAvailability : Dto
{
    public bool? Available { get; set; }

    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreferredDay { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>working_hours</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSessionWorkingHour : Dto
{
    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>pricing_level</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSessionPricePricingLevel : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>hours</c>, merged over every record measured.</summary>
public sealed class LabourProfileViewSessionPriceHour : Dto
{
    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public double? Price { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}
