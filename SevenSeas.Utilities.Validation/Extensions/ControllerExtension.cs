using Microsoft.AspNetCore.Mvc;
using SevenSeas.Utilities.Validation.ActionFilters;
using SevenSeas.Utilities.Validation.ExceptionFilters;

namespace SevenSeas.Utilities.Validation.Extensions;

public static class ControllerExtension
{
    public static void AddSevenSeasValidation(this MvcOptions options)
    {
        options.Filters.Add(item: new ValidateModelAttribute());
        options.Filters.Add(item: new HttpApplicationExceptionFilter());
    }
}
