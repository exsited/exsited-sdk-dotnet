namespace Exsited.Resources.Zones.ZonesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsZone : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/zones",
        "GET /api/{api_version}/settings/zones/{zone_id}",
        "POST /api/{api_version}/settings/zones",
        "PATCH /api/{api_version}/settings/zones/{zone_id}",
    };

    protected override string? EnvelopeKey => "zone";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsZone"/> records, under <c>data</c>.</summary>
public sealed class SettingsZoneList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/zones",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsZone>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
