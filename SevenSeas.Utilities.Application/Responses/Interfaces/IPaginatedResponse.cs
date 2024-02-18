using Newtonsoft.Json;

namespace CodeRoom.Utilities.Application.Responses.Interfaces;

/// <summary>
/// Represents a paginated response.
/// </summary>
/// <remarks>
/// This interface provides properties for total pages, page size, page number,
/// and total records.
/// </remarks>
public interface IPaginatedResponse
{
    /// <summary>
    /// The total number of pages in the paginated response.
    /// </summary>

    [JsonProperty("totalPages")]
    uint TotalPages { get; init; }

    /// <summary>
    /// Number of records in each page.
    /// </summary>

    [JsonProperty("pageSize")]
    uint PageSize { get; init; }

    /// <summary>
    /// The page number.
    /// </summary>

    [JsonProperty("page")]
    uint Page { get; init; }

    /// <summary>
    /// The total number of records in all pages.
    /// </summary>

    [JsonProperty("totalRecords")]
    uint TotalRecords { get; init; }
}
