namespace Exsited.Resources.Operators;

/// <summary>Path templates and body keys for the v4 operators endpoints.</summary>
public static class OperatorsUrls
{
    public const string SettingsOperators = "/api/{api_version}/settings/operators";

    public const string SettingsOperator = "/api/{api_version}/settings/operators/{operator_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under.</summary>
    public const string OperatorKey = "operator";
}
