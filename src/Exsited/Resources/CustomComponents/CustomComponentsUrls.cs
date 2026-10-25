namespace Exsited.Resources.CustomComponents;

/// <summary>Path templates and body keys for the v4 custom components endpoints.</summary>
public static class CustomComponentsUrls
{
    public const string Component = "/api/{api_version}/component";

    public const string ComponentByUuid = "/api/{api_version}/component/{component_uuid}";

    public const string ComponentById = "/api/{api_version}/component/{component_uuid}/{component_object_id}";

    public const string ComponentObjects = "/api/{api_version}/components/{component_uuid}/objects";

    public const string ComponentObject = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}";

    public const string ComponentObjectActivity = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity";

    public const string ComponentObjectCustomObjects = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects";

    public const string ComponentObjectPdf = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/pdf";

    public const string ComponentObjectActivityEntry = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity/{activity_id}";

    public const string ComponentObjectMilestones = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/milestones";

    public const string ComponentObjectMilestone = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/milestones/{milestone_id}";

    public const string ComponentObjectHistory = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/history";

    public const string ComponentObjectHistoryEntry = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/history/{history_id}";

    public const string ComponentObjectNotes = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes";

    public const string ComponentObjectNote = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}";

    public const string ComponentObjectNoteFiles = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files";

    public const string ComponentObjectNoteFile = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files/{file_id}";

    public const string ComponentObjectCustomObject = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}";

    public const string ComponentObjectCustomObjectInstance = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/custom_objects/{custom_object_id}/instances/{instance_id}";

    public const string ComponentObjectLinkDomains = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/link_domains";

    public const string ComponentObjectUnlinkDomains = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/unlink_domains";

    public const string ComponentObjectChangeStatus = "/api/{api_version}/components/{component_uuid}/objects/{component_object_id}/change_status";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/component</c> and <c>GET /api/{api_version}/component/{component_uuid}</c>.</summary>
    public const string ComponentKey = "component";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string AccCusCompKey = "Acc Cus Comp";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}</c>.</summary>
    public const string CustomComponentObjectKey = "custom_component_object";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity</c> and <c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/activity/{activity_id}</c>.</summary>
    public const string CustomComponentObjectActivityKey = "custom_component_object_activity";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string NoteKey = "note";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/components/{component_uuid}/objects/{component_object_id}/notes/{note_id}/files/{file_id}</c>.</summary>
    public const string FileKey = "file";
}
