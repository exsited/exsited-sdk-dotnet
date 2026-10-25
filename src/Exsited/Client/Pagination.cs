using System.Globalization;
using System.Runtime.CompilerServices;

using Exsited.Errors;

namespace Exsited.Client;

/// <summary>Lazily walks a paginated v4 listing, cursor or offset, detected per page rather than configured.</summary>
public static class Pagination
{
    /// <summary>The key a listing puts its records under unless its family says otherwise.</summary>
    public const string DefaultRecordKey = "data";

    /// <summary>What the offset shape writes in <c>next_page</c> at the end of a listing: a string, not a null.</summary>
    public const string NoNextPage = "NULL";

    public static async IAsyncEnumerable<ApiResponse> IterPagesAsync(
        ExsitedClient client,
        string path,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        int? maxPages = null,
        bool raiseOnError = true,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(client);

        if (maxPages is < 1)
            throw new SdkUsageError(Redaction.RedactMessageText(
                "maxPages: expected a positive integer or null, got "
                + maxPages.Value.ToString(CultureInfo.InvariantCulture)));

        // The walk writes these itself, so a walk started from one would silently restart.
        foreach (var reserved in new[] { "cursor", "offset" })
        {
            if (queryParams?.ContainsKey(reserved) == true)
                throw new SdkUsageError(Redaction.RedactMessageText(
                    $"queryParams: '{reserved}' is the walk's own parameter and would be "
                    + "overwritten on the second page, so a walk starting from it would "
                    + "silently restart. Pass the page you want, or walk from the beginning."));
        }

        var seenCursors = new HashSet<string>(StringComparer.Ordinal);
        var seenOffsets = new HashSet<long>();
        var yielded = 0;

        // Applied to every page: paging is a parameter here, so dropping them would widen the listing.
        var parameters = queryParams is null
            ? new Dictionary<string, object?>(StringComparer.Ordinal)
            : new Dictionary<string, object?>(queryParams, StringComparer.Ordinal);

        while (true)
        {
            var response = await client.SendGetRequestAsync(
                path,
                new RequestOptions { QueryParams = parameters, RaiseOnError = raiseOnError },
                cancellationToken).ConfigureAwait(false);

            yield return response;
            yielded++;

            // Only reachable with raiseOnError off: a failed page has nothing to trust.
            if (!response.Succeeded)
                yield break;
            if (maxPages is int cap && yielded >= cap)
                yield break;

            var block = ReadPaginationBlock(response.Map);
            if (block is null)
                yield break;

            var cursor = ReadNextCursor(block);
            if (cursor is not null)
            {
                if (!seenCursors.Add(cursor))
                    throw new SdkError(Redaction.RedactMessageText(
                        "pagination loop: the API handed back a cursor it had already given, so "
                        + "following it again would never terminate. The pages already yielded "
                        + "are good."));
                parameters["cursor"] = cursor;
                continue;
            }

            var offset = ReadNextOffset(block, CountRecords(response.Map));
            if (offset is not long next)
                yield break;
            if (!seenOffsets.Add(next))
                throw new SdkError(Redaction.RedactMessageText(
                    "pagination loop: the offset did not advance between pages, so following it "
                    + "again would never terminate. The pages already yielded are good."));
            parameters["offset"] = next;
        }
    }

    /// <summary>Each record of a listing, across every page, from the list under the named key.</summary>
    public static async IAsyncEnumerable<IReadOnlyDictionary<string, object?>> IterRecordsAsync(
        ExsitedClient client,
        string path,
        string recordKey = DefaultRecordKey,
        IReadOnlyDictionary<string, object?>? queryParams = null,
        int? maxPages = null,
        [EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(recordKey))
            throw new SdkUsageError(Redaction.RedactMessageText(
                "recordKey: expected the envelope key holding the records, like 'invoices', "
                + $"got '{recordKey}'"));

        await foreach (var page in IterPagesAsync(
            client, path, queryParams, maxPages, true, cancellationToken).ConfigureAwait(false))
        {
            // Every page, the first included: skipping a malformed one would return a short listing.
            var records = ListUnderKey(page, recordKey) ?? throw WrongKeyError(page, recordKey);
            foreach (var record in records)
            {
                // Checked, not cast: an InvalidCastException from an iterator is not an SdkError.
                if (record is not IReadOnlyDictionary<string, object?> mapping)
                    throw new SdkUsageError(Redaction.RedactMessageText(
                        $"recordKey '{recordKey}': the list under that key holds "
                        + $"{(record is null ? "null" : record.GetType().Name)} rather than "
                        + "records; name the key that holds the objects"));
                yield return mapping;
            }
        }
    }

