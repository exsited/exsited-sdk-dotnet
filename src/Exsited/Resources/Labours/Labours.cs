using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Labours.LaboursDto;

namespace Exsited.Resources.Labours;

/// <summary>The v4 labours endpoints, as a typed resource bound to one client.</summary>
public sealed class Labours : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Labours</c>.</summary>
    public Labours(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/labour_availability</c>.</summary>
    public Task<ApiResponse> GetLabourAvailabilityAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourAvailability,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourAvailabilityList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/labour_profiles</c>.</summary>
    public Task<ApiResponse> GetLabourProfilesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourProfiles,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourProfileList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/labour_profiles</c>.</summary>
    public Task<ApiResponse> CreateLabourProfileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(LaboursUrls.LabourProfiles,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourProfiles),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/labours</c>.</summary>
    public Task<ApiResponse> GetLaboursAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.Labours,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/labours</c>.</summary>
    public Task<ApiResponse> CreateLabourAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(LaboursUrls.Labours,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LaboursView),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/labour_profiles/{labour_profile_id}</c>.</summary>
    public Task<ApiResponse> GetLabourProfileAsync(
        string labourProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_profile_id"] = labourProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourProfileRead),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/labour_profiles/{labour_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateLabourProfileAsync(
        string labourProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(LaboursUrls.LabourProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_profile_id"] = labourProfileId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/labour_profiles/{labour_profile_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteLabourProfileAsync(
        string labourProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(LaboursUrls.LabourProfile,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_profile_id"] = labourProfileId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/labours/available_for_booking</c>.</summary>
    public Task<ApiResponse> GetLaboursAvailableForBookingAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LaboursAvailableForBooking,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourList),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/labours/{labour_uuid}</c>.</summary>
    public Task<ApiResponse> UpdateLabourAsync(
        string labourUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(LaboursUrls.Labour,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_uuid"] = labourUuid },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourUpdated),
            }, cancellationToken);
    }

    /// <summary><c>DELETE /api/{api_version}/labours/{labour_uuid}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteLabourAsync(
        string labourUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(LaboursUrls.Labour,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_uuid"] = labourUuid },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/labours/{labour_uuid}</c>.</summary>
    public Task<ApiResponse> GetLabourAsync(
        string labourUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.Labour,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_uuid"] = labourUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(Labour),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/labours/{labour_id}/cancel</c>.</summary>
    public Task<ApiResponse> CancelLabourAsync(
        string labourId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(LaboursUrls.LabourCancel,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_id"] = labourId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourCancel),
            }, cancellationToken);
    }

    /// <summary><c>POST /api/{api_version}/labours/{labour_id}/reactivate</c>.</summary>
    public Task<ApiResponse> ReactivateLabourAsync(
        string labourId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(LaboursUrls.LabourReactivate,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_id"] = labourId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourReactivate),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/labours/{labour_uuid}/orders</c>.</summary>
    public Task<ApiResponse> GetLabourOrdersAsync(
        string labourUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourOrders,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_uuid"] = labourUuid },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourOrderList),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/labour_availability</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateLabourAvailabilityAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(LaboursUrls.LabourAvailability,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/labour_profiles/{labour_profile_id}/sessions</c>.</summary>
    public Task<ApiResponse> GetLabourProfileSessionsAsync(
        string labourProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourProfileSessions,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_profile_id"] = labourProfileId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourProfileSessionList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/labour_profiles/{labour_profile_id}/sessions/{session_id}</c>.</summary>
    public Task<ApiResponse> GetLabourProfileSessionAsync(
        string labourProfileId, string sessionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourProfileSession,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_profile_id"] = labourProfileId, ["session_id"] = sessionId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourProfileSessionView),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/labours/{labour_id}/availability</c>.</summary>
    public Task<ApiResponse> GetLabourCalendarAsync(
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(LaboursUrls.LabourCalendar,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["labour_id"] = labourId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(LabourCalendar),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Labours.GetLabourAvailabilityAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourAvailabilityAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourAvailabilityAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourProfilesAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourProfilesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourProfilesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.CreateLabourProfileAsync</c>.</summary>
    public static Task<ApiResponse> CreateLabourProfileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.CreateLabourProfileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLaboursAsync</c>.</summary>
    public static Task<ApiResponse> GetLaboursAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLaboursAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.CreateLabourAsync</c>.</summary>
    public static Task<ApiResponse> CreateLabourAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.CreateLabourAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourProfileAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourProfileAsync(
        ExsitedClient client,
        string labourProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourProfileAsync(
            labourProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.UpdateLabourProfileAsync</c>.</summary>
    public static Task<ApiResponse> UpdateLabourProfileAsync(
        ExsitedClient client,
        string labourProfileId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.UpdateLabourProfileAsync(
            labourProfileId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.DeleteLabourProfileAsync</c>.</summary>
    public static Task<ApiResponse> DeleteLabourProfileAsync(
        ExsitedClient client,
        string labourProfileId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.DeleteLabourProfileAsync(
            labourProfileId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLaboursAvailableForBookingAsync</c>.</summary>
    public static Task<ApiResponse> GetLaboursAvailableForBookingAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLaboursAvailableForBookingAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.UpdateLabourAsync</c>.</summary>
    public static Task<ApiResponse> UpdateLabourAsync(
        ExsitedClient client,
        string labourUuid, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.UpdateLabourAsync(
            labourUuid, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.DeleteLabourAsync</c>.</summary>
    public static Task<ApiResponse> DeleteLabourAsync(
        ExsitedClient client,
        string labourUuid,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.DeleteLabourAsync(
            labourUuid, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourAsync(
        ExsitedClient client,
        string labourUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourAsync(
            labourUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.CancelLabourAsync</c>.</summary>
    public static Task<ApiResponse> CancelLabourAsync(
        ExsitedClient client,
        string labourId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.CancelLabourAsync(
            labourId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.ReactivateLabourAsync</c>.</summary>
    public static Task<ApiResponse> ReactivateLabourAsync(
        ExsitedClient client,
        string labourId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.ReactivateLabourAsync(
            labourId, payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourOrdersAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourOrdersAsync(
        ExsitedClient client,
        string labourUuid, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourOrdersAsync(
            labourUuid, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.UpdateLabourAvailabilityAsync</c>.</summary>
    public static Task<ApiResponse> UpdateLabourAvailabilityAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.UpdateLabourAvailabilityAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourProfileSessionsAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourProfileSessionsAsync(
        ExsitedClient client,
        string labourProfileId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourProfileSessionsAsync(
            labourProfileId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourProfileSessionAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourProfileSessionAsync(
        ExsitedClient client,
        string labourProfileId, string sessionId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourProfileSessionAsync(
            labourProfileId, sessionId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Labours.GetLabourCalendarAsync</c>.</summary>
    public static Task<ApiResponse> GetLabourCalendarAsync(
        ExsitedClient client,
        string labourId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Labours.GetLabourCalendarAsync(
            labourId, queryParams, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
