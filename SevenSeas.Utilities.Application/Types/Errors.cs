using System.Collections.ObjectModel;

namespace CodeRoom.Utilities.Application.Types;

public struct Errors
{
    private readonly List<string> _values;

    # region ---- Constructor --------------------------------------------------

    private Errors(IEnumerable<string> values)
    {
        _values = values.ToList();
    }

    # endregion

    # region ---- Operators ----------------------------------------------------

    public static implicit operator Errors(string message)
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
