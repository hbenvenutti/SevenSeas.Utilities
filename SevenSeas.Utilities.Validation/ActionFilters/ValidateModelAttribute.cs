using CodeRoom.Utilities.Application.Enums;
using CodeRoom.Utilities.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

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
