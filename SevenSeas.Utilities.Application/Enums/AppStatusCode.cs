namespace SevenSeas.Utilities.Application.Enums;

public enum AppStatusCode
{
    # region ---- Use Cases 1 --------------------------------------------------

    Success = 1_000,
    SuccessNotFound = 1_001,
    Created = 1_010,
    TransactionSuccess = 1_020,
    TransactionFailed = 1_520,
    Updated = 1_002,
    Deleted = 1_003,
    Query = 1_004,
    Get = 1_005,
    Seed = 1_006,

    # endregion

    # region ---- Errors 5 -------------------------------------------------

    ValidationError = 5_000,
    UnexpectedError = 5_501,

    # endregion

    # region ---- Database 7 ---------------------------------------------------

    DatabaseNotFound = 7_000,
    DatabaseCreated = 7_001,
    DatabaseUpdated = 7_002,
    DatabaseDeleted = 7_003,
    DatabaseQuery = 7_004,
    DatabaseSeed = 7_005,

    DatabaseErrorOnSave = 7_500,
    DatabaseErrorOnCreate = 7_501,
    DatabaseErrorOnUpdate = 7_502,
    DatabaseErrorOnDelete = 7_503,
    DatabaseErrorOnQuery = 7_504,
    DatabaseErrorOnSeed = 7_505,

    # endregion

    # region ---- Gateways 9 ---------------------------------------------------

    SentToGateway = 9_000,

    GatewayNotFound = 9_201,
    GatewayCreated = 9_202,
    GatewayUpdated = 9_203,
    GatewayDeleted = 9_204,
    GatewayQuery = 9_205,
    GatewaySeed = 9_206,

    GatewayAuthenticationSuccess = 9_010,
    GatewayAuthenticationError = 9_510,
    GatewayAuthorizationError = 9_511,

    InaccessibleGateway = 9_500,
    GatewayTimeout = 9_501,
    GatewayError = 9_502,
    GatewayBadRequest = 9_503,

    # endregion
}
