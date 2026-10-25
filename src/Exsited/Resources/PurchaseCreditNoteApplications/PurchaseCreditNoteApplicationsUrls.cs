namespace Exsited.Resources.PurchaseCreditNoteApplications;

/// <summary>Path templates and body keys for the v4 purchase credit note applications endpoints.</summary>
public static class PurchaseCreditNoteApplicationsUrls
{
    public const string PurchaseCreditNoteApplications = "/api/{api_version}/purchase_credit_note_applications";

    public const string PurchaseCreditNoteApplication = "/api/{api_version}/purchase_credit_note_applications/{purchase_credit_note_application_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_credit_note_applications/{purchase_credit_note_application_id}</c>.</summary>
    public const string PurchaseCreditNoteApplicationKey = "purchase_credit_note_application";
}
