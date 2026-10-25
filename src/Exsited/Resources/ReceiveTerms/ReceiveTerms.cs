using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.ReceiveTerms.ReceiveTermsDto;

namespace Exsited.Resources.ReceiveTerms;

/// <summary>The v4 receive terms endpoints, as a typed resource bound to one client.</summary>
public sealed class ReceiveTerms : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ReceiveTerms</c>.</summary>
    public ReceiveTerms(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/receive_terms</c>.</summary>
    public Task<ApiResponse> GetSettingsReceiveTermsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReceiveTermsUrls.SettingsReceiveTerms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsReceiveTermList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/receive_terms</c>.</summary>
    public Task<ApiResponse> CreateSettingsReceiveTermAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ReceiveTermsUrls.SettingsReceiveTerms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsReceiveTerm),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/receive_terms/{receive_term_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsReceiveTermAsync(
        string receiveTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReceiveTermsUrls.SettingsReceiveTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["receive_term_id"] = receiveTermId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsReceiveTerm),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/receive_terms/{receive_term_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsReceiveTermAsync(
        string receiveTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ReceiveTermsUrls.SettingsReceiveTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["receive_term_id"] = receiveTermId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/receive_terms/{receive_term_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsReceiveTermAsync(
        string receiveTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(ReceiveTermsUrls.SettingsReceiveTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["receive_term_id"] = receiveTermId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsReceiveTerm),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ReceiveTerms.GetSettingsReceiveTermsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsReceiveTermsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReceiveTerms.GetSettingsReceiveTermsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReceiveTerms.CreateSettingsReceiveTermAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsReceiveTermAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReceiveTerms.CreateSettingsReceiveTermAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReceiveTerms.GetSettingsReceiveTermAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsReceiveTermAsync(
        ExsitedClient client,
        string receiveTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReceiveTerms.GetSettingsReceiveTermAsync(
            receiveTermId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReceiveTerms.DeleteSettingsReceiveTermAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsReceiveTermAsync(
        ExsitedClient client,
        string receiveTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReceiveTerms.DeleteSettingsReceiveTermAsync(
            receiveTermId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ReceiveTerms.UpdateSettingsReceiveTermAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsReceiveTermAsync(
        ExsitedClient client,
        string receiveTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ReceiveTerms.UpdateSettingsReceiveTermAsync(
            receiveTermId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
