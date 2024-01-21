namespace SevenSeas.Utilities.Application.Enums;

public enum AppStatusCode
{
    # region ---- Database 7 ---------------------------------------------------

    DatabaseErrorOnSave = 7_500,
    DatabaseErrorOnCreate = 7_501,
    DatabaseErrorOnUpdate = 7_502,
    DatabaseErrorOnDelete = 7_503,
    DatabaseErrorOnQuery = 7_504,
    DatabaseErrorOnGet = 7_505,
    DatabaseErrorOnSeed = 7_506,

    # endregion

    # region ---- Gateways 9 ---------------------------------------------------

    InaccessibleGateway = 9_500,
    GatewayTimeout = 9_501,
    GatewayError = 9_502,

    # endregion
}
