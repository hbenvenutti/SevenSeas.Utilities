using Newtonsoft.Json;

namespace SevenSeas.Utilities.Application.Responses.Interfaces;

public class AppPaginatedResponse<TData> :
    AppResponse<TData>,
    IPaginatedResponse
{
    # region ---- Properties ---------------------------------------------------

    [JsonProperty("totalPages")]
    public uint TotalPages { get; init; }

    [JsonProperty("pageSize")]
    public uint PageSize { get; init; }

    [JsonProperty("page")]
    public uint Page { get; init; }

    [JsonProperty("totalRecords")]
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
