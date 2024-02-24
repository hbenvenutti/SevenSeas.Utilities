namespace CodeRoom.Utilities.Extensions.Extensions;

public static class StringExtension
{
    public static bool IsAlphabetic(this string value) =>
        value.All(char.IsLetter);

    public static bool IsNumeric(this string value) => value.All(char.IsDigit);

    public static bool AreAllCharsTheSame(this string value) =>
        value.All(@char => @char == value[0]);
}
