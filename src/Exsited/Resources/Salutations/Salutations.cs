using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Salutations.SalutationsDto;

namespace Exsited.Resources.Salutations;

/// <summary>The v4 salutations endpoints, as a typed resource bound to one client.</summary>
public sealed class Salutations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Salutations</c>.</summary>
    public Salutations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/salutations</c>.</summary>
    public Task<ApiResponse> GetSettingsSalutationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SalutationsUrls.SettingsSalutations,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalutationList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/salutations</c>.</summary>
    public Task<ApiResponse> CreateSettingsSalutationAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(SalutationsUrls.SettingsSalutations,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalutation),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/salutations/{salutation_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsSalutationAsync(
        string salutationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(SalutationsUrls.SettingsSalutation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["salutation_id"] = salutationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalutation),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/salutations/{salutation_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsSalutationAsync(
        string salutationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(SalutationsUrls.SettingsSalutation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["salutation_id"] = salutationId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/salutations/{salutation_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsSalutationAsync(
        string salutationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(SalutationsUrls.SettingsSalutation,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["salutation_id"] = salutationId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsSalutation),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Salutations.GetSettingsSalutationsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSalutationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Salutations.GetSettingsSalutationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Salutations.CreateSettingsSalutationAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsSalutationAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Salutations.CreateSettingsSalutationAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Salutations.GetSettingsSalutationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsSalutationAsync(
        ExsitedClient client,
        string salutationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Salutations.GetSettingsSalutationAsync(
            salutationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Salutations.DeleteSettingsSalutationAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsSalutationAsync(
        ExsitedClient client,
        string salutationId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Salutations.DeleteSettingsSalutationAsync(
            salutationId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Salutations.UpdateSettingsSalutationAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsSalutationAsync(
        ExsitedClient client,
        string salutationId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Salutations.UpdateSettingsSalutationAsync(
            salutationId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
