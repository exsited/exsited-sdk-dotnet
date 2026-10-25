namespace Exsited.Resources.Portals.PortalsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PortalLogin : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/portal/login",
    };

    protected override string? EnvelopeKey => "portal";

    public IReadOnlyDictionary<string, object?>? User { get; set; }
}

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class PortalChangePassword : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/portal/change_password",
    };

    protected override string? EnvelopeKey => "portal";

    public string? Message { get; set; }
}
