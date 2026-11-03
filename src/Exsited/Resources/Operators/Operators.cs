using Exsited.Client;
using Exsited.Errors;
using Exsited.Resources.Operators.OperatorsDto;

namespace Exsited.Resources.Operators;

/// <summary>The v4 operators endpoints, as a typed resource bound to one client.</summary>
public sealed class Operators : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Operators</c>.</summary>
    public Operators(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/operators</c>.</summary>
    public Task<ApiResponse> GetSettingsOperatorsAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OperatorsUrls.SettingsOperators,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperatorList),
            }, cancellationToken);

    /// <summary><c>POST /api/{api_version}/settings/operators</c>; <c>role</c> and <c>operator_group</c> take dashed uuids, and no route removes an operator.</summary>
    public Task<ApiResponse> CreateSettingsOperatorAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(OperatorsUrls.SettingsOperators,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperator),
            }, cancellationToken);
    }

    /// <summary><c>GET /api/{api_version}/settings/operators/{operator_id}</c>.</summary>
    public Task<ApiResponse> GetSettingsOperatorAsync(
        string operatorId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OperatorsUrls.SettingsOperator,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["operator_id"] = operatorId },
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperator),
            }, cancellationToken);

    /// <summary><c>PATCH /api/{api_version}/settings/operators/{operator_id}</c>; <c>description</c> is refused as not understood.</summary>
    public Task<ApiResponse> UpdateSettingsOperatorAsync(
        string operatorId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPatchRequestAsync(OperatorsUrls.SettingsOperator,
            new RequestOptions
            {
                PathParams = new Dictionary<string, object?> { ["operator_id"] = operatorId },
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOperator),
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.Operators.GetSettingsOperatorsAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOperatorsAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Operators.GetSettingsOperatorsAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Operators.CreateSettingsOperatorAsync</c>.</summary>
    public static Task<ApiResponse> CreateSettingsOperatorAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Operators.CreateSettingsOperatorAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Operators.GetSettingsOperatorAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOperatorAsync(
        ExsitedClient client,
        string operatorId, IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Operators.GetSettingsOperatorAsync(
            operatorId, queryParams, raiseOnError, cancellationToken, responseFormat);

    /// <summary>The client-first form of <c>client.Operators.UpdateSettingsOperatorAsync</c>.</summary>
    public static Task<ApiResponse> UpdateSettingsOperatorAsync(
        ExsitedClient client,
        string operatorId, object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Operators.UpdateSettingsOperatorAsync(
            operatorId, payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
