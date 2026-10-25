namespace Exsited.Resources.NoteGroups;

/// <summary>Path templates and body keys for the v4 note groups endpoints.</summary>
public static class NoteGroupsUrls
{
    public const string NoteGroups = "/api/{api_version}/note_groups";

    public const string NoteGroup = "/api/{api_version}/note_groups/{note_group_id}";

    public const string NoteGroupNotes = "/api/{api_version}/note_groups/{note_group_id}/notes";

    public const string NoteGroupNotesByUser = "/api/{api_version}/note_groups/{note_group_id}/notes/user/{note_user}";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 4 endpoints its views were measured from.</summary>
    public const string NoteGroupKey = "note_group";
}
