using System.Net;
using Newtonsoft.Json;

namespace SevenSeas.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Interface for HTTP responses.
/// </summary>

public interface IHttpResponse
{
    /// <summary>
    /// Gets the status code of the HTTP response.
    /// </summary>

    [JsonProperty("httpStatusCode")]
    HttpStatusCode HttpStatusCode { get; init; }
}
