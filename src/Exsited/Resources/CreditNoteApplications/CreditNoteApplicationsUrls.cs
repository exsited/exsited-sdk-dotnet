namespace Exsited.Resources.CreditNoteApplications;

/// <summary>Path templates and body keys for the v4 credit note applications endpoints.</summary>
public static class CreditNoteApplicationsUrls
{
    public const string CreditNoteApplications = "/api/{api_version}/credit_note_applications";

    public const string CreditNoteApplication = "/api/{api_version}/credit_note_applications/{credit_note_application_id}";

    public const string InvoiceCreditNoteApplications = "/api/{api_version}/invoices/{invoice_id}/credit_note_applications";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/credit_note_applications/{credit_note_application_id}</c>.</summary>
    public const string CreditNoteApplicationKey = "credit_note_application";
}
