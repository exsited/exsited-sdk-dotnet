namespace Exsited.Resources.Portals;

/// <summary>Path templates and body keys for the v4 portals endpoints.</summary>
public static class PortalsUrls
{
    public const string PortalActivate = "/api/{api_version}/portal/activate";

    public const string PortalChangePassword = "/api/{api_version}/portal/change_password";

    public const string PortalLogin = "/api/{api_version}/portal/login";

    public const string PortalReset = "/api/{api_version}/portal/reset";

    public const string PortalResetLink = "/api/{api_version}/portal/reset_link";

    public const string PortalValidate = "/api/{api_version}/portal/validate";

    public const string PortalChange = "/api/{api_version}/portal/change";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/portal/change_password</c> and <c>POST /api/{api_version}/portal/login</c>.</summary>
    public const string PortalKey = "portal";
}
