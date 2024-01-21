namespace SevenSeas.Utilities.ValueTypes.Interfaces;

/// <summary>
/// Interface for a generator.
/// </summary>

public interface IGenerator<out T>
{
    /// <summary>
    /// Generates a random valid instance of the object.
    /// </summary>
    /// <returns>A instance of the object.</returns>
    /// <remarks>
    /// The generated instance is guaranteed to be valid.
    /// </remarks>

    public static abstract T Generate();
}
