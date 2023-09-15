namespace Algorithms.CodeWars;

public static class WhoLikesIt
{
    public static void Main()
    {
        Console.WriteLine(Likes(new[] { "Alex", "Jacob", "Mark", "Max" }));
    }

    private static string Likes(IReadOnlyList<string> name)
    {
        return name.Count switch
        {
            1 => name[0] + " likes this",
            2 => $"{name[0]} and {name[1]} like this",
            3 => $"{name[0]}, {name[1]} and {name[2]} like this",
            0 => "no one likes this",
            _ => $"{name[0]}, {name[1]} and {name.Count - 2} others like this",
        };
    }
}