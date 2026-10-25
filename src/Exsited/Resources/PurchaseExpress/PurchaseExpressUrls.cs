namespace Exsited.Resources.PurchaseExpress;

/// <summary>Path templates and body keys for the v4 purchase express endpoints.</summary>
public static class PurchaseExpressUrls
{
    public const string PurchaseExpress = "/api/{api_version}/purchase_express";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/purchase_express</c>.</summary>
    public const string PurchaseExpressKey = "purchase_express";
}
