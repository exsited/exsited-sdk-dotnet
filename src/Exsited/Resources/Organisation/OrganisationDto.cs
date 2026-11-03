namespace Exsited.Resources.Organisation.OrganisationDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsOrganisation : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/organisation",
    };

    protected override string? EnvelopeKey => "organization";

    /// <summary>Untyped.</summary>
    [WireName("address_line1")]
    public object? AddressLine1 { get; set; }

    /// <summary>Untyped.</summary>
    [WireName("address_line2")]
    public object? AddressLine2 { get; set; }

    /// <summary>Untyped.</summary>
    [WireName("address_line3")]
    public object? AddressLine3 { get; set; }

    /// <summary>Untyped.</summary>
    [WireName("address_line4")]
    public object? AddressLine4 { get; set; }

    /// <summary>Untyped.</summary>
    [WireName("address_line5")]
    public object? AddressLine5 { get; set; }

    /// <summary>Untyped.</summary>
    public object? City { get; set; }

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Untyped.</summary>
    public object? Details { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Email { get; set; }

    /// <summary>Untyped.</summary>
    public object? Fax { get; set; }

    /// <summary>Untyped.</summary>
    public object? FaxAreaCode { get; set; }

    /// <summary>Untyped.</summary>
    public object? FaxCountryCode { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? Mobile { get; set; }

    /// <summary>Untyped.</summary>
    public object? MobileAreaCode { get; set; }

    /// <summary>Untyped.</summary>
    public object? MobileCountryCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Untyped.</summary>
    public IReadOnlyList<object?>? Nodes { get; set; }

    public string? Object { get; set; }

    public SettingsOrganisationParentOrganization? ParentOrganization { get; set; }

    /// <summary>Untyped.</summary>
    public object? Phone { get; set; }

    /// <summary>Untyped.</summary>
    public object? PhoneAreaCode { get; set; }

    /// <summary>Untyped.</summary>
    public object? PhoneCountryCode { get; set; }

    /// <summary>Untyped.</summary>
    public object? PostCode { get; set; }

    /// <summary>Untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    /// <summary>Untyped.</summary>
    public object? Website { get; set; }
}

/// <summary>An object sent as <c>parent_organization</c>.</summary>
public sealed class SettingsOrganisationParentOrganization : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
