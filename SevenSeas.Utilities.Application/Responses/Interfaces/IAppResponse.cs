using Newtonsoft.Json;

namespace SevenSeas.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Interface for the application response.
/// </summary>
/// <typeparam name="TData">The type of the data in the response.</typeparam>
/// <typeparam name="TStatusCode">The type of the status code in the response.
/// </typeparam>
public interface IAppResponse<TData, TStatusCode>
{
    /// <summary>
    /// Gets a value indicating whether the response was successful.
    /// </summary>

    [JsonProperty("success")]
    bool Success { get; init; }

    /// <summary>
    /// Gets the application status code.
    /// </summary>

    [JsonProperty("appStatusCode")]
    TStatusCode AppStatusCode { get; init; }

    /// <summary>
    /// Gets the list of errors, if any.
    /// </summary>

    [JsonProperty("errors")]
    List<string> Errors { get; init; }

    /// <summary>
    /// Gets the response data.
    /// </summary>

    [JsonProperty("data")]
    TData? Data { get; init; }
}
