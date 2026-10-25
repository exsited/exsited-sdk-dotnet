using System.Collections;
using System.Globalization;

using Exsited.Errors;

namespace Exsited.Http;

/// <summary>Query normalisation: every value leaves as its wire text; names pass through untouched.
/// The v4 filter and sort spellings are built here too.</summary>
public static class QueryParams
{
    /// <summary>The comparisons a v4 filter takes; <c>eq</c> carries no suffix.</summary>
    public static readonly IReadOnlyList<string> FilterOperators =
        new[]
        {
            "eq", "neq", "in", "nin", "contains", "not_contains", "starts_with",
            "gt", "gte", "lt", "lte", "has_value", "does_not_have_value",
        };

    /// <summary>The operators that test presence and take no value to match.</summary>
    public static readonly IReadOnlyList<string> PresenceOperators =
        new[] { "has_value", "does_not_have_value" };

    /// <summary>The operators whose value is a comma-separated list; see <see cref="FilterValues"/>.</summary>
    public static readonly IReadOnlyList<string> ListOperators = new[] { "in", "nin" };

    private const string FilterPrefix = "filter";

    private static readonly HashSet<string> KnownFilterOperators =
        new(FilterOperators, StringComparer.Ordinal);

    /// <summary>A v4 filter name: <c>filter_&lt;field&gt;</c> for <c>eq</c>, <c>filter_&lt;field&gt;_&lt;op&gt;</c> otherwise.</summary>
    public static string FilterParam(string field, string @operator = "eq")
    {
        if (string.IsNullOrWhiteSpace(field))
            throw new SdkUsageError(Redaction.RedactMessageText(
                "filter field: expected a field name like 'status', got an empty string"));
        if (!KnownFilterOperators.Contains(@operator))
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"filter operator '{@operator}': expected one of "
                + string.Join(", ", FilterOperators)));

        // The one irregularity: the API refuses a literal _eq.
        var stem = FilterPrefix + "_" + field.Trim();
        return string.Equals(@operator, "eq", StringComparison.Ordinal)
            ? stem
            : stem + "_" + @operator;
    }

    /// <summary>An <c>in</c>/<c>nin</c> value: each member's wire text, joined with <c>,</c>.</summary>
    public static string FilterValues(IEnumerable values)
    {
        if (values is null)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "filter values: expected a sequence of values like ['ACTIVE', 'INACTIVE'], "
                + "got null"));
        if (values is string)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "filter values: expected a sequence of values like ['ACTIVE', 'INACTIVE'], "
                + "got a single string; one value is still a sequence of one"));

        var rendered = new List<string>();
        foreach (var value in values)
        {
            if (value is null)
                throw new SdkUsageError(Redaction.RedactMessageText(
                    "filter values: a member is null, which has no value to match; drop it, "
                    + "or use the 'does_not_have_value' operator if what was meant is "
                    + "'this field is unset'"));

            // Depth 1, so a member that is itself a sequence is refused as one.
            var text = (string)Normalise(value, "filter values",
                new HashSet<object>(ReferenceEqualityComparer.Instance), 1)!;
            // The API reads a comma as the separator, so the filter would match something else.
            if (text.Contains(',', StringComparison.Ordinal))
                throw new SdkUsageError(Redaction.RedactMessageText(
                    $"filter values: the member '{text}' contains a comma, which the API "
                    + "reads as the separator between two values, so it would match "
                    + "something other than what was asked for"));
            rendered.Add(text);
        }

        if (rendered.Count == 0)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "filter values: expected at least one value; an empty 'in' filter is sent "
                + "as 'filter_<field>_in=' and answered 200 with no rows, which reads as "
                + "'nothing matched' rather than as the mistake it is"));

        return string.Join(",", rendered);
    }

    /// <summary>A <c>sort</c> value, for the families that take one: a <c>-</c> prefix means descending.</summary>
    public static string SortParam(string field, SortDirection direction = SortDirection.Asc)
    {
        if (string.IsNullOrWhiteSpace(field))
            throw new SdkUsageError(Redaction.RedactMessageText(
                "sort field: expected a field name like 'created_on', got an empty string"));
        // Reachable only by casting an integer, which is why it is checked.
        if (direction is not (SortDirection.Asc or SortDirection.Desc))
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"sort direction '{(int)direction}': expected "
                + $"{nameof(SortDirection.Asc)} or {nameof(SortDirection.Desc)}"));

        var trimmed = field.Trim();
        return direction == SortDirection.Desc ? "-" + trimmed : trimmed;
    }

    /// <summary>The <c>order_by</c> plus <c>direction</c> pair, for the families that take that spelling instead of <c>sort</c>.</summary>
    public static IReadOnlyDictionary<string, object?> SortParams(
        string field, bool descending = false)
    {
        if (string.IsNullOrWhiteSpace(field))
            throw new SdkUsageError(Redaction.RedactMessageText(
                "sort field: expected a field name like 'created_on', got an empty string"));

        return new Dictionary<string, object?>(StringComparer.Ordinal)
        {
            ["order_by"] = field.Trim(),
            ["direction"] = descending ? "desc" : "asc",
        };
    }

    /// <summary>Normalise values to their wire text: <c>null</c> dropped, an enumerable repeats the key.</summary>
    public static Dictionary<string, object?> BuildQueryParams(
        IReadOnlyDictionary<string, object?>? parameters)
    {
        var normalised = new Dictionary<string, object?>();
        if (parameters is null) return normalised;
        foreach (var (key, value) in parameters)
        {
            if (value is null) continue;   // an unset filter is never sent
            normalised[key] = Normalise(value, key,
                new HashSet<object>(ReferenceEqualityComparer.Instance), 0);
        }
        return normalised;
    }

    private static object? Normalise(object value, string key, HashSet<object> seen, int depth)
    {
        if (depth >= 64)
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"query param '{key}': nested more than 64 levels deep, which is too deep " +
                "to encode in a query string"));

        if (value is IReadOnlyDictionary<string, object?> or IDictionary)
            throw new SdkUsageError(Redaction.RedactMessageText(
                $"query param '{key}': nested objects cannot be encoded in a query " +
                "string; flatten it or send it in the body"));

        // Ahead of the sequence arm, because a string is one: a scalar is never exploded.
        if (WireText(value) is { } text)
            return text;

        if (value is IEnumerable enumerable)
        {
            if (!seen.Add(value))
                throw new SdkUsageError(Redaction.RedactMessageText(
                    $"query param '{key}': the value refers to itself, so it has no " +
                    "finite query-string encoding"));
            if (depth >= 1)
                throw new SdkUsageError(Redaction.RedactMessageText(
                    $"query param '{key}': a sequence inside a sequence has no " +
                    "query-string encoding; flatten it to one list of scalars"));
            try
            {
                var entries = new List<object?>();
                foreach (var entry in enumerable)
                    if (entry is not null)
                        entries.Add(Normalise(entry, key, seen, depth + 1));
                return entries;
            }
            finally { seen.Remove(value); }
        }

        throw new SdkUsageError(Redaction.RedactMessageText(RefuseValue("query param", key, value)));
    }

    /// <summary>The one refusal for an unspellable value: the type is named, never the value.</summary>
    internal static string RefuseValue(string what, string key, object value) =>
        $"{what} '{key}': a {value.GetType().Name} has no wire spelling this SDK will guess "
        + "at. Its ToString() is the calling program's own code, so the text sent and the text "
        + "recorded could disagree, and could differ again between two attempts at the same "
        + "request. Pass a string, a number, a bool, an enum, a date or time, a TimeSpan, a "
        + "Guid, a Uri - or, for a query parameter, a list of those";

    /// <summary>The one scalar-to-wire-text table, invariant; <c>null</c> for a shape it cannot spell.</summary>
    internal static string? WireText(object value) => value switch
    {
        string text => text,
        bool flag => flag ? "true" : "false",
        // Ahead of the enum arm, pinning the wire form if a member is renamed.
        SortDirection direction => direction == SortDirection.Asc ? "asc" : "desc",
        Enum enumValue => enumValue.ToString().ToLowerInvariant(),
        DateTime dateTime => IsoTime(dateTime),
        DateTimeOffset dateTimeOffset => dateTimeOffset.ToString(IsoWithOffset, CultureInfo.InvariantCulture),
        DateOnly date => date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
        TimeOnly time => time.ToString("HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture),
        // "c" named, so the wire spelling is not the framework's to change.
        TimeSpan span => span.ToString("c", CultureInfo.InvariantCulture),
        Guid guid => guid.ToString("D", CultureInfo.InvariantCulture),
        Uri uri => uri.ToString(),
        char character => character.ToString(),
        sbyte or byte or short or ushort or int or uint or long or ulong
            or float or double or decimal or System.Numerics.BigInteger =>
            ((IFormattable)value).ToString(null, CultureInfo.InvariantCulture),
        _ => null,
    };

    // ISO 8601, with a fractional part only when the value carries one.
    private const string Iso = "yyyy-MM-ddTHH:mm:ss.FFFFFF";
    private const string IsoWithOffset = Iso + "zzz";

    /// <summary>A DateTime with its offset: a UTC value without +00:00 is read as the application's local time.</summary>
    private static string IsoTime(DateTime value) => value.Kind switch
    {
        // Not through DateTimeOffset, which reads an Unspecified value as local time.
        DateTimeKind.Utc => value.ToString(Iso, CultureInfo.InvariantCulture) + "+00:00",
        DateTimeKind.Local => new DateTimeOffset(value).ToString(IsoWithOffset, CultureInfo.InvariantCulture),
        _ => value.ToString(Iso, CultureInfo.InvariantCulture),
    };
}
