using CodeRoom.Utilities.Application.Options;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRoom.Utilities.DependencyInjection.Logging;

public static class LogOptionsInjection
{
    public static void AddLogOptions(this IServiceCollection services)
    {
        services.AddOptions<LoggingOptions>()
            .BindConfiguration(LoggingOptions.Section)
            .ValidateDataAnnotations()
            .ValidateOnStart();
    }
}
