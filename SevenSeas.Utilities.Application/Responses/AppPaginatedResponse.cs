using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses.Interfaces;
using SevenSeas.Utilities.Application.Types;

namespace SevenSeas.Utilities.Application.Responses;

public class AppPaginatedResponse :
    AppResponse,
    IPaginatedResponse
{
    # region ---- Properties ---------------------------------------------------

    public uint TotalPages { get; init; }
    public uint PageSize { get; init; }
    public uint Page { get; init; }
    public uint TotalRecords { get; init; }

    # endregion

    # region ---- Constructor --------------------------------------------------

    public AppPaginatedResponse(
        object data,
        uint totalPages,
        uint pageSize,
        uint page,
        uint totalRecords,
        Errors? errors = default
    ) : base(
        success: true,
        appStatusCode: AppStatusCode.Success,
        data: data,
        errors: errors
    )
    {
        TotalPages = totalPages;
        PageSize = pageSize;
        Page = page;
        TotalRecords = totalRecords;
    }

    # endregion
}
