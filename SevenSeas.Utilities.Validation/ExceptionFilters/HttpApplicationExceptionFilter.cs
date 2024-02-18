using CodeRoom.Utilities.Application.Enums;
using CodeRoom.Utilities.Application.Exceptions;
using CodeRoom.Utilities.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SevenSeas.Utilities.Validation.ExceptionFilters;

public class HttpApplicationExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var response = new AppResponse(
            success: false,
            appStatusCode: context.Exception is AppException exception
                ? exception.StatusCode
                : AppStatusCode.UnexpectedError,
            errors: context.Exception.Message
        );

        context.Result = new ObjectResult(response);
    }
}
