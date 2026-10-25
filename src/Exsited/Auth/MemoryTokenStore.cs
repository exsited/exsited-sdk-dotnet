namespace Exsited.Auth;

/// <summary>
/// In-process token storage, isolated per instance: two clients with their own stores never
/// share a token. Nothing on disk. The gate is a non-reentrant <see cref="SemaphoreSlim"/>, so
/// the refresh scope operates on the field directly while the single permit is held.
/// </summary>
public sealed class MemoryTokenStore : ITokenStore
{
    private readonly SemaphoreSlim _gate = new(1, 1);
    private Dictionary<string, object?>? _record;

    /// <inheritdoc/>
    public async Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(
        CancellationToken cancellationToken = default)
    {
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            return ReadCore();
        }
        finally
        {
            _gate.Release();
        }
    }

    /// <inheritdoc/>
    public async Task WriteTokenRecordAsync(
        IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default)
    {
        await using var scope = await AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);
        await scope.WriteTokenRecordAsync(record, cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task ClearTokenRecordAsync(CancellationToken cancellationToken = default)
    {
        await using var scope = await AcquireTokenRefreshLockAsync(cancellationToken).ConfigureAwait(false);
        await scope.ClearTokenRecordAsync(cancellationToken).ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<ITokenRefreshScope> AcquireTokenRefreshLockAsync(
        CancellationToken cancellationToken = default)
    {
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        return new Scope(this);
    }

    // Copied, so callers cannot mutate the stored record in place.
    private IReadOnlyDictionary<string, object?>? ReadCore() =>
        _record is null ? null : new Dictionary<string, object?>(_record);

    private void WriteCore(IReadOnlyDictionary<string, object?> record) =>
        _record = new Dictionary<string, object?>(record);

    private void ClearCore() => _record = null;

    private sealed class Scope : ITokenRefreshScope
    {
        private readonly MemoryTokenStore _store;
        private bool _released;

        public Scope(MemoryTokenStore store) => _store = store;

        public Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(
            CancellationToken cancellationToken = default) =>
            Task.FromResult(_store.ReadCore());

        public Task WriteTokenRecordAsync(
            IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default)
        {
            _store.WriteCore(record);
            return Task.CompletedTask;
        }

        public Task ClearTokenRecordAsync(CancellationToken cancellationToken = default)
        {
            _store.ClearCore();
            return Task.CompletedTask;
        }

        public ValueTask DisposeAsync()
        {
            if (!_released)
            {
                _released = true;
                _store._gate.Release();
            }
            return default;
        }
    }
}
