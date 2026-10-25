namespace Exsited.Resources.ReturnVendorAuthorizations.ReturnVendorAuthorizationsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReturnVendorAuthorization : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/return_vendor_authorizations",
    };

    public ReturnVendorAuthorizationAccount? Account { get; set; }

    public string? Code { get; set; }

    public ReturnVendorAuthorizationCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public long? ItemCount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public ReturnVendorAuthorizationPurchaseOrder? PurchaseOrder { get; set; }

    public string? ReturnStatus { get; set; }

    public string? RvaDate { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="ReturnVendorAuthorization"/> records, under <c>data</c>.</summary>
public sealed class ReturnVendorAuthorizationList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/return_vendor_authorizations",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ReturnVendorAuthorization>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReturnVendorAuthorizationView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/return_vendor_authorizations/{rva_id}",
    };

    protected override string? EnvelopeKey => "return_vendor_authorization";

    /// <summary>Empty in every record measured, so the entries are untyped.</summary>
    public IReadOnlyList<object?>? Lines { get; set; }

    /// <summary>Empty in every record measured, so the entries are untyped.</summary>
    public IReadOnlyList<object?>? ReceiveRvas { get; set; }
}

/// <summary>An object sent as <c>account</c>, merged over every record measured.</summary>
public sealed class ReturnVendorAuthorizationAccount : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>purchase_order</c>, merged over every record measured.</summary>
public sealed class ReturnVendorAuthorizationPurchaseOrder : Dto
{
    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class ReturnVendorAuthorizationCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
