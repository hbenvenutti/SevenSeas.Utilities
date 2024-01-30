using System.Net;
using SevenSeas.Utilities.Application.Enums;
using SevenSeas.Utilities.Application.Responses;

namespace SevenSeas.Utilities.Application.Extensions;

public static class AppResponseExtension
{
    public static HttpStatusCode ToHttpStatusCode(this AppResponse response)
    {
        switch (response.AppStatusCode)
        {
            case AppStatusCode.Success:
            {
                return HttpStatusCode.OK;
            }

            case AppStatusCode.NotFound:
            {
                return HttpStatusCode.NotFound;
            }

            case AppStatusCode.Created:
            case AppStatusCode.CreatedTransaction:
            {
                return HttpStatusCode.Created;
            }

            case AppStatusCode.ValidationError:
            {
                return HttpStatusCode.BadRequest;
            }

            case AppStatusCode.GatewayTimeout:
            {
                return HttpStatusCode.GatewayTimeout;
            }

            case AppStatusCode.InaccessibleGateway:
            case AppStatusCode.GatewayAuthenticationError:
            case AppStatusCode.GatewayAuthorizationError:
            {
                return HttpStatusCode.BadGateway;
            }

            case AppStatusCode.UnexpectedError:
            default:
            {
                return HttpStatusCode.InternalServerError;
            }
        }
    }
}
