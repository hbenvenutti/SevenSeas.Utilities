using SevenSeas.Utilities.Extensions.Extensions;

namespace SevenSeas.Utilities.Extensions.Services;

/// <summary>
/// ModuleEleven class with methods to calculate a specific value.
/// </summary>
public static class ModuleEleven
{
    /// <summary>
    /// Calculates the sum of the products of the document characters and
    /// multipliers.
    /// </summary>
    /// <param name="document">The document to calculate the sum for.</param>
    /// <param name="multipliers">
    /// The multipliers to use for the calculation.
    /// </param>
    /// <returns>The calculated sum.</returns>
    private static uint Sum(string document, IEnumerable<byte> multipliers) =>
        (uint) multipliers
            .Select((multiplier, @char) => document[@char].ToInt() * multiplier)
            .Sum();

    /// <summary>
    /// Calculates the module eleven value for the document and multipliers.
    /// </summary>
    /// <param name="document">The document to calculate the value for.</param>
    /// <param name="multipliers">
    /// The multipliers to use for the calculation.
    /// </param>
    /// <returns>The module eleven value.</returns>
    public static byte Calculate(
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

    /// <summary>
    /// Calculates the module eleven value for the document and multipliers.
    /// </summary>
    /// <param name="document">The document to calculate the value for.</param>
    /// <param name="multipliers1">
    /// The multipliers to use for the first digit calculation.
    /// </param>
    /// <param name="multipliers2">
    /// The multipliers to use for the second digit calculation.
    /// </param>
    /// <returns>The two digits module eleven value.</returns>
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
