using Exsited.Client;
using Exsited.Resources.CreditNoteApplications.CreditNoteApplicationsDto;

namespace Exsited.Resources.CreditNoteApplications;

/// <summary>The v4 credit note applications endpoints, as a typed resource bound to one client.</summary>
public sealed class CreditNoteApplications : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.CreditNoteApplications</c>.</summary>
    public CreditNoteApplications(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/credit_note_applications</c>.</summary>
    public Task<ApiResponse> GetCreditNoteApplicationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNoteApplicationsUrls.CreditNoteApplications,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteApplicationList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/credit_note_applications/{credit_note_application_id}</c>.</summary>
    public Task<ApiResponse> GetCreditNoteApplicationAsync(
        string creditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNoteApplicationsUrls.CreditNoteApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["credit_note_application_id"] = creditNoteApplicationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(CreditNoteApplicationRead),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/invoices/{invoice_id}/credit_note_applications</c>.</summary>
    public Task<ApiResponse> GetInvoiceCreditNoteApplicationsAsync(
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(CreditNoteApplicationsUrls.InvoiceCreditNoteApplications,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["invoice_id"] = invoiceId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(InvoiceCreditNoteApplications),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.CreditNoteApplications.GetCreditNoteApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteApplicationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNoteApplications.GetCreditNoteApplicationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNoteApplications.GetCreditNoteApplicationAsync</c>.</summary>
    public static Task<ApiResponse> GetCreditNoteApplicationAsync(
        ExsitedClient client,
        string creditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNoteApplications.GetCreditNoteApplicationAsync(
            creditNoteApplicationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.CreditNoteApplications.GetInvoiceCreditNoteApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetInvoiceCreditNoteApplicationsAsync(
        ExsitedClient client,
        string invoiceId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.CreditNoteApplications.GetInvoiceCreditNoteApplicationsAsync(
            invoiceId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
