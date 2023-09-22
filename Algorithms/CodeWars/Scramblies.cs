namespace Algorithms.CodeWars;

public static class Scramblies
{
    public static void Main()
    {
        Console.WriteLine(Scramble("scriptjavx","javascript"));
    }

    private static bool Scramble(string str1, string str2)
    {
        var str1AsDictionary = str1.GroupBy(c=>c).ToDictionary(c=>c.Key, x=>x.Count());
        var str2AsSpan = str2.AsSpan();
        foreach (var t in str2AsSpan)
        {
            if (!str1AsDictionary.ContainsKey(t) || str1AsDictionary[t] <= 0)return false;
            str1AsDictionary[t] -= 1;
        }
        return true;
    }

}