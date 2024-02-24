using Microsoft.AspNetCore.Mvc;
using SevenSeas.Utilities.Validation.ActionFilters;
using SevenSeas.Utilities.Validation.ExceptionFilters;

namespace CodeRoom.Utilities.DependencyInjection.Validation;

public static class ValidationInjection
{
    public static void AddCodeRoomValidation(this MvcOptions options)
    {
        options.Filters.Add(item: new ValidateModelAttribute());
        options.Filters.Add(item: new HttpApplicationExceptionFilter());
    }
}
