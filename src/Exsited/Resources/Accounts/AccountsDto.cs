namespace Exsited.Resources.Accounts.AccountsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class Account : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts",
    };

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? ParentAccountId { get; set; }

    public bool? PortalAccess { get; set; }

    public IReadOnlyDictionary<string, object?>? PricingLevel { get; set; }

    public string? ReferralTracking { get; set; }

    public SalesRep? SalesRep { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Type { get; set; }

    public UserTeam? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }

    public string? Href { get; set; }

    /// <summary><c>GetAccountAsync</c> sends these inline; inventories, partial_invoices, activity_logs and notes wait for their own endpoint.</summary>
    public IReadOnlyList<Address>? Addresses { get; set; }

    public IReadOnlyList<Contact>? Contacts { get; set; }

    public IReadOnlyList<PaymentMethod>? PaymentMethods { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<AccountCustomAttribute>? CustomAttributes { get; set; }

    public IReadOnlyList<Reference>? CustomObjects { get; set; }

    public IReadOnlyList<object?>? Inventories { get; set; }

    /// <summary>The key <c>GetAccountQuotePartialInvoicesAsync</c> answers under - which does not match its path segment.</summary>
    public IReadOnlyList<object?>? PartialInvoices { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public PaymentMethod? PaymentMethod { get; set; }
}

/// <summary>One page of <see cref="Account"/> records, under <c>data</c>.</summary>
public sealed class AccountList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<Account>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountCommunicationsEmail : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/communications/emails",
        "GET /api/{api_version}/accounts/{account_id}/communications/emails/{email_id}",
    };

    protected override string? EnvelopeKey => "email";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AdditionalTemplate { get; set; }

    public IReadOnlyList<object?>? Attachments { get; set; }

    public IReadOnlyList<object?>? Bcc { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Body { get; set; }

    public IReadOnlyList<object?>? Cc { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? From { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? MailType { get; set; }

    public string? MessageType { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Subject { get; set; }

    public string? To { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="AccountCommunicationsEmail"/> records, under <c>data</c>.</summary>
public sealed class AccountCommunicationsEmailList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/communications/emails",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AccountCommunicationsEmail>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountNote : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/notes",
        "GET /api/{api_version}/accounts/{account_id}/notes/{account_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public IReadOnlyList<object?>? Attachments { get; set; }

    public string? Content { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>One page of <see cref="AccountNote"/> records, under <c>data</c>.</summary>
public sealed class AccountNoteList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/notes",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AccountNote>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountCustomObject : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/custom_objects",
        "GET /api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}",
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

    /// <summary>Empty in every record measured, so its entries are untyped.</summary>
    public IReadOnlyList<object?>? Instances { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }
}

/// <summary>One page of <see cref="AccountCustomObject"/> records, under <c>data</c>.</summary>
public sealed class AccountCustomObjectList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/custom_objects",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AccountCustomObject>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    public IReadOnlyDictionary<string, object?>? PricingLevel { get; set; }

    public string? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountImage : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/accounts/{account_id}/addresses",
        "POST /api/{api_version}/accounts/{account_id}/image",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountSetPassword : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/accounts/{account_id}/set-password",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountInformation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/information",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyDictionary<string, object?>? AccountingCode { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    public IReadOnlyDictionary<string, object?>? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public IReadOnlyDictionary<string, object?>? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    public string? ParentAccountId { get; set; }

    public bool? PortalAccess { get; set; }

    public IReadOnlyDictionary<string, object?>? PricingLevel { get; set; }

    public string? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? Status { get; set; }

    public IReadOnlyDictionary<string, object?>? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public IReadOnlyDictionary<string, object?>? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountAddresses : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/addresses",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? Addresses { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountBillingPreferences : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyDictionary<string, object?>? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountContacts : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/contacts",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountPaymentMethods : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/payment_methods",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountPaymentMethod : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CustomForm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public PaymentMethod? PaymentMethod { get; set; }

    public IReadOnlyDictionary<string, object?>? SocialLinks { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatus { get; set; }
}

/// <summary>No endpoint names this view; the endpoints it was measured from answer <see cref="AccountNoteFileList"/>.</summary>
public sealed class AccountNoteFiles : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files",
    };

    protected override string? EnvelopeKey => "data";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountOrders : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/credit_notes",
        "GET /api/{api_version}/accounts/{account_id}/invoices",
        "GET /api/{api_version}/accounts/{account_id}/orders",
        "GET /api/{api_version}/accounts/{account_id}/payments",
        "GET /api/{api_version}/accounts/{account_id}/purchase_invoices",
        "GET /api/{api_version}/accounts/{account_id}/purchase_orders",
        "GET /api/{api_version}/accounts/{account_id}/purchase_payments",
        "GET /api/{api_version}/accounts/{account_id}/purchase_refunds",
        "GET /api/{api_version}/accounts/{account_id}/refunds",
    };

    public IReadOnlyList<object?>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountImageRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/image",
    };

    protected override string? EnvelopeKey => "account";

    public string? AccountId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUri { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountInventories : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/inventories",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? Inventories { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountQuotePartialInvoices : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/quote_partial_invoices",
    };

    protected override string? EnvelopeKey => "account";

    public IReadOnlyList<object?>? PartialInvoices { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountContact : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}",
    };

    protected override string? EnvelopeKey => "account";

    public Contact? Contacts { get; set; }

    public string? Id { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountAddress : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}",
    };

    protected override string? EnvelopeKey => "account";

    public Address? Addresses { get; set; }

    public string? Id { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountNoteFile : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files",
        "GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files/{file_uuid}",
    };

    protected override string? EnvelopeKey => "file";

    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One page of <see cref="AccountNoteFile"/> records, under <c>data</c>.</summary>
public sealed class AccountNoteFileList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<AccountNoteFile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountCancel : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/accounts/{account_id}/cancel",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountInformationUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/accounts/{account_id}/information",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<Contact>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountAddressUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<Address>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountContactUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}",
        "PUT /api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<Contact>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountBillingPreferencesUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PUT /api/{api_version}/accounts/{account_id}/billing_preferences",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<object?>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountPaymentMethodUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}",
    };

    protected override string? EnvelopeKey => "account";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? AccountingCode { get; set; }

    public IReadOnlyList<object?>? Addresses { get; set; }

    public BillingPreferences? BillingPreferences { get; set; }

    public IReadOnlyList<object?>? CommunicationPreferences { get; set; }

    public IReadOnlyList<object?>? Contacts { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public IReadOnlyList<CustomObject>? CustomObjects { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailAddress { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ImageUrl { get; set; }

    public bool? InvoiceParentAccount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Manager { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Origin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ParentAccountId { get; set; }

    public IReadOnlyList<PaymentMethod>? PaymentMethods { get; set; }

    public bool? PortalAccess { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PricingLevel { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ReferralTracking { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SalesRep { get; set; }

    public SocialLinks? SocialLinks { get; set; }

    public string? Status { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Tax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxId { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? TaxIdNumber { get; set; }

    public TimeZone? TimeZone { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? UserTeam { get; set; }

    public long? Version { get; set; }

    public string? WorkflowStatus { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountNotes : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/accounts/{account_id}/notes",
    };

    protected override string? EnvelopeKey => "note";

    public AccountEntry? Account { get; set; }

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<Watcher>? Watchers { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountNoteUpdated : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/accounts/{account_id}/notes/{account_note_id}",
    };

    protected override string? EnvelopeKey => "note";

    public AccountEntry? Account { get; set; }

    public IReadOnlyList<Attachment>? Attachments { get; set; }

    public string? Content { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Group { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? User { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? Watchers { get; set; }
}

/// <summary>An object sent as <c>contacts</c>, merged over every record measured.</summary>
public sealed class Contact : Dto
{
    public Address? Address { get; set; }

    public bool? BillingContact { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public Email? Email { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Fax { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public Mobile? Mobile { get; set; }

    public Name? Name { get; set; }

    public string? Object { get; set; }

    public Phone? Phone { get; set; }

    public bool? ReceivesBillingInformation { get; set; }

    public bool? ShippingContact { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>addresses</c>, merged over every record measured.</summary>
public sealed class Address : Dto
{
    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? AddressLine5 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CountryCode { get; set; }

    public bool? DefaultBilling { get; set; }

    public bool? DefaultShipping { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Line1 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Line2 { get; set; }

    public string? Object { get; set; }

    public string? PostalCode { get; set; }

    public string? State { get; set; }
}

/// <summary>An object sent as <c>payment_method</c>, merged over every record measured.</summary>
public sealed class PaymentMethod : Dto
{
    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public bool? Default { get; set; }

    public string? Id { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUsedAt { get; set; }

    public string? Object { get; set; }

    public long? PaymentCount { get; set; }

    public Processor? Processor { get; set; }

    public string? ProcessorType { get; set; }

    public string? Reference { get; set; }

    public bool? RestrictedToOrders { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SpecifiedOrderIds { get; set; }

    public string? Status { get; set; }

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

/// <summary>An object sent as <c>time_zone</c>, merged over every record measured.</summary>
public sealed class TimeZone : Dto
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

/// <summary>An object sent as <c>social_links</c>, merged over every record measured.</summary>
public sealed class SocialLinks : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Facebook { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Linkedin { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Twitter { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Website { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>billing_preferences</c>, merged over every record measured.</summary>
public sealed class BillingPreferences : Dto
{
    public string? BillingPeriod { get; set; }

    public string? BillingStartDate { get; set; }

    public long? BillingStartDayOfMonth { get; set; }

    public bool? ChargesAlignedToBilling { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CommunicationProfile { get; set; }

    public string? InvoiceMode { get; set; }

    public string? InvoiceTerm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentMode { get; set; }

    public string? PaymentProcessor { get; set; }

    public string? PaymentTerm { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PaymentTermAlignment { get; set; }

    public bool? ConsolidateInvoice { get; set; }

    public string? FulfillmentMode { get; set; }

    public string? FulfillmentTerm { get; set; }

    /// <summary>Untyped: an object with no settled shape.</summary>
    public object? ProformaProperties { get; set; }

    public string? CommunicationGroup { get; set; }

    public string? BillingMode { get; set; }

    public string? ChargingPeriod { get; set; }

    /// <summary>A string, not a bool, unlike the account body's <c>charges_aligned_to_billing</c>.</summary>
    public string? ChargingAndBillingAlignment { get; set; }

    public string? ChargingStartDate { get; set; }

    public string? EventProfile { get; set; }
}

/// <summary>One entry of a list sent as <c>custom_objects</c>, merged over every record measured.</summary>
public sealed class CustomObject : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class AccountEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>attachments</c>, merged over every record measured.</summary>
public sealed class Attachment : Dto
{
    public string? ContentType { get; set; }

    public string? Filename { get; set; }

    public string? Href { get; set; }

    public long? Size { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>One entry of a list sent as <c>watchers</c>, merged over every record measured.</summary>
public sealed class Watcher : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Email { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }
}

/// <summary>An object sent as <c>name</c>, merged over every record measured.</summary>
public sealed class Name : Dto
{
    public string? Designation { get; set; }

    public string? First { get; set; }

    public string? Last { get; set; }

    public string? Middle { get; set; }

    public string? Salutation { get; set; }
}

/// <summary>An object sent as <c>email</c>, merged over every record measured.</summary>
public sealed class Email : Dto
{
    public string? Address { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? EmailOptedOut { get; set; }
}

/// <summary>An object sent as <c>phone</c>, merged over every record measured.</summary>
public sealed class Phone : Dto
{
    public string? AreaCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CallOptedOut { get; set; }

    public string? DialingCode { get; set; }

    public string? Formatted { get; set; }

    public string? Number { get; set; }
}

/// <summary>An object sent as <c>mobile</c>, merged over every record measured.</summary>
public sealed class Mobile : Dto
{
    public string? AreaCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CallOptedOut { get; set; }

    public string? DialingCode { get; set; }

    public string? Formatted { get; set; }

    public string? Number { get; set; }
}

/// <summary>An object sent as <c>processor</c>, merged over every record measured.</summary>
public sealed class Processor : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>, merged over every record measured.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>sales_rep</c>, merged over every record measured.</summary>
public sealed class SalesRep : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>user_team</c>, merged over every record measured.</summary>
public sealed class UserTeam : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class Reference : Dto
{
    public string? Object { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Href { get; set; }

    public double? Rate { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountKpis : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/kpis",
    };

    protected override string? EnvelopeKey => "account_kpis";

    public string? Object { get; set; }

    public string? TotalRevenue { get; set; }

    public string? MonthlyRecurringRevenue { get; set; }

    public string? TotalCollected { get; set; }

    public string? TotalRefunded { get; set; }

    public string? TotalOutstanding { get; set; }

    public string? TotalOverdue { get; set; }

    public string? TotalBalance { get; set; }

    public string? TotalCreditBalance { get; set; }

    public long? TotalOrders { get; set; }

    public long? ActiveOrders { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastReactivatedAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastCancelledAt { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? DeletedAt { get; set; }

    public string? ComputedAt { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountFinancialSummary : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/financial_summary",
    };

    protected override string? EnvelopeKey => "account";

    public string? Name { get; set; }

    public AccountFinancialSummaryDetail? FinancialSummary { get; set; }
}

/// <summary>An object sent as <c>financial_summary</c>, merged over every record measured.</summary>
public sealed class AccountFinancialSummaryDetail : Dto
{
    public string? TotalDue { get; set; }

    public string? TotalGrand { get; set; }

    public string? TotalPaid { get; set; }

    public long? InvoiceCount { get; set; }

    public long? TotalDueInvoiceCount { get; set; }

    public string? TotalOverdueAmount { get; set; }

    public long? TotalOverdueInvoiceCount { get; set; }

    public string? CollectedThisMonth { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class AccountComponentObject : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/accounts/{account_id}/component/{component_id}/{component_object_id}",
    };

    protected override string? EnvelopeKey => "custom_component_object";

    public IReadOnlyList<object?>? Accounts { get; set; }

    public IReadOnlyList<object?>? AttributeGroups { get; set; }

    public IReadOnlyList<object?>? Attributes { get; set; }

    public string? Code { get; set; }

    public ComponentObjectsDataDetail? Component { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public ComponentObjectsDataCustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Items { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Orders { get; set; }

    public IReadOnlyList<ComponentObjectsDataParent>? Parents { get; set; }

    public IReadOnlyList<object?>? Quotes { get; set; }

    public IReadOnlyList<object?>? Restrictions { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? WorkflowData { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStage { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatus { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatusUuid { get; set; }
}

/// <summary>One entry of a list sent as <c>custom_attributes</c>, merged over every record measured.</summary>
public sealed class AccountCustomAttribute : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Type { get; set; }

    public object? Value { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ComponentObjects : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/components/{component_uuid}/objects",
    };

    public IReadOnlyList<ComponentObjectsData>? Data { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>One entry of a list sent as <c>data</c>, merged over every record measured.</summary>
public sealed class ComponentObjectsData : Dto
{
    public IReadOnlyList<object?>? Accounts { get; set; }

    public IReadOnlyList<object?>? AttributeGroups { get; set; }

    public IReadOnlyList<object?>? Attributes { get; set; }

    public string? Code { get; set; }

    public ComponentObjectsDataDetail? Component { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public ComponentObjectsDataCustomForm? CustomForm { get; set; }

    public IReadOnlyList<object?>? CustomObjects { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public IReadOnlyList<object?>? Items { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? Orders { get; set; }

    public IReadOnlyList<ComponentObjectsDataParent>? Parents { get; set; }

    public IReadOnlyList<object?>? Quotes { get; set; }

    public IReadOnlyList<object?>? Restrictions { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }

    public IReadOnlyList<object?>? WorkflowData { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStage { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatus { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WorkflowStatusUuid { get; set; }
}

/// <summary>An object sent as <c>component</c>, merged over every record measured.</summary>
public sealed class ComponentObjectsDataDetail : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>, merged over every record measured.</summary>
public sealed class ComponentObjectsDataCustomForm : Dto
{
    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>parents</c>, merged over every record measured.</summary>
public sealed class ComponentObjectsDataParent : Dto
{
    public string? Email { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Type { get; set; }
}
