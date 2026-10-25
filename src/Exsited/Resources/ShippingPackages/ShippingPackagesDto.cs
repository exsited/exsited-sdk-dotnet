namespace Exsited.Resources.ShippingPackages.ShippingPackagesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsShippingPackage : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_packages",
        "GET /api/{api_version}/settings/shipping_packages/{shipping_package_id}",
        "POST /api/{api_version}/settings/shipping_packages",
        "PATCH /api/{api_version}/settings/shipping_packages/{shipping_package_id}",
    };

    protected override string? EnvelopeKey => "shipping_package";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Cubic { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CubicUom { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public double? Height { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? HeightUom { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public double? Length { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LengthUom { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public double? Weight { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WeightUom { get; set; }

    public double? Width { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? WidthUom { get; set; }
}

/// <summary>One page of <see cref="SettingsShippingPackage"/> records, under <c>data</c>.</summary>
public sealed class SettingsShippingPackageList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_packages",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsShippingPackage>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
