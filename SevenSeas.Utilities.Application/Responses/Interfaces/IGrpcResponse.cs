using Newtonsoft.Json;
using GrpcStatus = Grpc.Core.Status;

namespace CodeRoom.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Interface for a gRPC response.
/// </summary>
public interface IGrpcResponse
{
    /// <summary>
    /// The gRPC status of the response.
    /// </summary>

    [JsonProperty("grpcStatus")]
    GrpcStatus GrpcStatus { get; init; }
}
