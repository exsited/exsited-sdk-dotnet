namespace Exsited.Resources.Approvals;

/// <summary>Path templates and body keys for the v4 approvals endpoints.</summary>
public static class ApprovalsUrls
{
    public const string ApprovalsAccount = "/api/{api_version}/approvals/account";

    public const string ApprovalsSaleorder = "/api/{api_version}/approvals/saleOrder";

    public const string ApprovalsAccountByUuid = "/api/{api_version}/approvals/account/{account_uuid}";

    public const string ApprovalsApprove = "/api/{api_version}/approvals/approve";

    public const string ApprovalsReject = "/api/{api_version}/approvals/reject";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";
}
