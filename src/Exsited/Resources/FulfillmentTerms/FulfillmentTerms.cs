using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.FulfillmentTerms.FulfillmentTermsDto;

namespace Exsited.Resources.FulfillmentTerms;

/// <summary>The v4 fulfillment terms endpoints, as a typed resource bound to one client.</summary>
public sealed class FulfillmentTerms : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.FulfillmentTerms</c>.</summary>
    public FulfillmentTerms(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/fulfillment_terms</c>.</summary>
    public Task<ApiResponse> GetSettingsFulfillmentTermsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(FulfillmentTermsUrls.SettingsFulfillmentTerms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentTermList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/fulfillment_terms</c>.</summary>
    public Task<ApiResponse> CreateSettingsFulfillmentTermAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(FulfillmentTermsUrls.SettingsFulfillmentTerms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentTerm),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/fulfillment_terms/{fulfillment_term_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsFulfillmentTermAsync(
        string fulfillmentTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(FulfillmentTermsUrls.SettingsFulfillmentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_term_id"] = fulfillmentTermId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentTerm),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/fulfillment_terms/{fulfillment_term_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsFulfillmentTermAsync(
        string fulfillmentTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(FulfillmentTermsUrls.SettingsFulfillmentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_term_id"] = fulfillmentTermId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/fulfillment_terms/{fulfillment_term_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsFulfillmentTermAsync(
        string fulfillmentTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(FulfillmentTermsUrls.SettingsFulfillmentTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["fulfillment_term_id"] = fulfillmentTermId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsFulfillmentTerm),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.FulfillmentTerms.GetSettingsFulfillmentTermsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFulfillmentTermsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentTerms.GetSettingsFulfillmentTermsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentTerms.CreateSettingsFulfillmentTermAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsFulfillmentTermAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentTerms.CreateSettingsFulfillmentTermAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentTerms.GetSettingsFulfillmentTermAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsFulfillmentTermAsync(
        ExsitedClient client,
        string fulfillmentTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentTerms.GetSettingsFulfillmentTermAsync(
            fulfillmentTermId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentTerms.DeleteSettingsFulfillmentTermAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsFulfillmentTermAsync(
        ExsitedClient client,
        string fulfillmentTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentTerms.DeleteSettingsFulfillmentTermAsync(
            fulfillmentTermId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.FulfillmentTerms.UpdateSettingsFulfillmentTermAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsFulfillmentTermAsync(
        ExsitedClient client,
        string fulfillmentTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.FulfillmentTerms.UpdateSettingsFulfillmentTermAsync(
            fulfillmentTermId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
