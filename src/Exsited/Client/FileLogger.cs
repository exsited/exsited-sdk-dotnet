using System.Globalization;
using System.Text;

using Exsited.Config;
using Exsited.Errors;

namespace Exsited.Client;

// The file sink behind SdkConfig.LogFile; clients naming one file share a counted writer.
internal sealed class FileLogger : IDisposable
{
    private static readonly object Gate = new();

    // Case-insensitive only where the filesystem is, or two clients' records would cross.
    private static readonly Dictionary<string, Entry> Writers =
        new(OperatingSystem.IsWindows() ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal);

    private sealed class Entry
    {
        public Entry(StreamWriter writer) => Writer = writer;
        public StreamWriter Writer { get; }
        public int Users { get; set; }
    }

    private static readonly IReadOnlyDictionary<string, int> LevelRanks = new Dictionary<string, int>
    {
        ["DEBUG"] = 10,
        ["INFO"] = 20,
        ["WARNING"] = 30,
        ["ERROR"] = 40,
        ["CRITICAL"] = 50,
    };

    private readonly string _path;
    private readonly string _clientName;
    private Entry? _entry;

    private FileLogger(string path, string clientName, Entry entry)
    {
        _path = path;
        _clientName = ExsitedClient.LoggerName + "." + LoggerSafe(clientName);
        _entry = entry;
    }

    // Injective: percent-encoding first stops a literal % colliding with an escaped dot.
    private static string LoggerSafe(string clientName) =>
        Uri.EscapeDataString(clientName).Replace(".", "%2E", StringComparison.Ordinal);

    // The numeric rank of a level name; unknown names rank as WARNING.
    internal static int RankOf(string? level) => LevelRanks.GetValueOrDefault(level ?? "WARNING", 30);

    // Null when no logFile is named; an unusable path throws SdkConfigError.
    internal static FileLogger? Attach(SdkConfig config)
    {
        if (string.IsNullOrWhiteSpace(config.LogFile))
            return null;

        // Full path, so one relative logFile from two working directories is one file.
        var target = Path.GetFullPath(config.LogFile);
        lock (Gate)
        {
            if (!Writers.TryGetValue(target, out var entry))
            {
                try
                {
                    var stream = new FileStream(target, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                    entry = new Entry(new StreamWriter(stream, new UTF8Encoding(false)) { AutoFlush = true });
                }
                catch (Exception error) when (error is IOException or UnauthorizedAccessException
                    or ArgumentException or NotSupportedException)
                {
                    throw new SdkConfigError(Redaction.RedactMessageText($"logFile '{config.LogFile}' cannot be opened: {error.Message}"));
                }
                Writers[target] = entry;
            }
            entry.Users++;
            return new FileLogger(target, config.ClientName, entry);
        }
    }

    // Append one record; the caller has already ranked it against logLevel.
    internal void Log(string level, string message)
    {
        var entry = _entry;
        if (entry is null)
            return;
        var stamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff", CultureInfo.InvariantCulture);
        lock (entry)
            entry.Writer.WriteLine($"{stamp} {level} {_clientName} {message}");
    }

    /// <summary>Release this client's claim on the writer, closing it for the last user.</summary>
    public void Dispose()
    {
        var entry = _entry;
        if (entry is null)
            return;
        _entry = null;
        lock (Gate)
        {
            entry.Users--;
            if (entry.Users > 0)
                return;
            Writers.Remove(_path);
            // Log()'s own lock, so a writer is never disposed mid-WriteLine.
            lock (entry)
                entry.Writer.Dispose();
        }
    }
}
