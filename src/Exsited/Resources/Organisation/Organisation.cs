using Exsited.Client;
using Exsited.Resources.Organisation.OrganisationDto;

namespace Exsited.Resources.Organisation;

/// <summary>The v4 organisation endpoints, as a typed resource bound to one client.</summary>
public sealed class Organisation : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.Organisation</c>.</summary>
    public Organisation(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>GET /api/{api_version}/settings/organisation</c>.</summary>
    public Task<ApiResponse> GetSettingsOrganisationAsync(
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        Client.SendGetRequestAsync(OrganisationUrls.SettingsOrganisation,
            new RequestOptions
            {
                QueryParams = queryParams,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
                DtoType = typeof(SettingsOrganisation),
            }, cancellationToken);

    /// <summary>The client-first form of <c>client.Organisation.GetSettingsOrganisationAsync</c>.</summary>
    public static Task<ApiResponse> GetSettingsOrganisationAsync(
        ExsitedClient client,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.Organisation.GetSettingsOrganisationAsync(
            queryParams, raiseOnError, cancellationToken, responseFormat);
}
