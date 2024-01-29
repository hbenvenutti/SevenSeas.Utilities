using System.Collections.ObjectModel;

namespace SevenSeas.Utilities.Application.Types;

public struct Errors
{
    private readonly List<string> _values;

    # region ---- constructor --------------------------------------------------

    private Errors(IEnumerable<string> values)
    {
        _values = values.ToList();
    }

    # endregion

    # region ---- operators ----------------------------------------------------

    public static implicit operator Errors?(string message)
    {
        return new Errors([message]);
    }

    public static implicit operator Errors(List<string> messages)
    {
        return new Errors(messages);
    }

    public static implicit operator Errors(Collection<string> messages)
    {
        return new Errors(messages);
    }

    public static implicit operator List<string>(Errors errors) =>
        errors._values;

    # endregion
}
