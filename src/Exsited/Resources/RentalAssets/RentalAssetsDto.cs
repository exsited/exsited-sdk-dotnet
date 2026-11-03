namespace Exsited.Resources.RentalAssets.RentalAssetsDto;

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAsset : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_assets",
        "GET /api/{api_version}/rental_assets/{rental_asset_uuid}",
    };

    protected override string? EnvelopeKey => "rental_asset";

    public string? Code { get; set; }

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public IReadOnlyDictionary<string, object?>? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Item { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetAvailability { get; set; }

    public IReadOnlyList<object?>? RentalAssetCustomAvailability { get; set; }

    public IReadOnlyDictionary<string, object?>? RentalAssetProfile { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="RentalAsset"/> records, under <c>data</c>.</summary>
public sealed class RentalAssetList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_assets",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<RentalAsset>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetProfile : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_asset_profiles",
    };

    public IReadOnlyDictionary<string, object?>? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyDictionary<string, object?>? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsTaxInclusive { get; set; }

    public LastUpdatedByEntry? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetProfileSessions { get; set; }

    public IReadOnlyList<object?>? RentalAssets { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? Tax { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="RentalAssetProfile"/> records, under <c>data</c>.</summary>
public sealed class RentalAssetProfileList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_asset_profiles",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<RentalAssetProfile>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetAvailability : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_asset_availability",
    };

    public IReadOnlyList<object?>? AvailableList { get; set; }

    public string? Code { get; set; }

    public string? DisplayName { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public ProcessedScheduleList? ProcessedScheduleList { get; set; }

    public IReadOnlyDictionary<string, object?>? RentalAssetProfile { get; set; }

    public IReadOnlyList<ScheduleList>? ScheduleList { get; set; }

    public IReadOnlyList<object?>? SessionList { get; set; }

    public string? Status { get; set; }

    public IReadOnlyList<object?>? UnavailableList { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>One page of <see cref="RentalAssetAvailability"/> records, under <c>data</c>.</summary>
public sealed class RentalAssetAvailabilityList : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_asset_availability",
    };

    /// <summary>The records this page carried, under <c>data</c>.</summary>
    public IReadOnlyList<RentalAssetAvailability>? Data { get; set; }

    public string? Object { get; set; }

    /// <summary>The paging block, whichever shape this listing uses.</summary>
    public IReadOnlyDictionary<string, object?>? Pagination { get; set; }

    public string? Url { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetProfileRead : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "GET /api/{api_version}/rental_asset_profiles/{rental_asset_profile_id}",
    };

    protected override string? EnvelopeKey => "rental_asset_profile";

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsTaxInclusive { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<RentalAssetProfileSession>? RentalAssetProfileSessions { get; set; }

    public IReadOnlyList<RentalAssetEntry>? RentalAssets { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? Tax { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetProfiles : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/rental_asset_profiles",
    };

    protected override string? EnvelopeKey => "rental_asset_profile";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public Currency? Currency { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    public bool? IsTaxInclusive { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    /// <summary>Untyped.</summary>
    public object? MaxBookingLimit { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<RentalAssetProfileSession>? RentalAssetProfileSessions { get; set; }

    public IReadOnlyList<object?>? RentalAssets { get; set; }

    public string? Status { get; set; }

    /// <summary>Untyped.</summary>
    public object? Tax { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetsView : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/rental_assets",
    };

    protected override string? EnvelopeKey => "rental_asset";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    /// <summary>Untyped.</summary>
    public object? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Item { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedBy { get; set; }

    /// <summary>Untyped.</summary>
    public object? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetAvailability { get; set; }

    public IReadOnlyList<object?>? RentalAssetCustomAvailability { get; set; }

    public RentalAssetProfileEntry? RentalAssetProfile { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetUpdated : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "PATCH /api/{api_version}/rental_assets/{rental_asset_uuid}",
    };

    protected override string? EnvelopeKey => "rental_asset";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Item { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetAvailability { get; set; }

    public IReadOnlyList<object?>? RentalAssetCustomAvailability { get; set; }

    public RentalAssetProfileEntry? RentalAssetProfile { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetCancel : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/rental_assets/{rental_asset_id}/cancel",
    };

    protected override string? EnvelopeKey => "rental_asset";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Item { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetAvailability { get; set; }

    public IReadOnlyList<object?>? RentalAssetCustomAvailability { get; set; }

    public RentalAssetProfileEntry? RentalAssetProfile { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>A typed view of the response body.</summary>
public sealed class RentalAssetReactivate : Dto
{
    public static readonly IReadOnlyList<string> MeasuredFrom = new[]
    {
        "POST /api/{api_version}/rental_assets/{rental_asset_id}/reactivate",
    };

    protected override string? EnvelopeKey => "rental_asset";

    public IReadOnlyList<object?>? ActivityLogs { get; set; }

    public string? Code { get; set; }

    public CreatedBy? CreatedBy { get; set; }

    public string? CreatedOn { get; set; }

    public IReadOnlyList<object?>? CustomAttributes { get; set; }

    public CustomForm? CustomForm { get; set; }

    public string? Description { get; set; }

    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    /// <summary>Untyped.</summary>
    public object? Item { get; set; }

    public LastUpdatedBy? LastUpdatedBy { get; set; }

    public string? LastUpdatedOn { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<object?>? RentalAssetAvailability { get; set; }

    public IReadOnlyList<object?>? RentalAssetCustomAvailability { get; set; }

    public RentalAssetProfileEntry? RentalAssetProfile { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }

    public long? Version { get; set; }
}

/// <summary>An object sent as <c>currency</c>.</summary>
public sealed class Currency : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>rental_assets</c>.</summary>
public sealed class RentalAssetEntry : Dto
{
    public string? DisplayName { get; set; }

    public string? Href { get; set; }

    public string? Id { get; set; }

    /// <summary>Untyped.</summary>
    public object? ImageName { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public string? Status { get; set; }

    public bool? UseCustomAvailability { get; set; }
}

/// <summary>One entry of a list sent as <c>rental_asset_profile_sessions</c>.</summary>
public sealed class RentalAssetProfileSession : Dto
{
    public string? EndDate { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }

    public IReadOnlyList<RentalAssetProfileSessionAvailability>? RentalAssetProfileSessionAvailability { get; set; }

    public IReadOnlyList<RentalAssetProfileSessionPrice>? RentalAssetProfileSessionPrices { get; set; }

    public IReadOnlyList<RentalAssetProfileSessionWorkingHour>? RentalAssetProfileSessionWorkingHours { get; set; }

    public string? StartDate { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>created_by</c>.</summary>
public sealed class CreatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedBy : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>rental_asset_profile</c>.</summary>
public sealed class RentalAssetProfileEntry : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>An object sent as <c>custom_form</c>.</summary>
public sealed class CustomForm : Dto
{
    public string? Href { get; set; }

    public string? Id { get; set; }

    public string? Name { get; set; }

    public string? Object { get; set; }
}

/// <summary>One entry of a list sent as <c>schedule_list</c>.</summary>
public sealed class ScheduleList : Dto
{
    public string? Available { get; set; }

    public string? EndTime { get; set; }

    public string? PreferredDay { get; set; }

    public string? StartTime { get; set; }

    public string? Uuid { get; set; }
}

/// <summary>An object sent as <c>processed_schedule_list</c>.</summary>
public sealed class ProcessedScheduleList : Dto
{

}

/// <summary>One entry of a list sent as <c>rental_asset_profile_session_prices</c>.</summary>
public sealed class RentalAssetProfileSessionPrice : Dto
{
    public string? Id { get; set; }

    public bool? IsEnabledProRata { get; set; }

    public string? Object { get; set; }

    public double? Price { get; set; }

    public string? PriceType { get; set; }

    /// <summary>Untyped.</summary>
    public object? PricingLevel { get; set; }

    public IReadOnlyList<object?>? RentalAssetProfileSessionPriceHours { get; set; }

    public IReadOnlyList<object?>? RentalAssetProfileSessionPricePeakHourly { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>rental_asset_profile_session_availability</c>.</summary>
public sealed class RentalAssetProfileSessionAvailability : Dto
{
    public bool? Available { get; set; }

    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? PreferredDay { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>One entry of a list sent as <c>rental_asset_profile_session_working_hours</c>.</summary>
public sealed class RentalAssetProfileSessionWorkingHour : Dto
{
    public string? EndTime { get; set; }

    public string? Id { get; set; }

    public string? Object { get; set; }

    public string? StartTime { get; set; }

    public string? Status { get; set; }
}

/// <summary>An object sent as <c>last_updated_by</c>.</summary>
public sealed class LastUpdatedByEntry : Dto
{
    public string? Name { get; set; }

    public string? Object { get; set; }
}
