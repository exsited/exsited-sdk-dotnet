using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.AdditionalCodes.AdditionalCodesDto;

namespace Exsited.Resources.AdditionalCodes;

/// <summary>The v4 additional codes endpoints, as a typed resource bound to one client.</summary>
public sealed class AdditionalCodes : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AdditionalCodes</c>.</summary>
    public AdditionalCodes(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/additional_codes</c>.</summary>
    public Task<ApiResponse> GetSettingsAdditionalCodesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AdditionalCodesUrls.SettingsAdditionalCodes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAdditionalCodeList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/additional_codes</c>.</summary>
    public Task<ApiResponse> CreateSettingsAdditionalCodeAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AdditionalCodesUrls.SettingsAdditionalCodes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAdditionalCode),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/additional_codes/{additional_code_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsAdditionalCodeAsync(
        string additionalCodeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AdditionalCodesUrls.SettingsAdditionalCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["additional_code_id"] = additionalCodeId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAdditionalCode),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/additional_codes/{additional_code_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsAdditionalCodeAsync(
        string additionalCodeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AdditionalCodesUrls.SettingsAdditionalCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["additional_code_id"] = additionalCodeId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/additional_codes/{additional_code_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> UpdateSettingsAdditionalCodeAsync(
        string additionalCodeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AdditionalCodesUrls.SettingsAdditionalCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["additional_code_id"] = additionalCodeId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.AdditionalCodes.GetSettingsAdditionalCodesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAdditionalCodesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AdditionalCodes.GetSettingsAdditionalCodesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AdditionalCodes.CreateSettingsAdditionalCodeAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsAdditionalCodeAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AdditionalCodes.CreateSettingsAdditionalCodeAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AdditionalCodes.GetSettingsAdditionalCodeAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAdditionalCodeAsync(
        ExsitedClient client,
        string additionalCodeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AdditionalCodes.GetSettingsAdditionalCodeAsync(
            additionalCodeId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AdditionalCodes.DeleteSettingsAdditionalCodeAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsAdditionalCodeAsync(
        ExsitedClient client,
        string additionalCodeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AdditionalCodes.DeleteSettingsAdditionalCodeAsync(
            additionalCodeId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AdditionalCodes.UpdateSettingsAdditionalCodeAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsAdditionalCodeAsync(
        ExsitedClient client,
        string additionalCodeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AdditionalCodes.UpdateSettingsAdditionalCodeAsync(
            additionalCodeId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
