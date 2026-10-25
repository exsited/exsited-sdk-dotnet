namespace Exsited.Resources.Accounts;

/// <summary>Path templates and body keys for the v4 accounts endpoints.</summary>
public static class AccountsUrls
{
    public const string Accounts = "/api/{api_version}/accounts";

    public const string Account = "/api/{api_version}/accounts/{account_id}";

    public const string AccountAddresses = "/api/{api_version}/accounts/{account_id}/addresses";

    public const string AccountBillingPreferences = "/api/{api_version}/accounts/{account_id}/billing_preferences";

    public const string AccountCancel = "/api/{api_version}/accounts/{account_id}/cancel";

    public const string AccountContacts = "/api/{api_version}/accounts/{account_id}/contacts";

    public const string AccountCreditNotes = "/api/{api_version}/accounts/{account_id}/credit_notes";

    public const string AccountCustomObjects = "/api/{api_version}/accounts/{account_id}/custom_objects";

    public const string AccountImage = "/api/{api_version}/accounts/{account_id}/image";

    public const string AccountInformation = "/api/{api_version}/accounts/{account_id}/information";

    public const string AccountInventories = "/api/{api_version}/accounts/{account_id}/inventories";

    public const string AccountInvoices = "/api/{api_version}/accounts/{account_id}/invoices";

    public const string AccountNotes = "/api/{api_version}/accounts/{account_id}/notes";

    public const string AccountOrders = "/api/{api_version}/accounts/{account_id}/orders";

    public const string AccountPaymentMethods = "/api/{api_version}/accounts/{account_id}/payment_methods";

    public const string AccountPayments = "/api/{api_version}/accounts/{account_id}/payments";

    public const string AccountPurchaseInvoices = "/api/{api_version}/accounts/{account_id}/purchase_invoices";

    public const string AccountPurchaseOrders = "/api/{api_version}/accounts/{account_id}/purchase_orders";

    public const string AccountPurchasePayments = "/api/{api_version}/accounts/{account_id}/purchase_payments";

    public const string AccountPurchaseRefunds = "/api/{api_version}/accounts/{account_id}/purchase_refunds";

    public const string AccountQuotePartialInvoices = "/api/{api_version}/accounts/{account_id}/quote_partial_invoices";

    public const string AccountRefunds = "/api/{api_version}/accounts/{account_id}/refunds";

    public const string AccountSetPassword = "/api/{api_version}/accounts/{account_id}/set-password";

    public const string AccountAddress = "/api/{api_version}/accounts/{account_id}/addresses/{sub_address_id}";

    public const string AccountCommunicationsEmails = "/api/{api_version}/accounts/{account_id}/communications/emails";

    public const string AccountContact = "/api/{api_version}/accounts/{account_id}/contacts/{sub_contact_id}";

    public const string AccountNote = "/api/{api_version}/accounts/{account_id}/notes/{account_note_id}";

    public const string AccountPaymentMethod = "/api/{api_version}/accounts/{account_id}/payment_methods/{sub_pm_id}";

    public const string AccountCommunicationsEmail = "/api/{api_version}/accounts/{account_id}/communications/emails/{email_id}";

    public const string AccountNoteFiles = "/api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files";

    public const string AccountNoteFile = "/api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files/{file_uuid}";

    public const string AccountKpis = "/api/{api_version}/accounts/{account_id}/kpis";

    public const string AccountFinancialSummary = "/api/{api_version}/accounts/{account_id}/financial_summary";

    public const string AccountCustomObject = "/api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}";

    public const string AccountCustomObjectInstanceOf = "/api/{api_version}/accounts/{account_id}/custom_objects/{custom_object_id}/instances/{custom_object_instance_id}";

    public const string AccountComponentObjects = "/api/{api_version}/accounts/{account_id}/component/{component_id}";

    public const string AccountComponentObject = "/api/{api_version}/accounts/{account_id}/component/{component_id}/{component_object_id}";

    public const string AccountReactivate = "/api/{api_version}/accounts/{account_id}/reactivate";

    public const string AccountCustomObjectInstance = "/api/{api_version}/accounts/{account_id}/custom_objects_instances/{custom_object_instance_id}";

    public const string AccountPurge = "/api/{api_version}/accounts/{account_id}/purge";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/accounts/{account_id}/communications/emails</c> and <c>GET /api/{api_version}/accounts/{account_id}/communications/emails/{email_id}</c>.</summary>
    public const string EmailKey = "email";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on the 22 endpoints its views were measured from.</summary>
    public const string AccountKey = "account";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files</c> and <c>GET /api/{api_version}/accounts/{account_id}/notes/{note_uuid}/files/{file_uuid}</c>.</summary>
    public const string FileKey = "file";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/accounts/{account_id}/kpis</c>.</summary>
    public const string AccountKpisKey = "account_kpis";

    /// <summary>The key one record arrives under, on the 8 endpoints its views were measured from.</summary>
    public const string CustomObjectKey = "custom_object";

    /// <summary>The key one record arrives under, on the 3 endpoints its views were measured from.</summary>
    public const string CustomComponentObjectKey = "custom_component_object";
}
