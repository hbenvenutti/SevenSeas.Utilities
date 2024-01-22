namespace SevenSeas.Utilities.ValueTypes.Exceptions;

/// <inheritdoc />
public class InvalidCpfException : InvalidValueException
{
    private const string ErrorMessage = "is not a valid Cpf.";

    public InvalidCpfException(string value) :
        base(message: $"{value} {ErrorMessage}")
    {
    }
}
