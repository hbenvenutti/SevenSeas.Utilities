using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRoom.Utilities.DependencyInjection.Validation;

public static class ServiceExtension
{
    public static void SuppressDefaultFilterValidation(
        this IServiceCollection services
    )
    {
        services.Configure<ApiBehaviorOptions>(options =>
            options.SuppressModelStateInvalidFilter = true
        );
    }
}
