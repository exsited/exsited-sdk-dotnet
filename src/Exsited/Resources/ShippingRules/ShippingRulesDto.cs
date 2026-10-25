namespace Exsited.Resources.ShippingRules.ShippingRulesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsShippingRule : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_rules",
        "GET /api/{api_version}/settings/shipping_rules/{shipping_rule_id}",
        "POST /api/{api_version}/settings/shipping_rules",
        "PATCH /api/{api_version}/settings/shipping_rules/{shipping_rule_id}",
    };

    protected override string? EnvelopeKey => "shipping_rule";

    public SettingsShippingRuleConfiguration? Configuration { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? ShippingClass { get; set; }

    public string? Status { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsShippingRule"/> records, under <c>data</c>.</summary>
public sealed class SettingsShippingRuleList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/shipping_rules",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsShippingRule>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>An object sent as <c>configuration</c>, merged over every record measured.</summary>
public sealed class SettingsShippingRuleConfiguration : Dto
{
    /// <summary>Null in every record measured, so untyped.</summary>
    public object? Rate { get; set; }

    /// <summary>Empty in every record measured, so untyped.</summary>
    public IReadOnlyList<object?>? Zones { get; set; }
}
