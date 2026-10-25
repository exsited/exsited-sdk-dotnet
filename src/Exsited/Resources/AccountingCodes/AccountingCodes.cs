using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.AccountingCodes.AccountingCodesDto;

namespace Exsited.Resources.AccountingCodes;

/// <summary>The v4 accounting codes endpoints, as a typed resource bound to one client.</summary>
public sealed class AccountingCodes : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AccountingCodes</c>.</summary>
    public AccountingCodes(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/accounting_codes</c>.</summary>
    public Task<ApiResponse> GetSettingsAccountingCodesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountingCodesUrls.SettingsAccountingCodes,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountingCodeList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/accounting_codes</c>.</summary>
    public Task<ApiResponse> CreateSettingsAccountingCodeAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AccountingCodesUrls.SettingsAccountingCodes,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountingCodes),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/accounting_codes/{accounting_code_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsAccountingCodeAsync(
        string accountingCodeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(AccountingCodesUrls.SettingsAccountingCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["accounting_code_id"] = accountingCodeId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountingCode),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/accounting_codes/{accounting_code_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsAccountingCodeAsync(
        string accountingCodeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(AccountingCodesUrls.SettingsAccountingCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["accounting_code_id"] = accountingCodeId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/accounting_codes/{accounting_code_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsAccountingCodeAsync(
        string accountingCodeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(AccountingCodesUrls.SettingsAccountingCode,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["accounting_code_id"] = accountingCodeId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsAccountingCodeUpdated),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.AccountingCodes.GetSettingsAccountingCodesAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAccountingCodesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountingCodes.GetSettingsAccountingCodesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountingCodes.CreateSettingsAccountingCodeAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsAccountingCodeAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountingCodes.CreateSettingsAccountingCodeAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountingCodes.GetSettingsAccountingCodeAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsAccountingCodeAsync(
        ExsitedClient client,
        string accountingCodeId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountingCodes.GetSettingsAccountingCodeAsync(
            accountingCodeId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountingCodes.DeleteSettingsAccountingCodeAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsAccountingCodeAsync(
        ExsitedClient client,
        string accountingCodeId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountingCodes.DeleteSettingsAccountingCodeAsync(
            accountingCodeId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.AccountingCodes.UpdateSettingsAccountingCodeAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsAccountingCodeAsync(
        ExsitedClient client,
        string accountingCodeId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AccountingCodes.UpdateSettingsAccountingCodeAsync(
            accountingCodeId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
