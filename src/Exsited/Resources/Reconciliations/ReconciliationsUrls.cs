namespace Exsited.Resources.Reconciliations;

/// <summary>Path templates and body keys for the v4 reconciliations endpoints.</summary>
public static class ReconciliationsUrls
{
    public const string ReconciliationSalePayments = "/api/{api_version}/reconciliations/{reconciliation_id}/sale_payments";

    public const string ReconciliationSaleRefunds = "/api/{api_version}/reconciliations/{reconciliation_id}/sale_refunds";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
