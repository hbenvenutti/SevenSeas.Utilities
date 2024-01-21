using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses.Interfaces;
using GrpcStatus = Grpc.Core.Status;

namespace SevenSeas.Utilities.Application.Responses.Grpc;

/// <summary>
/// Represents a gRPC response.
/// </summary>
/// <typeparam name="TData">The type of the data in the response.</typeparam>
public class GrpcResponse<TData> :
    IGrpcResponse,
    IAppResponse<TData, AppStatusCode>
{
    /// <inheritdoc />
    public GrpcStatus GrpcStatus { get; init; }

    /// <inheritdoc />
    public bool Success { get; init; }

    /// <inheritdoc />
    public AppStatusCode AppStatusCode { get; init; }

    /// <inheritdoc />
    public IList<string>? Errors { get; init; }

    /// <inheritdoc />
    public TData? Data { get; init; }
}
