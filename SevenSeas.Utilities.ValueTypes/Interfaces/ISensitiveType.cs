namespace SevenSeas.Utilities.ValueTypes.Interfaces;

/// <summary>
/// Interface to add security mask to data annotations.
/// </summary>
public interface ISensitiveType
{
    /// <summary>
    /// Security mask that hides sensitive information.
    /// </summary>
    string SecurityMask { get; }
}
