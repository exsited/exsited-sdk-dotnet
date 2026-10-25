using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

using Exsited.Errors;

namespace Exsited.Auth;

/// <summary>
/// Token storage in a JSON file, safe to share across processes. The lock is a sidecar file
/// (<c>&lt;path&gt;.lock</c>), never the data file; writes are atomic; a whole token exchange runs
/// under the cross-process lock; and entries are keyed by namespace, so the last instance to
/// authenticate cannot overwrite the others.
///
/// <para><b>The lock fails closed.</b> With no cross-process lock to hold, every mutation is
/// refused with an <see cref="SdkTokenLockError"/>; <see cref="CrossProcessLockingDegraded"/>
/// says why. An unusable cache file is refused with an <see cref="SdkTokenCacheError"/> rather
/// than read as empty, and the read is bounded at <see cref="MaxTokenCacheBytes"/>. Other
/// namespaces' entries are written back exactly as they were read.</para>
///
/// <para>Clearing an entry treats absence as success and reports every other deletion failure,
/// because a token still on disk is a logout that did not happen. The lock sidecar is never
/// removed: see <see cref="ClearNamespaceRecord"/>.</para>
/// </summary>
/// <example>
/// <code>
/// var store = new FileTokenStore("/var/cache/exsited/token.json", fingerprint);
/// </code>
/// </example>
public sealed class FileTokenStore : ITokenStore
{
    /// <summary>The default cache filename. The <i>directory</i> is a shared per-user location,
    /// so the file is named for this SDK and nothing there can collide with it.</summary>
    public const string DefaultTokenCacheFilename = "exsited_dotnet_token.json";

    /// <summary>
    /// The most of the cache file this SDK will read, and the size above which it refuses the
    /// file instead: 1 MiB.
    /// </summary>
    /// <remarks>
    /// The whole file is parsed at once, from a per-user path any process running as this user
    /// can append to, so the read is bounded. One entry with two 4 KB credentials is about 9 KB,
    /// so a megabyte holds a hundred of those, far more credential sets than a machine has.
    /// </remarks>
    public const long MaxTokenCacheBytes = 1024 * 1024;

    private const string LockSuffix = ".lock";
    private const int LockTimeoutMillis = 30_000;
    private const int LockPollMillis = 50;
    private const string DefaultNamespace = "default";
    private const int ReplaceRetryAttempts = 5;
    private const int ReplaceRetryInitialMillis = 10;

    /// <summary>The in-process half of the lock over one cache path, shared by every store
    /// pointed at that file: held per store, two clients from one set of credentials would not
    /// coordinate at all.</summary>
    private sealed class CachePathGuard
    {
        /// <summary>The mutex every store on this path waits on.</summary>
        public SemaphoreSlim Gate { get; } = new(1, 1);

        /// <summary>Whether the current unbroken run of lock refusals has been announced, so a
        /// permanently unlockable path does not warn on every call. Read and written under
        /// <see cref="Gate"/>.</summary>
        public bool DegradationAnnounced { get; set; }
    }

    // Keyed by the resolved path, case-folded on Windows, so a relative spelling and a
    // difference in case both find the one guard for the file they name.
    private static readonly Dictionary<string, CachePathGuard> GuardsByCachePath = new(StringComparer.Ordinal);
    private static readonly object GuardsRegistryLock = new();

    private readonly CachePathGuard _guard;
    private readonly string _path;
    private readonly string _lockPath;
    private readonly string _namespace;

    // volatile: written under the guard, read by CrossProcessLockingDegraded from any thread.
    private volatile string? _degradedReason;

