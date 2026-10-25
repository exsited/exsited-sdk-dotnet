namespace Exsited.Auth;

/// <summary>
/// Where an access token lives between calls: persistence plus refresh coordination. Stores
/// move plain maps - the on-disk cache format - so <see cref="TokenRecord"/> stays in its own
/// file.
///
/// <para>The refresh lock is <b>not reentrant</b>, which is why
/// <see cref="AcquireTokenRefreshLockAsync"/> returns an <see cref="ITokenRefreshScope"/>
/// carrying its own read/write/clear: those run under the already-held lock. Calling the
/// standalone <see cref="WriteTokenRecordAsync"/> or <see cref="ClearTokenRecordAsync"/> from
/// inside a held scope deadlocks.</para>
/// </summary>
public interface ITokenStore
{
    /// <summary>The stored token, or <c>null</c> when absent or unreadable.</summary>
    Task<IReadOnlyDictionary<string, object?>?> ReadTokenRecordAsync(CancellationToken cancellationToken = default);

    /// <summary>Persist a token, replacing whatever was there; takes and releases the refresh lock.</summary>
    Task WriteTokenRecordAsync(IReadOnlyDictionary<string, object?> record, CancellationToken cancellationToken = default);

    /// <summary>Discard the stored token; a no-op when there is none; takes and releases the
    /// refresh lock.
    ///
    /// <para><b>Absence is success; nothing else is.</b> A store that could not remove the token
    /// it holds throws, because a caller told the token was cleared stops looking for it - and a
    /// logout or a credential revocation that reported success while leaving a usable token
    /// behind is the one failure here that matters.</para></summary>
    /// <exception cref="Errors.SdkError">the token is still stored.</exception>
    Task ClearTokenRecordAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Hold the refresh lock for the lifetime of the returned scope, so only one worker
    /// fetches a new token. Read/write/clear <b>through the scope</b> while it is held; the
    /// standalone methods would wait on the same lock.
    /// </summary>
    Task<ITokenRefreshScope> AcquireTokenRefreshLockAsync(CancellationToken cancellationToken = default);
}
