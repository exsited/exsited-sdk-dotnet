using Exsited.Client;
using Exsited.Errors;

namespace Exsited.Resources.ProformaInvoices;

/// <summary>The v4 proforma invoices endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class ProformaInvoices : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.ProformaInvoices</c>.</summary>
    public ProformaInvoices(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/proforma_invoices</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetProformaInvoicesAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ProformaInvoicesUrls.ProformaInvoices,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/proforma_invoices/{proforma_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetProformaInvoiceAsync(
        string proformaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ProformaInvoicesUrls.ProformaInvoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["proforma_id"] = proformaId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>DELETE /api/{api_version}/proforma_invoices/{proforma_id}</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> DeleteProformaInvoiceAsync(
        string proformaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendDeleteRequestAsync(ProformaInvoicesUrls.ProformaInvoice,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["proforma_id"] = proformaId },
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/proforma_invoices/{proforma_id}/payments</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> CreateProformaInvoicePaymentAsync(
        string proformaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(ProformaInvoicesUrls.ProformaInvoicePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["proforma_id"] = proformaId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.ProformaInvoices.GetProformaInvoicesAsync</c>.</summary>
    public static Task<ApiResponse> GetProformaInvoicesAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ProformaInvoices.GetProformaInvoicesAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ProformaInvoices.GetProformaInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> GetProformaInvoiceAsync(
        ExsitedClient client,
        string proformaId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ProformaInvoices.GetProformaInvoiceAsync(
            proformaId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ProformaInvoices.DeleteProformaInvoiceAsync</c>.</summary>
    public static Task<ApiResponse> DeleteProformaInvoiceAsync(
        ExsitedClient client,
        string proformaId,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ProformaInvoices.DeleteProformaInvoiceAsync(
            proformaId, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.ProformaInvoices.CreateProformaInvoicePaymentAsync</c>.</summary>
    public static Task<ApiResponse> CreateProformaInvoicePaymentAsync(
        ExsitedClient client,
        string proformaId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.ProformaInvoices.CreateProformaInvoicePaymentAsync(
            proformaId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
