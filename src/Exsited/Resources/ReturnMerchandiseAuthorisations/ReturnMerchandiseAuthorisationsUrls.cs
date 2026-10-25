namespace Exsited.Resources.ReturnMerchandiseAuthorisations;

/// <summary>Path templates and body keys for the v4 return merchandise authorisations endpoints.</summary>
public static class ReturnMerchandiseAuthorisationsUrls
{
    public const string ReturnMerchandiseAuthorisations = "/api/{api_version}/return_merchandise_authorisations";

    public const string ReturnMerchandiseAuthorisation = "/api/{api_version}/return_merchandise_authorisations/{rma_id}";

    public const string InvoiceReturnMerchandiseAuthorisationReceive = "/api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive";

    public const string InvoiceReturnMerchandiseAuthorisationReceiveByUuid = "/api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}";

    public const string ReturnMerchandiseAuthorisationApprove = "/api/{api_version}/return_merchandise_authorisations/{rma_id}/approve";

    public const string ReturnMerchandiseAuthorisationReject = "/api/{api_version}/return_merchandise_authorisations/{rma_id}/reject";

    public const string ReturnMerchandiseAuthorisationReceive = "/api/{api_version}/return_merchandise_authorisations/{rma_id}/receive";

    public const string ReturnMerchandiseAuthorisationReceiveByUuid = "/api/{api_version}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}";

    public const string ReturnMerchandiseAuthorisationNotes = "/api/{api_version}/return_merchandise_authorisations/{rma_id}/notes";

    public const string ReturnMerchandiseAuthorisationNoteByCode = "/api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}";

    public const string ReturnMerchandiseAuthorisationNoteFilesByCode = "/api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}/files";

    public const string ReturnMerchandiseAuthorisationNoteFileByCode = "/api/{api_version}/return_merchandise_authorisations/{rma_code}/notes/{note_id}/files/{file_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>A records key the receive listing does not use; it answers them under <c>data</c>.</summary>
    public const string ReceiveReturnMerchandiseAuthorisationsKey = "receive_return_merchandise_authorisations";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string ReceiveReturnMerchandiseAuthorisationKey = "receive_return_merchandise_authorisation";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string ReturnMerchandiseAuthorisationKey = "return_merchandise_authorisation";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string InvoiceKey = "invoice";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive</c> and <c>GET /api/{api_version}/invoices/{invoice_id}/return_merchandise_authorisations/{rma_code}/receive/{receive_uuid}</c>.</summary>
    public const string ReceiveRmaKey = "receive_rma";
}
