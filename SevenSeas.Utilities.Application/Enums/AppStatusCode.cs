namespace SevenSeas.Utilities.Application.Enums;

public enum AppStatusCode
{
    # region ---- Use Cases 1 --------------------------------------------------

    Success = 1_000,
    NotFound = 1_001,
    Created = 1_010,
    CreatedTransaction = 1_020,
    Updated = 1_002,
    Deleted = 1_003,

    # endregion

    # region ---- Errors 5 -----------------------------------------------------

    ValidationError = 5_000,
    UnexpectedError = 5_501,

    # endregion

    # region ---- Database 7 ---------------------------------------------------

    DatabaseErrorOnSave = 7_500,
    DatabaseErrorOnCreate = 7_501,
    DatabaseErrorOnUpdate = 7_502,
    DatabaseErrorOnDelete = 7_503,
    DatabaseErrorOnQuery = 7_504,
    DatabaseErrorOnSeed = 7_505,

    # endregion

    # region ---- Gateways 9 ---------------------------------------------------

    GatewayAuthenticationError = 9_510,
    GatewayAuthorizationError = 9_511,

    InaccessibleGateway = 9_500,
    GatewayTimeout = 9_501,

    # endregion
}
