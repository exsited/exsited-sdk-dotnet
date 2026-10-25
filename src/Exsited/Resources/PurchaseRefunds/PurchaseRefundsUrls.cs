namespace Exsited.Resources.PurchaseRefunds;

/// <summary>Path templates and body keys for the v4 purchase refunds endpoints.</summary>
public static class PurchaseRefundsUrls
{
    public const string PurchaseRefunds = "/api/{api_version}/purchase_refunds";

    public const string PurchaseRefund = "/api/{api_version}/purchase_refunds/{purchase_refund_id}";

    public const string PurchaseCreditNotePurchaseRefunds = "/api/{api_version}/purchase_credit_notes/{purchase_credit_note_id}/purchase_refunds";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/purchase_refunds/{purchase_refund_id}</c>.</summary>
    public const string PurchaseRefundKey = "purchase_refund";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
