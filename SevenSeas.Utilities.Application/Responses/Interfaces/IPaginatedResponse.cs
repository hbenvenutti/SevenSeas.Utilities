namespace SevenSeas.Utilities.Application.Responses.Interfaces;

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
    /// Gets the total number of pages in the paginated response.
    /// </summary>
    uint TotalPages { get; }

    /// <summary>
    /// Gets or initializes the page number in the paginated response.
    /// </summary>
    uint PageSize { get; init; }

    /// <summary>
    /// Gets or initializes the total number of records in the paginated
    /// response.
    /// </summary>
    uint Page { get; init; }
    uint TotalRecords { get; init; }
}
