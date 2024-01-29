using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses;

namespace SevenSeas.Utilities.Validation.ActionFilters;

public class ValidateModelAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errorMessages = context.ModelState.Values
                .SelectMany(values => values.Errors)
                .Select(errors => errors.ErrorMessage)
                .ToList();

            var response = new AppResponse(
                success: false,
                appStatusCode: AppStatusCode.ValidationError,
                errors: errorMessages
            );

            context.Result = new BadRequestObjectResult(response);
        }
    }
}
