namespace Exsited.Resources.ReturnVendorAuthorizations;

/// <summary>Path templates and body keys for the v4 return vendor authorizations endpoints.</summary>
public static class ReturnVendorAuthorizationsUrls
{
    public const string ReturnVendorAuthorizations = "/api/{api_version}/return_vendor_authorizations";

    public const string ReturnVendorAuthorization = "/api/{api_version}/return_vendor_authorizations/{rva_id}";

    public const string ReturnVendorAuthorizationNote = "/api/{api_version}/return_vendor_authorizations/{rva_id}/notes/{note_id}";

    public const string ReturnVendorAuthorizationNoteFile = "/api/{api_version}/return_vendor_authorizations/{rva_id}/notes/{note_id}/files/{file_id}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/return_vendor_authorizations/{rva_id}</c>.</summary>
    public const string ReturnVendorAuthorizationKey = "return_vendor_authorization";
}
