namespace Exsited.Errors;

/// <summary>A caller mistake the SDK detects before any network I/O.</summary>
public class SdkUsageError : SdkError
{
    public SdkUsageError(string message, Exception? inner = null)
        : base(message, innerException: inner) { }
}
