using CodeRoom.Utilities.DependencyInjection.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRoom.Utilities.DependencyInjection.Options;

public static class OptionsInjection
{
    public static void AddUtilityOptions(
        this IServiceCollection services
    )
    {
        services.AddLogOptions();
    }
}
