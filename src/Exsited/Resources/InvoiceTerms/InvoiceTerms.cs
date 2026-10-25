using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.InvoiceTerms.InvoiceTermsDto;

namespace Exsited.Resources.InvoiceTerms;

/// <summary>The v4 invoice terms endpoints, as a typed resource bound to one client.</summary>
public sealed class InvoiceTerms : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.InvoiceTerms</c>.</summary>
    public InvoiceTerms(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/invoice_terms</c>.</summary>
    public Task<ApiResponse> GetSettingsInvoiceTermsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoiceTermsUrls.SettingsInvoiceTerms,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsInvoiceTermList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/invoice_terms</c>.</summary>
    public Task<ApiResponse> CreateSettingsInvoiceTermAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(InvoiceTermsUrls.SettingsInvoiceTerms,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsInvoiceTermWrite),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/invoice_terms/{invoice_term_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsInvoiceTermAsync(
        string invoiceTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(InvoiceTermsUrls.SettingsInvoiceTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_term_id"] = invoiceTermId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsInvoiceTerm),
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/settings/invoice_terms/{invoice_term_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteSettingsInvoiceTermAsync(
        string invoiceTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(InvoiceTermsUrls.SettingsInvoiceTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_term_id"] = invoiceTermId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/invoice_terms/{invoice_term_id}</c>.</summary>
    public Task<ApiResponse> UpdateSettingsInvoiceTermAsync(
        string invoiceTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(InvoiceTermsUrls.SettingsInvoiceTerm,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_term_id"] = invoiceTermId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsInvoiceTermWrite),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.InvoiceTerms.GetSettingsInvoiceTermsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsInvoiceTermsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InvoiceTerms.GetSettingsInvoiceTermsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.InvoiceTerms.CreateSettingsInvoiceTermAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsInvoiceTermAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InvoiceTerms.CreateSettingsInvoiceTermAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.InvoiceTerms.GetSettingsInvoiceTermAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsInvoiceTermAsync(
        ExsitedClient client,
        string invoiceTermId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InvoiceTerms.GetSettingsInvoiceTermAsync(
            invoiceTermId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.InvoiceTerms.DeleteSettingsInvoiceTermAsync</c>.</summary>
    public static Task<ApiResponse> DeleteSettingsInvoiceTermAsync(
        ExsitedClient client,
        string invoiceTermId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InvoiceTerms.DeleteSettingsInvoiceTermAsync(
            invoiceTermId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.InvoiceTerms.UpdateSettingsInvoiceTermAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsInvoiceTermAsync(
        ExsitedClient client,
        string invoiceTermId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.InvoiceTerms.UpdateSettingsInvoiceTermAsync(
            invoiceTermId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
