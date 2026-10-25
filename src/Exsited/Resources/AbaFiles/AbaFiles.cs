using Exsited.Client;
using Exsited.Errors;

namespace Exsited.Resources.AbaFiles;

/// <summary>The v4 aba files endpoints, as a typed resource bound to one client. None names a typed view: no success response was ever recorded to measure one from.</summary>
public sealed class AbaFiles : BoundResource
{
    /// <summary>Bind to a client; normally reached as <c>client.AbaFiles</c>.</summary>
    public AbaFiles(ExsitedClient client) : base(client)
    {
    }

    /// <summary><c>POST /api/{api_version}/aba_file/generate</c>.</summary>
    public Task<ApiResponse> GenerateAbaFileAsync(
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null)
    {
        RequirePayload(payload);
        return Client.SendPostRequestAsync(AbaFilesUrls.AbaFileGenerate,
            new RequestOptions
            {
                JsonBody = payload,
                RaiseOnError = raiseOnError,
                ResponseFormat = responseFormat,
            }, cancellationToken);
    }

    /// <summary>The client-first form of <c>client.AbaFiles.GenerateAbaFileAsync</c>.</summary>
    public static Task<ApiResponse> GenerateAbaFileAsync(
        ExsitedClient client,
        object payload,
        bool? raiseOnError = null, CancellationToken cancellationToken = default,
        string? responseFormat = null) =>
        client.AbaFiles.GenerateAbaFileAsync(
            payload, raiseOnError, cancellationToken, responseFormat);

    private static void RequirePayload(object payload)
    {
        if (payload is null)
            throw new SdkUsageError("payload is required: this endpoint takes a body, and null "
                + "would send the request with no body at all");
    }
}
