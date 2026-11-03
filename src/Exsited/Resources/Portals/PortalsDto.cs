namespace Exsited.Resources.Portals.PortalsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class PortalLogin : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/portal/login",
    };

    protected override string? EnvelopeKey => "portal";

    public IReadOnlyDictionary<string, object?>? User { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class PortalChangePassword : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/portal/change_password",
    };

    protected override string? EnvelopeKey => "portal";

    public string? Message { get; set; }
}
