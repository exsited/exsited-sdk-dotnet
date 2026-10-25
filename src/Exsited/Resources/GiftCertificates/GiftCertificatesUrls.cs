namespace Exsited.Resources.GiftCertificates;

/// <summary>Path templates and body keys for the v4 gift certificates endpoints.</summary>
public static class GiftCertificatesUrls
{
    public const string GiftCertificates = "/api/{api_version}/gift_certificates";

    public const string GiftCertificate = "/api/{api_version}/gift_certificates/{gc_id}";

    public const string GiftCertificateAllocations = "/api/{api_version}/gift_certificates/{gc_id}/allocations";

    public const string GiftCertificateTransactions = "/api/{api_version}/gift_certificates/{gc_id}/transactions";

    public const string GiftCertificateAmend = "/api/{api_version}/gift_certificates/{gc_id}/amend";

    public const string GiftCertificateDeallocations = "/api/{api_version}/gift_certificates/{gc_id}/deallocations";

    public const string GiftCertificateAllocation = "/api/{api_version}/gift_certificates/{gc_id}/allocations/{allocation_id}";

    public const string GiftCertificateTransaction = "/api/{api_version}/gift_certificates/{gc_id}/transactions/{transaction_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string GiftCertificateKey = "gift_certificate";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/gift_certificates/{gc_id}/allocations/{allocation_id}</c>.</summary>
    public const string GiftCertificateAllocationKey = "gift_certificate_allocation";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/gift_certificates/{gc_id}/transactions/{transaction_id}</c>.</summary>
    public const string GiftCertificateTransactionKey = "gift_certificate_transaction";
}
