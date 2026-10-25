namespace Exsited.Auth;

/// <summary>
/// The token-store operations that run under an already-held refresh lock.
/// Disposing the scope releases the lock (and any cross-process file lock).
/// </summary>
public interface ITokenRefreshScope : IAsyncDisposable
{
    /// <summary>The stored token, read under the held lock.</summary>
    Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(CancellationToken cancellationToken = default);

    /// <summary>Persist a token under the held lock.</summary>
    Task WriteTokenRecordAsync(IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default);

    /// <summary>Discard the stored token under the held lock.</summary>
    Task ClearTokenRecordAsync(CancellationToken cancellationToken = default);
}
