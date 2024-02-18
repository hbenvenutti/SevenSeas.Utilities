using CodeRoom.Utilities.Application.Enums;
using CodeRoom.Utilities.Application.Responses.Interfaces;
using CodeRoom.Utilities.Application.Types;

namespace CodeRoom.Utilities.Application.Responses;

/// <inheritdoc />
public class AppResponse : IAppResponse<object, AppStatusCode>
{
    public bool Success { get; init; }
    public AppStatusCode AppStatusCode { get; init; }
    public List<string> Errors { get; init; }
    public object? Data { get; init; }

    public AppResponse(
        bool success,
        AppStatusCode appStatusCode,
        Errors errors = default,
        object? data = default
    )
    {
        Success = success;
        AppStatusCode = appStatusCode;
        Errors = errors;
        Data = data;
    }
}
