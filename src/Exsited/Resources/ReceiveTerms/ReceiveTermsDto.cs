namespace Exsited.Resources.ReceiveTerms.ReceiveTermsDto;

/// <summary>The body the endpoints in <c>MeasuredFrom</c> answer.</summary>
public sealed class SettingsReceiveTerm : Dto
{
    /// <summary>The endpoints this view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/receive_terms",
        "GET /api/{api_version}/settings/receive_terms/{receive_term_id}",
        "POST /api/{api_version}/settings/receive_terms",
        "PATCH /api/{api_version}/settings/receive_terms/{receive_term_id}",
    };

    protected override string? EnvelopeKey => "receive_term";

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public long? Duration { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Null in every record measured, so untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Period { get; set; }

    public string? Status { get; set; }
}

/// <summary>One page of <see cref="SettingsReceiveTerm"/> records, under <c>data</c>.</summary>
public sealed class SettingsReceiveTermList : Dto
{
    /// <summary>The endpoints this page view was measured from.</summary>
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/settings/receive_terms",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<SettingsReceiveTerm>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}