    internal static IReadOnlyDictionary<string, object?>? ReadPaginationBlock(object? data) =>
        data is IReadOnlyDictionary<string, object?> body
            && body.GetValueOrDefault("pagination") is IReadOnlyDictionary<string, object?> block
            ? block
            : null;

    // has_more: false ends the walk even with a cursor present: the last page keeps its cursor.
    internal static string? ReadNextCursor(IReadOnlyDictionary<string, object?> block)
    {
        if (!block.ContainsKey("has_more") && !block.ContainsKey("next_cursor"))
            return null;
        if (block.GetValueOrDefault("has_more") is bool more && !more)
            return null;
        return block.GetValueOrDefault("next_cursor") is string cursor
            && cursor.Trim().Length > 0
            ? cursor
            : null;
    }

    // Computed, never read from next_page: that is "NULL" at the end and often a URL to another path otherwise.
    internal static long? ReadNextOffset(
        IReadOnlyDictionary<string, object?> block, int recordsOnPage)
    {
        if (!block.ContainsKey("offset") && !block.ContainsKey("records"))
            return null;

        // Compared as a string: a truthiness test follows "NULL" as a link and walks for ever.
        if (block.GetValueOrDefault("next_page") is string nextPage
            && string.Equals(nextPage.Trim(), NoNextPage, StringComparison.OrdinalIgnoreCase))
            return null;

        var current = ReadNumber(block.GetValueOrDefault("offset")) ?? 0;
        var step = ReadNumber(block.GetValueOrDefault("limit")) ?? recordsOnPage;
        if (step <= 0)
            return null;
        if (recordsOnPage == 0)
            return null;
        return current + step;
    }

    // v4 sends these as numbers or as strings; reading only numbers re-requests page two for ever.
    internal static long? ReadNumber(object? value) => value switch
    {
        null => null,
        long number => number,
        int number => number,
        double number => (long)number,
        decimal number => (long)number,
        string text when long.TryParse(
            text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var parsed)
            => parsed,
        _ => null,
    };

    private static int CountRecords(object? data)
    {
        if (data is not IReadOnlyDictionary<string, object?> body)
            return 0;
        foreach (var value in body.Values)
        {
            if (value is System.Collections.IEnumerable records and not string)
            {
                var count = 0;
                foreach (var _ in records)
                    count++;
                if (count > 0)
                    return count;
            }
        }
        return 0;
    }

    private static System.Collections.IEnumerable? ListUnderKey(ApiResponse page, string recordKey) =>
        // Map: paging walks the decoded envelope whatever responseFormat says.
        page.Map is IReadOnlyDictionary<string, object?> body
            && body.GetValueOrDefault(recordKey) is System.Collections.IEnumerable records
            && IsRecordList(records)
            ? records
            : null;

    // A string or mapping is not a record list: "data": {} would read as an empty page.
    private static bool IsRecordList(System.Collections.IEnumerable records) =>
        records is not string
        && records is not System.Collections.IDictionary
        && records is not IReadOnlyDictionary<string, object?>;

    private static SdkUsageError WrongKeyError(ApiResponse page, string recordKey)
    {
        var available = page.Map is IReadOnlyDictionary<string, object?> body
            ? string.Join(", ", body.Keys.OrderBy(key => key, StringComparer.Ordinal))
            : "a " + (page.Map is null ? "null" : page.Map.GetType().Name) + " body";
        return new SdkUsageError(Redaction.RedactMessageText(
            $"recordKey '{recordKey}': this page has no list under that key; it carries "
            + $"{available}. Every family's <Family>Urls class carries the key its listings use as DataKey, and it "
            + "is 'data' for every family measured against the instance; where a single listing "
            + "keys records elsewhere, its page view's records property is named for that key."));
    }
}