    /// <summary>Open a store over a file path, keyed by a namespace (typically a credential
    /// fingerprint).
    ///
    /// <para>The path is resolved to an absolute one <b>here, once</b>, so a later change of
    /// working directory cannot move the I/O away from the guard and the lock sidecar, and two
    /// spellings of one file share one guard. The sidecar is derived from the resolved path, so
    /// the lock and the data it protects stay in one directory.</para></summary>
    public FileTokenStore(string filePath, string? @namespace = null)
    {
        _path = Path.GetFullPath(filePath);
        _lockPath = _path + LockSuffix;
        _namespace = string.IsNullOrEmpty(@namespace) ? DefaultNamespace : @namespace;
        _guard = GuardForPath(_path);
        var parent = Path.GetDirectoryName(_path);
        if (!string.IsNullOrEmpty(parent) && !Directory.Exists(parent))
        {
            try
            {
                Directory.CreateDirectory(parent);
                // Narrowed because this SDK created it; a directory the caller already had is
                // left as the caller configured it.
                RestrictToOwner(parent, isDirectory: true);
            }
            catch (Exception error) when (error is IOException or UnauthorizedAccessException)
            {
                throw new SdkConfigError(Redaction.RedactMessageText($"tokenCachePath: the directory for {_path} could not "
                    + $"be created ({error.Message}); name a path whose parent exists, or keep the token "
                    + "in memory"), error);
            }
        }
    }

    /// <summary>The guard one cache path is filed under, created on first use. Folded on
    /// Windows, where two spellings differing only in case name the same file.</summary>
    private static CachePathGuard GuardForPath(string resolvedPath)
    {
        var key = OperatingSystem.IsWindows() ? resolvedPath.ToUpperInvariant() : resolvedPath;
        lock (GuardsRegistryLock)
        {
            if (!GuardsByCachePath.TryGetValue(key, out var guard))
            {
                guard = new CachePathGuard();
                GuardsByCachePath[key] = guard;
            }
            return guard;
        }
    }

    /// <summary>Fingerprint a set of credentials, for keying entries within one token file. Each
    /// value is fed with its length in <b>code points</b> so a shifted boundary cannot collide,
    /// and the material is seeded with a recipe version, so the key identifies the credentials
    /// without carrying them and changing the recipe orphans every entry on disk.</summary>
    /// <example>
    /// <code>
    /// FileTokenStore.BuildCredentialsNamespace(auth.BaseUrl, auth.ClientId, auth.ClientSecret);
    /// // "9f2c4b1e7a03d581" - 16 hex characters, the same for the same credentials
    /// </code>
    /// </example>
    public static string BuildCredentialsNamespace(
        string? baseUrl, string? clientId, string? clientSecret = "",
        string? grantType = "")
    {
        // Six slots, and the empty fifth is deliberate: an `auth_string` slot that v4 has no
        // credential for, still fed and counted. No parameter is exposed for it, and the recipe
        // cannot be renumbered without orphaning every cached token.
        const string authStringSlot = "";
        var material = new StringBuilder();
        foreach (var value in new[] { "v4", baseUrl, clientId, clientSecret, authStringSlot, grantType })
        {
            var text = value ?? "";
            // Code points, not text.Length: counting UTF-16 units would tie the fingerprint to
            // the encoding rather than to the credential.
            var codePoints = text.EnumerateRunes().Count();
            material.Append(codePoints).Append(':').Append(text);
        }
        var hash = SHA256.HashData(Encoding.UTF8.GetBytes(material.ToString()));
        var hex = new StringBuilder(hash.Length * 2);
        foreach (var byteValue in hash)
            hex.Append(byteValue.ToString("x2", CultureInfo.InvariantCulture));
        return hex.ToString(0, 16);
    }

