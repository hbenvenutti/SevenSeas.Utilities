using System.Text.RegularExpressions;

namespace SevenSeas.Utilities.Extensions.Services;

public partial class CpfRegex
{
    [GeneratedRegex(pattern: @"^(\d{3})(\d{3})(\d{3})(\d{2}$)")]
    private static partial Regex CpfMask();

    public static string Mask(string value) => CpfMask()
        .Replace(input: value, replacement: "$1.$2.$3-$4");

    public static string SecurityMask(string value) => CpfMask()
        .Replace(input: value, replacement: "***.$2.$3-**");
}
