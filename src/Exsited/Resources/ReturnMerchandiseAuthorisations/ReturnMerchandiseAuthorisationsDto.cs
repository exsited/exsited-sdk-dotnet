namespace Exsited.Resources.ReturnMerchandiseAuthorisations.ReturnMerchandiseAuthorisationsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReturnMerchandiseAuthorisation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/return_merchandise_authorisations",
    };

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

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

    public string? ReturnStatus { get; set; }

    public string? RmaDate { get; set; }

    public IReadOnlyDictionary<string, object?>? SaleInvoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>One page of <see cref="ReturnMerchandiseAuthorisation"/> records, under <c>data</c>.</summary>
public sealed class ReturnMerchandiseAuthorisationList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/return_merchandise_authorisations",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<ReturnMerchandiseAuthorisation>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class InvoiceReturnMerchandiseAuthorisationReceive : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive",
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}",
        "GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}",
    };

    protected override string? EnvelopeKey => "receive_rma";

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public double? QuantityReceived { get; set; }

    public IReadOnlyList<object?>? ReceiveReturns { get; set; }

    public string? Status { get; set; }

    public string? Uuid { get; set; }

    public InvoiceReturnMerchandiseAuthorisationReceiveReceiveRma? ReceiveRma { get; set; }
}

/// <summary>One page of <see cref="InvoiceReturnMerchandiseAuthorisationReceive"/> records, under <c>data</c>.</summary>
public sealed class InvoiceReturnMerchandiseAuthorisationReceiveList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive",
        "GET /api/{api_version}/return_merchandise_authorisations/{rma_code}/receive",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<InvoiceReturnMerchandiseAuthorisationReceive>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>Records under <c>receive_return_merchandise_authorisations</c>; the receive listing answers them under <c>data</c>.</summary>
    public IReadOnlyList<InvoiceReturnMerchandiseAuthorisationReceive>? ReceiveReturnMerchandiseAuthorisations { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReturnMerchandiseAuthorisationRead : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_id}",
        "GET /api/{api_version}/return_merchandise_authorisations/{rma_id}",
    };

    protected override string? EnvelopeKey => "return_merchandise_authorisation";

    public IReadOnlyDictionary<string, object?>? Account { get; set; }

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public long? ItemCount { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public IReadOnlyList<object?>? Lines { get; set; }

    public string? Note { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? ReceiveRmas { get; set; }

    public string? ReturnStatus { get; set; }

    public string? RmaDate { get; set; }

    public IReadOnlyDictionary<string, object?>? SaleInvoice { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? SaleOrder { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Warehouse { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class ReturnMerchandiseAuthorisationsView : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/return_merchandise_authorisations",
    };

    protected override string? EnvelopeKey => "return_merchandise_authorisation";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public IReadOnlyDictionary<string, object?>? ReturnMerchandiseAuthorisation { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>receive_rma</c>, merged over every record measured.</summary>
public sealed class InvoiceReturnMerchandiseAuthorisationReceiveReceiveRma : Dto
{
    public string? Code { get; set; }

    public InvoiceReturnMerchandiseAuthorisationReceiveReceiveRmaCreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Object { get; set; }

    public double? QuantityReceived { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>created_by</c>, merged over every record measured.</summary>
public sealed class InvoiceReturnMerchandiseAuthorisationReceiveReceiveRmaCreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
