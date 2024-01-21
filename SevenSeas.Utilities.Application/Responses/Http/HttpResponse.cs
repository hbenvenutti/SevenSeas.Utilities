using System.Net;
using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses.Interfaces;

namespace SevenSeas.Utilities.Application.Responses.Http;

/// <summary>
/// Represents an HTTP response tha implements both <see cref="IHttpResponse"/>
/// and <see cref="IAppResponse{TData, TStatusCode}"/>.
/// </summary>
/// <typeparam name="TData">The type of the data in the response.</typeparam>
public class HttpResponse<TData> :
    IHttpResponse,
    IAppResponse<TData, AppStatusCode>
{
    /// <inheritdoc/>
    public bool Success { get; init; }

    /// <inheritdoc/>
    public HttpStatusCode HttpStatusCode { get; init; }

    /// <inheritdoc/>
    public AppStatusCode AppStatusCode { get; init; }

    /// <inheritdoc/>
    public IList<string>? Errors { get; init; }

    /// <inheritdoc/>
    public TData? Data { get; init; }
}
