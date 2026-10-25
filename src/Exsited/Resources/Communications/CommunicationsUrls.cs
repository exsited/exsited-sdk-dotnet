namespace Exsited.Resources.Communications;

/// <summary>Path templates and body keys for the v4 communications endpoints.</summary>
public static class CommunicationsUrls
{
    public const string CommunicationsSendEmail = "/api/{api_version}/communications/send_email";

    /// <summary>A record key no view in this family unwraps.</summary>
    public const string EmailKey = "email";
}
