using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses.Interfaces;

namespace SevenSeas.Utilities.Application.Responses;

/// <inheritdoc />
public class AppResponse<TData> : IAppResponse<TData, AppStatusCode>
{
    public bool Success { get; init; }
    public AppStatusCode AppStatusCode { get; init; }
    public IList<string>? Errors { get; init; }
    public TData? Data { get; init; }
}
