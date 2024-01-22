using Microsoft.AspNetCore.Mvc;
using SevenSeas.Utilities.Validation.ActionFilters;

namespace SevenSeas.Utilities.Validation.Extensions;

public static class ControllerExtension
{
    public static void AddSevenSeasValidation(this MvcOptions options)
    {
        options.Filters.Add(item: new ValidateModelAttribute());
    }
}
