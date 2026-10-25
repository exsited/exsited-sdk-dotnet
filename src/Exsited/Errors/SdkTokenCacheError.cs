namespace Exsited.Errors;

/// <summary>
/// The token cache file is present and cannot be used.
///
/// <para>Distinct from an <b>absent</b> cache, which is an ordinary state and costs one
/// authentication. This is thrown instead of reading such a file as empty, because every
/// mutation rewrites the whole file from what the read returned: answering "no namespaces" for
/// a file that could not be parsed would make the next write delete every other namespace's
/// entry, refresh tokens that belong to other credentials included.</para>
///
/// <para>An <see cref="SdkError"/>, so one <c>catch (SdkError)</c> still catches it.</para>
/// </summary>
public class SdkTokenCacheError : SdkError
{
    /// <summary>Creates a token-cache error.</summary>
    public SdkTokenCacheError(string message, Exception? inner = null)
        : base(message, innerException: inner) { }
}
