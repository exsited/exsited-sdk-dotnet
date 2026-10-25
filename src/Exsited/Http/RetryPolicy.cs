using System.Globalization;
using System.Net.Sockets;
using System.Text.RegularExpressions;

using Exsited.Errors;

namespace Exsited.Http;

/// <summary>Retry decisions and backoff timing; pure, as the transport owns the loop.</summary>
public sealed partial class RetryPolicy
{
    /// <summary>Statuses worth another attempt at all; the whole set applies only to a safe method.</summary>
    public static readonly IReadOnlySet<int> DefaultRetryableHttpCodes =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[] { 429, 500, 502, 503, 504 });

    /// <summary>Statuses a state-changing method may be replayed on: none by default.</summary>
    public static readonly IReadOnlySet<int> DefaultUnsafeRetryableHttpCodes =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(Array.Empty<int>());

    /// <summary>RFC 9110's safe methods; an allow-list, so an unknown verb is never replayable.</summary>
    public static readonly IReadOnlySet<string> SafeMethods =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[] { "GET", "HEAD", "OPTIONS", "TRACE" });

    /// <summary>The state-changing verbs its refusals name; <see cref="IsUnsafeMethod"/> is the test.</summary>
    public static readonly IReadOnlySet<string> UnsafeMethods =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[] { "POST", "PUT", "PATCH", "DELETE" });

    /// <summary>Methods that may be re-sent once a request may already have arrived.</summary>
    public static readonly IReadOnlySet<string> IdempotentMethods =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(
            SafeMethods.Concat(new[] { "PUT", "DELETE" }));

    // Connect-phase errors only, so nothing was delivered.
    // HostUnreachable and NetworkUnreachable also arrive on a connected socket, so they are excluded.
    private static readonly IReadOnlySet<SocketError> ConnectPhaseErrors =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[]
        {
            SocketError.ConnectionRefused,
            SocketError.HostNotFound,
            SocketError.AddressNotAvailable,
            SocketError.TryAgain,
        });

    // Never connected, so never delivered; every other value counts as possibly delivered.
    private static readonly IReadOnlySet<HttpRequestError> EstablishmentErrors =
        System.Collections.Frozen.FrozenSet.ToFrozenSet(new[]
        {
            HttpRequestError.NameResolutionError,
            HttpRequestError.ConnectionError,
            HttpRequestError.SecureConnectionError,
            HttpRequestError.ProxyTunnelError,
        });

    /// <summary>Total attempts including the first, so 1 disables retrying.</summary>
    public const int DefaultMaxAttempts = 1;

    public RetryPolicy(
        int maxAttempts,
        double backoffSeconds,
        double backoffMaxSeconds,
        IReadOnlySet<int> retryableStatusCodes,
        IReadOnlySet<int> unsafeRetryableStatusCodes)
    {
        if (maxAttempts < 1)
            throw new SdkConfigError(Redaction.RedactMessageText(
                $"maxAttempts: must be at least 1 (1 disables retry), got {Show(maxAttempts)}"));
        // Checked here as well as in SdkConfig, because this constructor is public.
        RequireStatusCodes("retryableStatusCodes", retryableStatusCodes);
        RequireStatusCodes("unsafeRetryableStatusCodes", unsafeRetryableStatusCodes);
        RequireFinite("backoffSeconds", backoffSeconds);
        RequireFinite("backoffMaxSeconds", backoffMaxSeconds);
        if (backoffSeconds < 0)
            throw new SdkConfigError(Redaction.RedactMessageText($"backoffSeconds: must be >= 0, got {Show(backoffSeconds)}"));
        if (backoffMaxSeconds < backoffSeconds)
            throw new SdkConfigError(Redaction.RedactMessageText(
                $"backoffMaxSeconds: must be >= backoffSeconds, got {Show(backoffMaxSeconds)} "
                + $"< {Show(backoffSeconds)}"));

        MaxAttempts = maxAttempts;
        BackoffSeconds = backoffSeconds;
        BackoffMaxSeconds = backoffMaxSeconds;
        // Frozen here: FromConfig's copy would be mutable however immutable the source was.
        RetryableStatusCodes = System.Collections.Frozen.FrozenSet.ToFrozenSet(retryableStatusCodes);
        UnsafeRetryableStatusCodes =
            System.Collections.Frozen.FrozenSet.ToFrozenSet(unsafeRetryableStatusCodes);
    }

    private static void RequireStatusCodes(string name, IReadOnlySet<int> codes)
    {
        if (codes.Count > MaxHttpCodes)
            throw new SdkConfigError(Redaction.RedactMessageText(
                $"{name}: at most {MaxHttpCodes.ToString(CultureInfo.InvariantCulture)} status "
                + "codes (100-599 is every code there is), got "
                + codes.Count.ToString(CultureInfo.InvariantCulture)));
        foreach (var code in codes)
            if (code < MinHttpCode || code > MaxHttpCode)
                // Invariant culture: the host's NegativeSign is not always ASCII '-'.
                throw new SdkConfigError(Redaction.RedactMessageText(
                    $"{name}: {code.ToString(CultureInfo.InvariantCulture)} is not an HTTP status code"));
    }

    private const int MinHttpCode = 100;

    private const int MaxHttpCode = 599;

    private const int MaxHttpCodes = 500;

    public static RetryPolicy Defaults() =>
        new(DefaultMaxAttempts, 0.5, 20.0, DefaultRetryableHttpCodes, DefaultUnsafeRetryableHttpCodes);

    public static RetryPolicy FromConfig(Config.SdkConfig config) =>
        new(config.MaxRetries, config.RetryBackoffSeconds, config.RetryBackoffMaxSeconds,
            config.RetryableHttpCodes, config.UnsafeRetryableHttpCodes);

    /// <summary>Total attempts including the first.</summary>
    public int MaxAttempts { get; }

    public double BackoffSeconds { get; }

    public double BackoffMaxSeconds { get; }

    /// <summary>Statuses this policy will retry at all; frozen, so it cannot be widened after validation.</summary>
    public IReadOnlySet<int> RetryableStatusCodes { get; }

    /// <summary>The narrower set this policy will retry on a state-changing method; frozen.</summary>
    public IReadOnlySet<int> UnsafeRetryableStatusCodes { get; }

    /// <summary>Whether this status warrants another attempt; an unsafe method needs the unsafe set.</summary>
    public bool ShouldRetryStatusCode(int statusCode, string? method = "GET")
    {
        if (!RetryableStatusCodes.Contains(statusCode))
            return false;
        if (IsSafeMethod(method))
            return true;
        return UnsafeRetryableStatusCodes.Contains(statusCode);
    }

    /// <summary>Whether a transport failure warrants another attempt; once sent, only idempotent methods.</summary>
    public bool ShouldRetryAfterException(
        Exception exception, string? method, bool requestFullySent = false)
    {
        if (!IsTransportFailure(exception))
            return false;
        if (!requestFullySent && FailedBeforeDelivery(exception))
            return true;
        return IsIdempotentMethod(method);
    }

    // Clamped before the power: 2^1024 is Infinity, and 0 * Infinity is NaN.
    private const int MaxBackoffExponent = 1023;

    /// <summary>Exponential backoff with full jitter; a <c>Retry-After</c> wins but is clamped to the max.</summary>
    public double ComputeBackoffSeconds(int attempt, string? retryAfter = null)
    {
        var serverDelay = ParseRetryAfter(retryAfter);
        if (serverDelay is double delay)
            return Math.Min(delay, BackoffMaxSeconds);

        var growth = Math.Pow(2, Math.Min(Math.Max(0, attempt - 1), MaxBackoffExponent));
        var window = Math.Min(BackoffSeconds * growth, BackoffMaxSeconds);
        return window <= 0 ? 0.0 : Random.Shared.NextDouble() * window;
    }

    /// <summary>Whether a replay could duplicate an effect: anything not safe, unknown verbs included.</summary>
    public static bool IsUnsafeMethod(string? method) => !IsSafeMethod(method);

    /// <summary>Whether this is one of RFC 9110's safe methods; trimmed and upper-cased first.</summary>
    public static bool IsSafeMethod(string? method) =>
        method is not null && SafeMethods.Contains(method.Trim().ToUpperInvariant());

    /// <summary>Whether a replay is harmless once the request may have arrived.</summary>
    public static bool IsIdempotentMethod(string? method) =>
        method is not null && IdempotentMethods.Contains(method.Trim().ToUpperInvariant());

    // Structural signals only, never message text. A connect timeout wraps nothing,
    // while the transport's per-attempt ceiling wraps the cancellation it observed.
    private static bool FailedBeforeDelivery(Exception exception)
    {
        foreach (var link in Chain(exception))
        {
            if (link is HttpRequestException request && EstablishmentErrors.Contains(request.HttpRequestError))
                return true;
            if (link is SocketException socket && ConnectPhaseErrors.Contains(socket.SocketErrorCode))
                return true;
            if (link is TimeoutException { InnerException: null })
                return true;
        }
        return false;
    }

    private static bool IsTransportFailure(Exception exception)
    {
        foreach (var link in Chain(exception))
        {
            // A caller's cancellation is not a transport failure; a timeout leaves a TimeoutException.
            if (link is TaskCanceledException or OperationCanceledException)
                return Chain(exception).Any(inner => inner is TimeoutException);
            if (link is HttpRequestException or IOException or SocketException or TimeoutException)
                return true;
        }
        return false;
    }

    private static IEnumerable<Exception> Chain(Exception exception)
    {
        for (Exception? link = exception; link is not null; link = link.InnerException)
            yield return link;
    }

    private static double? ParseRetryAfter(string? retryAfter)
    {
        if (string.IsNullOrEmpty(retryAfter?.Trim()))
            return null;
        var value = retryAfter.Trim();

        // .NET's parser does not know "inf", which would otherwise fall through to jitter.
        if (TryParseShortInfinity(value, out var unbounded))
            return Math.Max(0.0, unbounded);

        if (double.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out var seconds))
        {
            // Math.Max propagates NaN, which would make TimeSpan.FromMilliseconds throw.
            if (double.IsNaN(seconds))
                return 0.0;
            // +infinity survives and ComputeBackoffSeconds clamps it to BackoffMaxSeconds.
            return Math.Max(0.0, seconds);
        }

        // The HTTP-date form: seconds from now until that instant.
        if (TryParseHttpDate(value, out var when))
            return Math.Max(0.0, (when - DateTimeOffset.UtcNow).TotalSeconds);
        return null;
    }

    private static bool TryParseShortInfinity(string value, out double parsed)
    {
        parsed = 0.0;
        var negative = value.StartsWith('-');
        var magnitude = negative || value.StartsWith('+') ? value[1..] : value;
        if (!magnitude.Equals("inf", StringComparison.OrdinalIgnoreCase))
            return false;
        parsed = negative ? double.NegativeInfinity : double.PositiveInfinity;
        return true;
    }

    // No day-of-week: a "ddd" token would reject legal weekday-less spellings.
    private static readonly string[] HttpDateFormats =
    {
        "dd MMM yyyy HH:mm:ss 'GMT'",   //  IMF-fixdate: Sun, 06 Nov 1994 08:49:37 GMT
        "dd-MMM-yy HH:mm:ss 'GMT'",     //  RFC 850:     Sunday, 06-Nov-94 08:49:37 GMT
        "MMM d HH:mm:ss yyyy",          //  asctime:     Sun Nov  6 08:49:37 1994
        "d MMM yyyy HH:mm:ss zzz",      //  RFC 5322:    Wed, 21 Oct 2015 07:28:00 +0000
        "dd-MMM-yy HH:mm:ss zzz",       //  RFC 850 with an alphabetic zone: 06-Nov-94 ... EST
    };

    // RFC 5322 obsolete zones as numeric offsets; GMT is absent, matched literally by the formats.
    private static readonly IReadOnlyDictionary<string, string> AlphabeticZoneOffsets =
        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["UT"] = "+00:00",
            ["UTC"] = "+00:00",
            ["Z"] = "+00:00",
            ["EST"] = "-05:00",
            ["EDT"] = "-04:00",
            ["CST"] = "-06:00",
            ["CDT"] = "-05:00",
            ["MST"] = "-07:00",
            ["MDT"] = "-06:00",
            ["PST"] = "-08:00",
            ["PDT"] = "-07:00",
            ["AST"] = "-04:00",
            ["ADT"] = "-03:00",
        };

    // Pinned at 68: the invariant culture takes TwoDigitYearMax from the host.
    private static readonly DateTimeFormatInfo HttpDateFormatInfo = BuildHttpDateFormatInfo();

    private static DateTimeFormatInfo BuildHttpDateFormatInfo()
    {
        var format = (DateTimeFormatInfo)DateTimeFormatInfo.InvariantInfo.Clone();
        var calendar = (Calendar)format.Calendar.Clone();
        calendar.TwoDigitYearMax = 2068;
        format.Calendar = calendar;
        return format;
    }

    [GeneratedRegex(@"\s+")]
    private static partial Regex WhitespaceRun();

    [GeneratedRegex(@"([+-]\d{2})(\d{2})$")]
    private static partial Regex CompactUtcOffset();

    // Spelled out, so it cannot eat an asctime month name ("Nov 6 08:49:37 1994").
    [GeneratedRegex(@"^(?:Mon|Tue|Wed|Thu|Fri|Sat|Sun)[A-Za-z]*,?\s+")]
    private static partial Regex LeadingDayOfWeek();

    // Bounded and anchored, so it cannot reach an asctime year or a month name mid-value.
    [GeneratedRegex(@"\s([A-Za-z]{1,3})$")]
    private static partial Regex TrailingZoneName();

    private static bool TryParseHttpDate(string value, out DateTimeOffset when)
    {
        // Four spelling fixes, none of which can make an unparseable value parse.
        var normalised = WhitespaceRun().Replace(value, " ");
        normalised = CompactUtcOffset().Replace(normalised, "$1:$2");
        var zone = TrailingZoneName().Match(normalised);
        if (zone.Success && AlphabeticZoneOffsets.TryGetValue(zone.Groups[1].Value, out var offset))
            normalised = normalised[..zone.Index] + " " + offset;
        normalised = LeadingDayOfWeek().Replace(normalised, "");
        foreach (var format in HttpDateFormats)
            if (DateTimeOffset.TryParseExact(normalised, format, HttpDateFormatInfo,
                    DateTimeStyles.AssumeUniversal, out when))
                return true;
        when = default;
        return false;
    }

    private static void RequireFinite(string name, double value)
    {
        if (double.IsNaN(value) || double.IsInfinity(value))
            throw new SdkConfigError(Redaction.RedactMessageText(
                $"{name}: expected a finite number of seconds, got {Show(value)}"));
    }

    // Invariant, so a refusal reads the same on every host.
    private static string Show(double value) => value.ToString(CultureInfo.InvariantCulture);

    private static string Show(int value) => value.ToString(CultureInfo.InvariantCulture);
}
