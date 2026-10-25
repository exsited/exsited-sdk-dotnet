using Exsited.Client;
using Exsited.Resources.PurchaseCreditNoteApplications.PurchaseCreditNoteApplicationsDto;

namespace Exsited.Resources.PurchaseCreditNoteApplications;

/// <summary>The v4 purchase credit note applications endpoints, as a typed resource bound to one client.</summary>
public sealed class PurchaseCreditNoteApplications : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.PurchaseCreditNoteApplications</c>.</summary>
    public PurchaseCreditNoteApplications(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/purchase_credit_note_applications</c>.</summary>
    public Task<ApiResponse> GetPurchaseCreditNoteApplicationsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseCreditNoteApplicationsUrls.PurchaseCreditNoteApplications,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteApplicationList),
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/purchase_credit_note_applications/{purchase_credit_note_applic ation_id}</c>.</summary>
    public Task<ApiResponse> GetPurchaseCreditNoteApplicationAsync(
        string purchaseCreditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(PurchaseCreditNoteApplicationsUrls.PurchaseCreditNoteApplication,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["purchase_credit_note_application_id"] = purchaseCreditNoteApplicationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(PurchaseCreditNoteApplicationRead),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.PurchaseCreditNoteApplications.GetPurchaseCreditNoteApplicationsAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseCreditNoteApplicationsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNoteApplications.GetPurchaseCreditNoteApplicationsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.PurchaseCreditNoteApplications.GetPurchaseCreditNoteApplicationAsync</c>.</summary>
    public static Task<ApiResponse> GetPurchaseCreditNoteApplicationAsync(
        ExsitedClient client,
        string purchaseCreditNoteApplicationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.PurchaseCreditNoteApplications.GetPurchaseCreditNoteApplicationAsync(
            purchaseCreditNoteApplicationId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
