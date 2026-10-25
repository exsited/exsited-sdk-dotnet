namespace Exsited.Http;

/// <summary>Sort direction: the <c>direction</c> value beside <c>order_by</c>, or the <c>-</c> prefix in <c>sort</c>, per family.</summary>
public enum SortDirection
{
    /// <summary>Ascending - sent as <c>asc</c>, or as an unprefixed field name.</summary>
    Asc,

    /// <summary>Descending - sent as <c>desc</c>, or as a <c>-</c>-prefixed field name.</summary>
    Desc,
}
