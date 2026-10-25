namespace Exsited.Resources.DocumentTemplates.DocumentTemplatesDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsDocumentTemplate : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/document_templates",
        "GET /api/{api_version}/settings/document_templates/{document_template_id}",
        "POST /api/{api_version}/settings/document_templates",
        "PATCH /api/{api_version}/settings/document_templates/{document_template_id}",
    };

    protected override string? EnvelopeKey => "document_template";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsCustomTemplate { get; set; }

    public bool? IsDefault { get; set; }

    public bool? IsEdited { get; set; }

    public bool? IsSystemTemplate { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public string? Type { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="SettingsDocumentTemplate"/> records, under <c>data</c>.</summary>
public sealed class SettingsDocumentTemplateList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/document_templates",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsDocumentTemplate>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
