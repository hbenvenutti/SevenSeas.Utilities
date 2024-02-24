using System.ComponentModel.DataAnnotations;
using Grpc.Core.Logging;

namespace CodeRoom.Utilities.Application.Options;

public class LoggingOptions
{
    public const string Section = "Logging";
    
    [Required]
    public required LogLevel LogLevel { get; init; }
}
