namespace SevenSeas.Utilities.ValueTypes.Exceptions;

public abstract class InvalidValueException : Exception
{
    /// <inheritdoc />
    protected InvalidValueException(string message) :
        base(message: message)
    {
    }
}