    /// <summary>The conventional per-user cache path for this platform, so tokens stay out of
    /// the working directory: <c>%LOCALAPPDATA%\exsited\</c> on Windows,
    /// <c>~/Library/Caches/exsited/</c> on macOS, else <c>$XDG_CACHE_HOME/exsited/</c>
    /// falling back to <c>~/.cache/exsited/</c>.</summary>
    public static string BuildDefaultTokenCachePath(string filename = DefaultTokenCacheFilename)
    {
        string root;
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        if (OperatingSystem.IsWindows())
        {
            root = Environment.GetEnvironmentVariable("LOCALAPPDATA") ?? home;
        }
        else if (OperatingSystem.IsMacOS())
        {
            root = Path.Combine(home, "Library", "Caches");
        }
        else
        {
            root = Environment.GetEnvironmentVariable("XDG_CACHE_HOME") ?? Path.Combine(home, ".cache");
        }
        var directory = Path.Combine(root, "exsited");
        // Every source of `root` above can hand back something that is not absolute -
        // GetFolderPath returns "" when the profile cannot be resolved, and LOCALAPPDATA /
        // XDG_CACHE_HOME are the caller's to set - which would put the refresh token under the
        // process working directory. Fully-qualified, not merely rooted: on Windows
        // "C:exsited" is rooted and still resolves against the drive's current directory.
        if (!Path.IsPathFullyQualified(directory))
            throw new SdkConfigError(Redaction.RedactMessageText("the default token cache directory did not resolve to an "
                + "absolute path (got '" + directory + "'); pass a path, or keep the token in memory"));
        try
        {
            Directory.CreateDirectory(directory);
            RestrictToOwner(directory, isDirectory: true);
        }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException)
        {
            throw new SdkConfigError(Redaction.RedactMessageText("the default token cache directory could not be created ("
                + error.Message + "); pass a path, or keep the token in memory"), error);
        }
        return Path.Combine(directory, filename);
    }

    /// <inheritdoc/>
    /// <exception cref="SdkTokenCacheError">the file is there and cannot be read or parsed.
    /// Not <c>null</c>, which means <i>absent</i>: every mutation rewrites the file from what this
    /// read returns, so reading an unparseable file as absent would drop every other namespace's
    /// token.</exception>
    public async Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(
        CancellationToken cancellationToken = default)
    {
        // Fast path: the in-process guard only, no OS lock. Safe because writes are atomic, so
        // a concurrent reader sees a whole old file or a whole new one.
        await _guard.Gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            return ReadNamespaceRecord();
        }
        finally
        {
            _guard.Gate.Release();
        }
    }

    /// <inheritdoc/>
    /// <exception cref="SdkTokenCacheError">the existing file could not be read, so the
    /// snapshot this write would rebuild it from is not the file's contents. Refusing costs
    /// this process its cached token; writing anyway would cost every other namespace theirs.</exception>
    /// <exception cref="SdkTokenLockError">the cache could not be locked across processes.</exception>
    public async Task WriteTokenRecordAsync(
        IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default)
    {
        await using var scope = await AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);
        await scope.WriteTokenRecordAsync(record, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    /// <exception cref="SdkTokenCacheError">the file could not be read, so which other
    /// namespaces it holds is unknown and rewriting it would discard them.</exception>
    /// <exception cref="SdkTokenLockError">the cache could not be locked across processes.</exception>
    public async Task ClearTokenRecordAsync(CancellationToken cancellationToken = default)
    {
        await using var scope = await AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);
        await scope.ClearTokenRecordAsync(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    /// <remarks>
    /// The order of these two waits is load-bearing: the guard is taken first, so only the
    /// flow already holding that permit ever opens the sidecar, which is what makes one sidecar
    /// handle per process an invariant. Reversed, in-process callers race for the file directly
    /// and the cross-process lock guards nothing within this process. Do not reorder.
    /// <para>The sidecar is named for the <b>file</b>, never for the namespace, and that is not
    /// a detail: a write is a read-modify-write over the whole file, so a per-namespace lock
    /// would let two writers into the same bytes at once and each would drop the other's
    /// entry.</para>
    /// </remarks>
    /// <exception cref="SdkTokenLockError">there is no cross-process lock to hold, so the
    /// scope is refused rather than handed out with nothing behind it.</exception>
    public async Task<ITokenRefreshScope> AcquireTokenRefreshLockAsync(
        CancellationToken cancellationToken = default)
    {
        await _guard.Gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        FileStream sidecar;
        try
        {
            sidecar = await OpenSidecarWithDeadlineAsync(cancellationToken).ConfigureAwait(false);
        }
        catch
        {
            // The permit is this method's to release when it hands out no scope: the caller
            // has nothing to dispose, so a refusal would otherwise wedge every later
            // acquisition on this path for the life of the process.
            _guard.Gate.Release();
            throw;
        }
        // Back in force: a later acquisition succeeding must not keep reporting a degradation
        // that has passed, and must re-arm the announcement.
        _degradedReason = null;
        _guard.DegradationAnnounced = false;
        return new Scope(this, sidecar);
    }

    /// <summary>Why the last acquisition on this cache path found no cross-process lock to
    /// take, or <c>null</c> while the lock is in force.
    ///
    /// <para>Read it after a caught <see cref="SdkTokenLockError"/> to tell which of the three
    /// conditions it was: a cache directory no sidecar can be opened in, a location a temp
    /// cleaner removed, or a lock wait that outlasted its 30-second deadline. The first refusal
    /// in an unbroken run also writes one line to standard error, and a successful acquisition
    /// re-arms it.</para></summary>
    /// <example>
    /// <code>
    /// catch (SdkTokenLockError) when (store.CrossProcessLockingDegraded is { } why)
    /// {
    ///     logger.LogWarning("the token cache could not be locked: {Why}", why);
    /// }
    /// </code>
    /// </example>
    public string? CrossProcessLockingDegraded => _degradedReason;

    /// <summary>Announce once per unbroken run that there is no cross-process lock, and return
    /// the refusal for the caller to throw, so the throw site reads as one. Called with the
    /// guard's permit held, which is what makes the unsynchronised read-modify-write of
    /// <c>DegradationAnnounced</c> safe.</summary>
    private SdkTokenLockError RefuseTheLock(string reason)
    {
        _degradedReason = reason;
        var refusal = new SdkTokenLockError(Redaction.RedactMessageText(
            "the token cache could not be locked across processes, so the operation was "
            + $"refused rather than run without exclusion: {reason}. Two processes sharing this "
            + "file would otherwise write it at the same time and overwrite each other's entry, "
            + "refresh token included. Pass tokenCachePath: null to keep the token in memory, or "
            + $"point it at a filesystem where locking works. Path: {_path}"));
        if (_guard.DegradationAnnounced)
            return refusal;
        _guard.DegradationAnnounced = true;
        // Standard error, not standard output: a diagnostic must not corrupt piped output. The
        // path is named because it is the caller's own file; no token is in this message.
        Console.Error.WriteLine(refusal.Message);
        return refusal;
    }

    /// <summary>Poll for an exclusive handle on the sidecar with a deadline: the lock spans a
    /// whole token exchange. A read-only filesystem, a vanished directory or a timeout leaves
    /// nothing to lock, and each of those is <b>refused</b> rather than run in a thread-only
    /// critical section that is not exclusion between processes.</summary>
    /// <exception cref="SdkTokenLockError">there is no cross-process lock to take.</exception>
    private async Task<FileStream> OpenSidecarWithDeadlineAsync(CancellationToken cancellationToken)
    {
        var stopwatch = Stopwatch.StartNew();
        while (true)
        {
            try
            {
                return new FileStream(_lockPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            }
            catch (DirectoryNotFoundException)
            {
                // Ahead of IOException, its base type: a temp cleaner can remove the cache
                // directory after the constructor made it, and misreading that as "held by
                // another process" spins the full 30-second deadline. Recreate and retry.
                var parent = Path.GetDirectoryName(Path.GetFullPath(_lockPath));
                try
                {
                    if (!string.IsNullOrEmpty(parent))
                        Directory.CreateDirectory(parent);
                }
                catch (Exception error) when (error is IOException or UnauthorizedAccessException)
                {
                    // The location itself is gone: there is nothing to lock.
                    throw RefuseTheLock($"the directory holding the lock file {_lockPath} is gone "
                        + $"and could not be recreated ({error.Message})");
                }
            }
            catch (IOException)
            {
                // Held by another process; wait and retry until the deadline.
            }
            catch (UnauthorizedAccessException error)
            {
                // A read-only filesystem, or a directory sitting where the lock file goes.
                throw RefuseTheLock($"the lock file {_lockPath} could not be opened ({error.Message})");
            }
            if (stopwatch.ElapsedMilliseconds >= LockTimeoutMillis)
            {
                throw RefuseTheLock("another process held the lock for longer than "
                    + (LockTimeoutMillis / 1000).ToString(CultureInfo.InvariantCulture) + "s");
            }
            await Task.Delay(LockPollMillis, cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>This store's own entry, materialised from whatever the file holds under its
    /// namespace; <c>null</c> when there is none, or when the entry there is not an
    /// object.</summary>
    private IReadOnlyDictionary<string, object?>? ReadNamespaceRecord()
    {
        if (!ReadAllNamespaces().TryGetValue(_namespace, out var entry))
            return null;
        // Only our entry is materialised. Everything else in the file stays the JsonElement it
        // was read as; see ReadAllNamespaces.
        return entry is JsonElement { ValueKind: JsonValueKind.Object } element
               && Redaction.Materialise(element) is Dictionary<string, object?> record
            ? record
            : null;
    }

    private void WriteNamespaceRecord(IReadOnlyDictionary<string, object?> record)
    {
        var stored = ReadAllNamespaces();
        stored[_namespace] = new Dictionary<string, object?>(record);
        WriteAllNamespaces(stored);
    }

    /// <summary>Drop this store's entry, leaving other namespaces' tokens alone.
    ///
    /// <para><b>The lock sidecar is never removed</b>, only the data file. The sidecar is the
    /// identity of the lock, so unlinking it ends mutual exclusion outright: a waiter goes on
    /// holding its handle on an unlinked file while the next process creates a fresh sidecar
    /// and locks that, and both are then inside the critical section at once, each overwriting
    /// the other's token. An empty sidecar costs nothing, and outliving the data it protected
    /// is the point of it.</para></summary>
    private void ClearNamespaceRecord()
    {
        var stored = ReadAllNamespaces();
        if (!stored.Remove(_namespace))
            return;
        if (stored.Count > 0)
            WriteAllNamespaces(stored);
        else
            DeleteTheTokenFile();
    }

    /// <summary>Remove the cache file once the last namespace has gone from it. <b>Not</b>
    /// best-effort, unlike <see cref="TryDelete"/>: this file holds a usable refresh token, so a
    /// deletion that did not happen is a logout that did not happen. Absence is the outcome asked
    /// for and therefore a success - <see cref="File.Delete(string)"/> is already silent about a
    /// path that is not there, and a directory that has gone took the file with it - but a
    /// permission denial, a share violation or a read-only mount leaves the credential reusable
    /// on disk and is reported.</summary>
    /// <exception cref="SdkError">the file is still there and still readable by anyone who can
    /// read the path.</exception>
    private void DeleteTheTokenFile()
    {
        try
        {
            File.Delete(_path);
        }
        catch (DirectoryNotFoundException)
        {
            // The directory is gone, so the file inside it is too: what was asked for.
        }
        catch (Exception failure) when (failure is IOException or UnauthorizedAccessException)
        {
            throw new SdkError(Redaction.RedactMessageText(
                "the token cache entry was removed from memory but the file holding it could not "
                + $"be deleted: {failure.Message}. A reusable token may still be on disk at "
                + $"{_path}, so treat this as a failed logout rather than a completed one"),
                innerException: failure);
        }
    }

    /// <summary>Every namespace in the cache file, or an empty map <b>only</b> when there is
    /// none there.
    ///
    /// <para>Empty means <i>this file holds nothing</i>, which is true of a missing file and of
    /// an empty one, and both mutations rebuild the whole file from what this returns. So
    /// anything else - unreadable, not UTF-8, not JSON, not an object, larger than the ceiling
    /// - is refused: answering empty would let the next write truncate a shared file down to
    /// this store's one entry, destroying every other namespace's refresh token.</para>
    ///
    /// <para>Values are <see cref="JsonElement"/> clones, which outlive the
    /// <see cref="JsonDocument"/> they came from, so a write puts a foreign namespace's entry
    /// back exactly as it was read.</para></summary>
    /// <exception cref="SdkTokenCacheError">the file is there and cannot be used.</exception>
    private Dictionary<string, object?> ReadAllNamespaces()
    {
        var content = ReadWithinTheCeiling();
        if (content is null)
            return new Dictionary<string, object?>();
        if (content.Trim().Length == 0)
            return new Dictionary<string, object?>();
        JsonDocument document;
        try
        {
            document = JsonDocument.Parse(content, Redaction.DeepParse);
        }
        catch (JsonException error)
        {
            throw RefuseTheCacheFile("does not hold valid JSON", error);
        }
        using (document)
        {
            if (document.RootElement.ValueKind != JsonValueKind.Object)
                throw RefuseTheCacheFile(
                    $"holds a JSON {document.RootElement.ValueKind.ToString().ToLowerInvariant()} "
                    + "where an object of credential namespaces was expected", null);
            var stored = new Dictionary<string, object?>(StringComparer.Ordinal);
            foreach (var entry in document.RootElement.EnumerateObject())
                stored[entry.Name] = entry.Value.Clone();
            return stored;
        }
    }

    /// <summary>The cache file's text, read one byte past <see cref="MaxTokenCacheBytes"/>, or
    /// <c>null</c> when there is no file.
    ///
    /// <para>One byte past and no further: enough to know the file is over the ceiling without
    /// holding the whole of it. The read itself is bounded, because any process running as this
    /// user can append to this path.</para></summary>
    private string? ReadWithinTheCeiling()
    {
        byte[] raw;
        try
        {
            using var handle = new FileStream(
                _path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using var buffer = new MemoryStream();
            var block = new byte[8192];
            // One byte past the ceiling, and not one more: the last block is shortened so a
            // hostile file cannot make this allocate beyond it.
            const long limit = MaxTokenCacheBytes + 1;
            while (buffer.Length < limit)
            {
                var want = (int)Math.Min(block.Length, limit - buffer.Length);
                var read = handle.Read(block, 0, want);
                if (read <= 0)
                    break;
                buffer.Write(block, 0, read);
            }
            raw = buffer.ToArray();
        }
        catch (Exception error) when (error is FileNotFoundException or DirectoryNotFoundException)
        {
            return null; // absent, which is an ordinary state and costs one authentication
        }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException)
        {
            throw RefuseTheCacheFile("could not be read", error);
        }
        if (raw.Length > MaxTokenCacheBytes)
            throw RefuseTheCacheFile(
                $"is larger than the {MaxTokenCacheBytes.ToString(CultureInfo.InvariantCulture)}"
                + "-byte ceiling this SDK reads it to, so it was not loaded", null);
        try
        {
            return StrictUtf8.GetString(raw);
        }
        catch (DecoderFallbackException error)
        {
            // Bytes are there and they are not this file's text. PowerShell's `>` writes
            // UTF-16, for one.
            throw RefuseTheCacheFile("is not UTF-8 text", error);
        }
    }

    // Strict, not the forgiving default: a byte sequence that is not UTF-8 has to be a refusal
    // rather than a run of replacement characters that then fails to parse as something else.
    private static readonly Encoding StrictUtf8 = new UTF8Encoding(
        encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

    /// <summary>The one refusal for a cache file that cannot be used, returned rather than
    /// thrown so the throw site reads as a throw.</summary>
    private SdkTokenCacheError RefuseTheCacheFile(string problem, Exception? error) =>
        new(Redaction.RedactMessageText(
            $"the token cache {problem}. It is not read as empty: this file is keyed by "
            + "credentials namespace and is meant to be shared, so rewriting it from an empty "
            + "snapshot would discard every other namespace in it. Repair or move the file, or "
            + $"pass tokenCachePath: null to keep the token in memory. Path: {_path}"
            + (error is null ? "" : $": {error.Message}")),
            error);

    private void WriteAllNamespaces(Dictionary<string, object?> stored)
    {
        var directory = Path.GetDirectoryName(Path.GetFullPath(_path));
        if (string.IsNullOrEmpty(directory))
            directory = ".";
        Directory.CreateDirectory(directory);
        var temporary = Path.Combine(directory, Path.GetFileName(_path) + "." + Guid.NewGuid().ToString("N") + ".tmp");
        try
        {
            // BOM-less UTF-8. File.WriteAllText(..., Encoding.UTF8) emits a BOM, and a strict
            // UTF-8 JSON reader rejects a leading BOM, so the cache would be unreadable to
            // anything but this writer.
            File.WriteAllBytes(temporary, JsonSerializer.SerializeToUtf8Bytes(stored));
            // Narrowed before the move, not only after it: the temporary carries the whole
            // refresh token and is created with whatever the directory grants. A move within a
            // volume carries the source's permissions across, so this is what makes the
            // destination owner-only; the call below covers a move that crossed a volume.
            RestrictToOwner(temporary, isDirectory: false);
            ReplaceTheTokenFile(temporary);
            RestrictToOwner(_path, isDirectory: false);
        }
        catch (Exception)
        {
            TryDelete(temporary);
            throw;
        }
    }

    /// <summary>Move the written temporary file into place, briefly retried on Windows, where a
    /// process merely <i>reading</i> the file makes the replace fail with a sharing violation.
    /// The last failure propagates, because an unlimited wait would hold the refresh
    /// lock.</summary>
    private static void ReplaceTheTokenFile(string temporary, string destination)
    {
        var wait = ReplaceRetryInitialMillis;
        for (var attempt = 0; ; attempt++)
        {
            try
            {
                File.Move(temporary, destination, overwrite: true);
                return;
            }
            // UnauthorizedAccessException too, not only IOException: on Windows a reader holding
            // the destination makes File.Move throw it (HRESULT 0x80070005), so catching
            // IOException alone lets ordinary contention escape on attempt 0 and this retry loop
            // becomes dead code. Both WinError 5 and 32 must be retried.
            catch (Exception error) when (error is IOException or UnauthorizedAccessException)
            {
                if (!OperatingSystem.IsWindows() || attempt == ReplaceRetryAttempts - 1)
                    throw;
                Thread.Sleep(wait);
                wait *= 2;
            }
        }
    }

    private void ReplaceTheTokenFile(string temporary) => ReplaceTheTokenFile(temporary, _path);

    /// <summary>Best-effort owner-only permissions on the refresh-token cache and its directory.
    /// Windows is <b>not</b> a no-op: a file created under <c>%LOCALAPPDATA%</c> inherits that
    /// directory's ACEs, which can include another local account. Both arms strip inheritance,
    /// drop every inherited ACE and grant the current user alone.</summary>
    private static void RestrictToOwner(string target, bool isDirectory)
    {
        if (OperatingSystem.IsWindows())
        {
            RestrictToOwnerOnWindows(target);
            return;
        }
        try
        {
            var mode = isDirectory
                ? UnixFileMode.UserRead | UnixFileMode.UserWrite | UnixFileMode.UserExecute
                : UnixFileMode.UserRead | UnixFileMode.UserWrite;
            File.SetUnixFileMode(target, mode);
        }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException or PlatformNotSupportedException)
        {
            // The cache keeps whatever its directory granted.
        }
    }

    /// <summary>The Windows half of <see cref="RestrictToOwner"/>: protect the object from
    /// inheritance, drop every rule it inherited, and grant the running user alone - the
    /// equivalent of <c>chmod 700</c> / <c>600</c>, and best effort like the Unix arm.
    ///
    /// <para>Inheritance must be broken first and with <c>preserveInheritance: false</c>: with
    /// <c>true</c> the inherited entries are copied down as explicit ones, and with the
    /// protection left off they come back from the parent. The added rule carries both
    /// inheritance flags on a directory, so the token file written next inherits owner-only.
    /// Administrators and SYSTEM are dropped too, the same posture as mode 700: the point is to
    /// stop <b>another ordinary account on the same machine</b>.</para>
    /// </summary>
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    private static void RestrictToOwnerOnWindows(string target)
    {
        try
        {
            var owner = System.Security.Principal.WindowsIdentity.GetCurrent().User;
            if (owner is null)
                return;
            var inheritance = isDirectoryTarget(target)
                ? System.Security.AccessControl.InheritanceFlags.ObjectInherit
                  | System.Security.AccessControl.InheritanceFlags.ContainerInherit
                : System.Security.AccessControl.InheritanceFlags.None;
            if (inheritance == System.Security.AccessControl.InheritanceFlags.None)
            {
                var file = new FileInfo(target);
                var security = file.GetAccessControl();
                Narrow(security, owner, inheritance);
                file.SetAccessControl((System.Security.AccessControl.FileSecurity)security);
            }
            else
            {
                var directory = new DirectoryInfo(target);
                var security = directory.GetAccessControl();
                Narrow(security, owner, inheritance);
                directory.SetAccessControl((System.Security.AccessControl.DirectorySecurity)security);
            }
        }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException
                                          or PlatformNotSupportedException
                                          or System.Security.SecurityException
                                          or InvalidOperationException)
        {
            // The cache keeps whatever its directory granted.
        }

        static bool isDirectoryTarget(string path) => Directory.Exists(path);

        static void Narrow(
            System.Security.AccessControl.FileSystemSecurity security,
            System.Security.Principal.SecurityIdentifier owner,
            System.Security.AccessControl.InheritanceFlags inheritance)
        {
            security.SetAccessRuleProtection(isProtected: true, preserveInheritance: false);
            var existing = security.GetAccessRules(
                includeExplicit: true, includeInherited: true,
                targetType: typeof(System.Security.Principal.SecurityIdentifier));
            foreach (System.Security.AccessControl.FileSystemAccessRule rule in existing)
                security.RemoveAccessRuleSpecific(rule);
            security.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(
                owner,
                System.Security.AccessControl.FileSystemRights.FullControl,
                inheritance,
                System.Security.AccessControl.PropagationFlags.None,
                System.Security.AccessControl.AccessControlType.Allow));
        }
    }

    /// <summary>Delete a file whose absence is all that matters: the temporary a failed write
    /// left behind. The cache file itself goes through <see cref="DeleteTheTokenFile"/>, which
    /// reports instead, because a token still on disk is not the same as a stray temporary still
    /// on disk.</summary>
    private static void TryDelete(string path)
    {
        try
        {
            File.Delete(path);
        }
        catch (Exception)
        {
            // best effort
        }
    }

    private sealed class Scope : ITokenRefreshScope
    {
        private readonly FileTokenStore _store;
        private readonly FileStream _sidecar;
        private bool _released;

        public Scope(FileTokenStore store, FileStream sidecar)
        {
            _store = store;
            _sidecar = sidecar;
        }

        public Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(
            CancellationToken cancellationToken = default) =>
            Task.FromResult(_store.ReadNamespaceRecord());

        public Task WriteTokenRecordAsync(
            IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default)
        {
            _store.WriteNamespaceRecord(record);
            return Task.CompletedTask;
        }

        public Task ClearTokenRecordAsync(CancellationToken cancellationToken = default)
        {
            _store.ClearNamespaceRecord();
            return Task.CompletedTask;
        }

        public ValueTask DisposeAsync()
        {
            if (!_released)
            {
                _released = true;
                // The sidecar handle is closed, which is what releases the OS lock; the file
                // stays. Unlinking it would end mutual exclusion outright - see
                // ClearNamespaceRecord.
                _sidecar.Dispose();
                _store._guard.Gate.Release();
            }
            return default;
        }
    }
}
