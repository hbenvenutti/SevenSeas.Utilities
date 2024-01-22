using System.Text.RegularExpressions;

namespace SevenSeas.Utilities.Extensions.Services;

public partial class RegexService
{
    # region ---- Remove Masks -------------------------------------------------

    [GeneratedRegex(pattern: @"[^\d]")]
    private static partial Regex OnlyNumbersRegex();

    public static string GetOnlyNumbers(string value) => OnlyNumbersRegex()
        .Replace(input: value, replacement: "");

    # endregion

    # region ---- zip code -----------------------------------------------------

    [GeneratedRegex(pattern: @"^(\d{5})(\d{3})$")]
    private static partial Regex ZipCodeMask();

    public static string MaskZipCode(string value) => ZipCodeMask()
        .Replace(input: value, replacement: @"$1-$2");

    # endregion

    # region ---- phone --------------------------------------------------------

    [GeneratedRegex(pattern: @"^(\d{2})(\d{4,5})(\d{4})$")]
    private static partial Regex PhoneMask();

    public static string MaskPhone(string value) => PhoneMask()
        .Replace(input: value, replacement: @"($1) $2-$3");

    public static string SecurityMaskPhone(string value) => PhoneMask()
        .Replace(input: value, replacement: @"($1) ****-$3");

    # endregion

    # region ---- cnpj ---------------------------------------------------------

    [GeneratedRegex(pattern: @"^(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})$")]
    private static partial Regex CnpjMask();

    public static string MaskCnpj(string value) => CnpjMask()
        .Replace(input: value, replacement: "$1.$2.$3/$4-$5");

    public static string SecurityMaskCnpj(string value) => CnpjMask()
        .Replace(input: value, replacement: "**.$2.$3/****-**");

    # endregion

    # region ---- remove white space -------------------------------------------

    [GeneratedRegex(pattern: @"\s+")]
    private static partial Regex WhiteSpace();

    public static string RemoveWhiteSpace(string value) => WhiteSpace()
        .Replace(input: value, replacement: "");

    # endregion
}
