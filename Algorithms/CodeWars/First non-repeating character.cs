namespace Algorithms.CodeWars;

public static class First_non_repeating_character
{
    public static void Main()
    {
        Console.WriteLine(FirstNonRepeatingLetter("sTreSs"));
    }

    private static string FirstNonRepeatingLetter(string s)
    {
        var res = s.ToLower().GroupBy(c => c).FirstOrDefault(c => c.Count() == 1)?.Key;
        if (res is null) return "";
        var index = s.IndexOf((char)res, StringComparison.OrdinalIgnoreCase);
        return s.Substring(index, 1);
    }
}