using SevenSeas.Utilities.Application.Responses.Interfaces;

namespace SevenSeas.Utilities.Application.Responses;

public class AppPaginatedResponse<TData> :
    AppResponse<TData>,
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
        uint totalPages,
        uint pageSize,
        uint page,
        uint totalRecords
    )
    {
        TotalPages = totalPages;
        PageSize = pageSize;
        Page = page;
        TotalRecords = totalRecords;
    }

    # endregion
}
