using SevenSeas.Utilities.Extensions.Extensions;
using SevenSeas.Utilities.Extensions.Services;
using SevenSeas.Utilities.ValueTypes.Exceptions;

namespace SevenSeas.Utilities.ValueTypes.Brazil.Documents;

/// <summary>
/// Represents CPF number (Cadastro de Pessoas Física).
/// </summary>

public readonly ref struct Cpf
    // IMaskedType,
    // IGenerator<Cpf>,
    // ISensitiveType
{
    # region ---- Constants ----------------------------------------------------

    /// <summary> Default error message for an invalid CPF.</summary>
    public const string ErrorMessage = "CPF is invalid.";

    # endregion

    # region ---- Fields -------------------------------------------------------

    private readonly string _value;

    private ulong Numeric => ulong.Parse(_value);

    # endregion

    # region ---- Properties ---------------------------------------------------

    ///<summary>Gets the CPF with mask.</summary>
    public string Mask => CpfRegex.Mask(_value);

    /// <summary>Gets the CPF validation digits.</summary>
    public string Digits => _value[9..];

    ///<summary>Hides some digits of the CPF.</summary>
    public string SecurityMask => CpfRegex.SecurityMask(_value);

    # endregion

    # region ---- Constructor --------------------------------------------------

    private Cpf(string value)
    {
        _value = value;
    }

    # endregion

    # region ---- Parse --------------------------------------------------------

    public static Cpf Parse(string value)
    {
        if (!TryParse(value, out var cpf))
        {
            throw new InvalidCpfException(value);
        }

        return cpf;
    }

    /// <summary>
    /// Tries to parse the specified value and returns a Cpf instance.
    /// </summary>
    /// <param name="value">The string value to parse.</param>
    /// <param name="cpf">When this method returns, contains the parsed Cpf
    /// instance if the parsing was successful, or the default value if the
    /// parsing failed.</param>
    /// <returns><c>true</c> if the parsing was successful; otherwise,
    /// <c>false</c>.</returns>

    public static bool TryParse(string value, out Cpf cpf)
    {
        value = RegexService
            .GetOnlyNumbers(value)
            .PadLeft(totalWidth: 11, paddingChar: '0');

        if (!IsValid(value))
        {
            cpf = default;

            return false;
        }

        cpf = new Cpf(value);

        return true;
    }

    # endregion

    # region ---- Validation ---------------------------------------------------

    private static bool IsValid(string cpf)
    {
        if (cpf.Length > 11) { return false; }

        if (cpf.AreAllCharsTheSame()) { return false; }

        return cpf.EndsWith(
            value: CalculateDigits(cpf[..9]),
            StringComparison.Ordinal
        );
    }

    private static string CalculateDigits(string document)
    {
        byte[] multiplier1 = [10, 9, 8, 7, 6, 5, 4, 3, 2];
        byte[] multiplier2 = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

        var digits = ModuleEleven.Calculate(
            document: document,
            multipliers1: multiplier1,
            multipliers2: multiplier2
        );

        return digits;
    }

    # endregion

    # region ---- Generate -----------------------------------------------------

    /// <summary> Generates a new random Cpf.</summary>
    /// <returns>A new random Cpf.</returns>
    /// <remarks> This method is not thread safe. </remarks>
    public static Cpf Generate()
    {
        var random = new Random();

        var cpf = new byte[9];

        for (var i = 0; i < cpf.Length; i++)
        {
            cpf[i] = (byte)random.Next(maxValue: 10);
        }

        var str = string.Join("", cpf);

        if (str.AreAllCharsTheSame()) { return Generate(); }

        var digits = CalculateDigits(str);

        return $"{str}{digits}";
    }

    # endregion

    # region ---- Operators ----------------------------------------------------

    public static implicit operator Cpf(string value) => Parse(value);
    public static implicit operator Cpf(ulong value) => Parse(value.ToString());
    public static implicit operator string(Cpf cpf) => cpf.ToString();
    public static implicit operator ulong(Cpf cpf) => cpf.Numeric;

    public static bool operator == (Cpf left, Cpf right) => left.Equals(right);

    public static bool operator != (Cpf left, Cpf right) => !(left == right);

    #endregion

    # region ---- Overrides ----------------------------------------------------

    public override string ToString() => _value;

    public bool Equals(Cpf cpf)
    {
        return Numeric == cpf.Numeric;
    }

    public override int GetHashCode()
    {
        return _value.GetHashCode();
    }

    # endregion
}
