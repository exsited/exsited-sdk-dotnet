namespace Exsited.Resources.CustomForms.CustomFormsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsCustomForm : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_forms",
        "GET /api/{api_version}/settings/custom_forms/{custom_form_id}",
        "POST /api/{api_version}/settings/custom_forms",
        "PATCH /api/{api_version}/settings/custom_forms/{custom_form_id}",
    };

    protected override string? EnvelopeKey => "custom_form";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public bool? ForDefaultTemplate { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsSystemTemplate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsCustomForm"/> records, under <c>data</c>.</summary>
public sealed class SettingsCustomFormList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/custom_forms",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsCustomForm>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
