namespace Exsited.Resources.EmailTemplates.EmailTemplatesDto;

/// <summary>A typed view of the response body.</summary>
public sealed class SettingsEmailTemplate : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/email_templates",
        "GET /api/{api_version}/settings/email_templates/{email_template_id}",
        "POST /api/{api_version}/settings/email_templates",
        "PATCH /api/{api_version}/settings/email_templates/{email_template_id}",
    };

    protected override string? EnvelopeKey => "email_template";

    /// <summary>Untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Entity { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsEdited { get; set; }

    public bool? IsSystemTemplate { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    /// <summary>Untyped.</summary>
    public object? ReplyAddress { get; set; }

    public bool? RichEditor { get; set; }

    /// <summary>Untyped.</summary>
    public object? SenderAddress { get; set; }

    /// <summary>Untyped.</summary>
    public object? SenderName { get; set; }

    public string? Status { get; set; }

    public string? Subject { get; set; }

    public bool? TrackEmailOpen { get; set; }

    public bool? TrackLinkClick { get; set; }
}

/// <summary>One page of <see cref="SettingsEmailTemplate"/> records, under <c>data</c>.</summary>
public sealed class SettingsEmailTemplateList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/email_templates",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsEmailTemplate>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
