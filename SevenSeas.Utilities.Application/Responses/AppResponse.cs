using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses.Interfaces;
using SevenSeas.Utilities.Application.Types;

namespace SevenSeas.Utilities.Application.Responses;

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
