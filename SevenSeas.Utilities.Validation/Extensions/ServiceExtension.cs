using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace SevenSeas.Utilities.Validation.Extensions;

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
