using Sahari.Common.Domain;

namespace Sahari.Common.Application.Exceptions;
public sealed class SahariException : Exception
{
    public SahariException(string requestName, Error? error = default, Exception? innerException = default)
        : base("Application exception", innerException)
    {
        RequestName = requestName;
        Error = error;
    }
    public string RequestName { get; }

    public Error? Error { get; }
}
