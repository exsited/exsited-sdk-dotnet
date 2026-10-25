using Exsited.Client;

namespace Exsited.Resources.Reconciliations;

/// <summary>The v4 reconciliations endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class Reconciliations : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Reconciliations</c>.</summary>
    public Reconciliations(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/reconciliations/{reconciliation_id}/sale_payments</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReconciliationSalePaymentsAsync(
        string reconciliationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReconciliationsUrls.ReconciliationSalePayments,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["reconciliation_id"] = reconciliationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary><c>GET /api/{api_version}/reconciliations/{reconciliation_id}/sale_refunds</c>; no typed view, so read <c>Map</c>.</summary>
    public Task<ApiResponse> GetReconciliationSaleRefundsAsync(
        string reconciliationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(ReconciliationsUrls.ReconciliationSaleRefunds,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["reconciliation_id"] = reconciliationId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Reconciliations.GetReconciliationSalePaymentsAsync</c>.</summary>
    public static Task<ApiResponse> GetReconciliationSalePaymentsAsync(
        ExsitedClient client,
        string reconciliationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reconciliations.GetReconciliationSalePaymentsAsync(
            reconciliationId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Reconciliations.GetReconciliationSaleRefundsAsync</c>.</summary>
    public static Task<ApiResponse> GetReconciliationSaleRefundsAsync(
        ExsitedClient client,
        string reconciliationId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Reconciliations.GetReconciliationSaleRefundsAsync(
            reconciliationId, queryParams, raiseOnError, cancellationToken, responseFormat);
}
