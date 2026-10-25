namespace Exsited.Resources.Labours;

/// <summary>Path templates and body keys for the v4 labours endpoints.</summary>
public static class LaboursUrls
{
    public const string LabourAvailability = "/api/{api_version}/labour_availability";

    public const string LabourProfiles = "/api/{api_version}/labour_profiles";

    public const string Labours = "/api/{api_version}/labours";

    public const string LabourProfile = "/api/{api_version}/labour_profiles/{labour_profile_id}";

    public const string LaboursAvailableForBooking = "/api/{api_version}/labours/available_for_booking";

    public const string Labour = "/api/{api_version}/labours/{labour_uuid}";

    public const string LabourCancel = "/api/{api_version}/labours/{labour_id}/cancel";

    public const string LabourReactivate = "/api/{api_version}/labours/{labour_id}/reactivate";

    public const string LabourOrders = "/api/{api_version}/labours/{labour_uuid}/orders";

    public const string LabourProfileSessions = "/api/{api_version}/labour_profiles/{labour_profile_id}/sessions";

    public const string LabourProfileSession = "/api/{api_version}/labour_profiles/{labour_profile_id}/sessions/{session_id}";

    public const string LabourCalendar = "/api/{api_version}/labours/{labour_id}/availability";

    /// <summary>The key a listing's records arrive under, the v4 envelope's own; the pagers' <c>recordKey</c>.</summary>
    public const string DataKey = "data";

    /// <summary>The key one record arrives under, on the 7 endpoints its views were measured from.</summary>
    public const string LabourKey = "labour";

    /// <summary>The key one record arrives under, on <c>POST /api/{api_version}/labour_profiles</c> and <c>GET /api/{api_version}/labour_profiles/{labour_profile_id}</c>.</summary>
    public const string LabourProfileKey = "labour_profile";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/labours/{labour_id}/availability</c>.</summary>
    public const string LabourCalendarKey = "labour_calendar";

    /// <summary>The key one record arrives under, on <c>GET /api/{api_version}/labour_profiles/{labour_profile_id}/sessions/{session_id}</c>.</summary>
    public const string LabourProfileSessionKey = "labour_profile_session";
}
