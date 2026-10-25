namespace Exsited.Errors;

/// <summary>
/// The cross-process lock over the token cache could not be taken.
///
/// <para>Thrown rather than running the mutation anyway. A thread-only critical section is not
/// exclusion between processes: two processes sharing one cache file would both believe they
/// were inside it, and one would overwrite the other's entry, refresh token included.</para>
///
/// <para>An <see cref="SdkError"/>, so one <c>catch (SdkError)</c> still catches it.</para>
/// </summary>
public class SdkTokenLockError : SdkError
{
    /// <summary>Creates a token-lock error.</summary>
    public SdkTokenLockError(string message, Exception? inner = null)
        : base(message, innerException: inner) { }
}
