using System.Net;

namespace SevenSeas.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Interface for HTTP responses
/// </summary>

public interface IHttpResponse
{
    /// <summary>
    /// Gets the status code of the HTTP response
    /// </summary>
    HttpStatusCode StatusCode { get; init; }
}
