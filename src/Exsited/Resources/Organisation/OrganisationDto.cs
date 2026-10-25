namespace Exsited.Resources.Organisation.OrganisationDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsOrganisation : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/organisation",
    };

    protected override string? EnvelopeKey => "organization";

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("address_line1")]
    public object? AddressLine1 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("address_line2")]
    public object? AddressLine2 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("address_line3")]
    public object? AddressLine3 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("address_line4")]
    public object? AddressLine4 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    [WireName("address_line5")]
    public object? AddressLine5 { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? City { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Description { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Details { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Email { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Fax { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? FaxAreaCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? FaxCountryCode { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Mobile { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? MobileAreaCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? MobileCountryCode { get; set; }

    public string? Name { get; set; }

    /// <summary>Empty in every record measured, so untyped.</summary>
    public IReadOnlyList<object?>? Nodes { get; set; }

    public string? Object { get; set; }

    public SettingsOrganisationParentOrganization? ParentOrganization { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Phone { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PhoneAreaCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PhoneCountryCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? PostCode { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? State { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Website { get; set; }
}

/// <summary>An object sent as <c>parent_organization</c>, merged over every record measured.</summary>
public sealed class SettingsOrganisationParentOrganization : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}
