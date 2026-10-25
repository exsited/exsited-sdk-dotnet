namespace Exsited.Resources.Express;

/// <summary>Path templates for the v4 express endpoints.</summary>
public static class ExpressUrls
{
    public const string Express = "/api/{api_version}/express";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/express</c>.</summary>
    public const string ExpressKey = "express";
}
