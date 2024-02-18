using CodeRoom.Utilities.Application.Enums;

namespace CodeRoom.Utilities.Application.Exceptions;

/// <summary>
/// Exception for the application.
/// </summary>
public class AppException : Exception
{
    /// <summary>
    /// Application status code.
    /// </summary>
    public AppStatusCode StatusCode { get; init; }

    public AppException(
        string message,
        AppStatusCode statusCode = AppStatusCode.UnexpectedError
    )
    : base(message)
    {
        StatusCode = statusCode;
    }
}
