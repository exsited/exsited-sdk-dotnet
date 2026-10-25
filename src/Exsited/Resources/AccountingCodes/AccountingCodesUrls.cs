namespace Exsited.Resources.AccountingCodes;

/// <summary>Path templates and body keys for the v4 accounting codes endpoints.</summary>
public static class AccountingCodesUrls
{
    public const string SettingsAccountingCodes = "/api/{api_version}/settings/accounting_codes";

    public const string SettingsAccountingCode = "/api/{api_version}/settings/accounting_codes/{accounting_code_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string AccountingCodeKey = "accounting_code";
}
