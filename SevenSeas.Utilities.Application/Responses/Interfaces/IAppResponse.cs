namespace SevenSeas.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Interface for the application response.
/// </summary>
/// <typeparam name="TData">The type of the data in the response.</typeparam>
/// <typeparam name="TStatusCode">The type of the status code in the response.</typeparam>
public interface IAppResponse<TData, TStatusCode>
{
    /// <summary>
    /// Gets a value indicating whether the response was successful.
    /// </summary>
    bool Success { get; init; }

    /// <summary>
    /// Gets the application status code.
    /// </summary>
    TStatusCode AppStatusCode { get; init; }

    /// <summary>
    /// Gets the list of errors, if any.
    /// </summary>
    IList<string>? Errors { get; init; }

    /// <summary>
    /// Gets the response data.
    /// </summary>
    TData? Data { get; init; }
}
