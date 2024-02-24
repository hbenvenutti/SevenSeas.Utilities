using CodeRoom.Utilities.Extensions.Extensions;

namespace CodeRoom.Utilities.Extensions.Services;

public static class ModuleEleven
{
    private static uint Sum(string document, IEnumerable<byte> multipliers) =>
        (uint) multipliers
            .Select((multiplier, @char) => document[@char].ToInt() * multiplier)
            .Sum();

    private static byte Calculate(
        string document,
        IEnumerable<byte> multipliers
    )
    {
        var sum = Sum(
            document: document,
            multipliers: multipliers
        );

        var rest = sum % 11;

        return (byte) (rest < 2
                ? 0
                : 11 - rest
            );
    }

    public static string Calculate(
        string document,
        IEnumerable<byte> multipliers1,
        IEnumerable<byte> multipliers2
    )
    {
        var digits = Calculate(document, multipliers1).ToString();

        digits += Calculate(
            document: document + digits,
            multipliers2
        );

        return digits;
    }
}
