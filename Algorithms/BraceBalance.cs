namespace Algorithms;

public static class BraceBalance
{
    private static readonly Dictionary<char, char> Pairs = new()
        { { '[', ']' }, { '{', '}' }, { '(', ')' }, { '<', '>' }, };

    public static void Main()
    {
        Console.WriteLine(IsBalanced("()[]{}"));
        Console.WriteLine(IsBalanced("([]{"));
        Console.WriteLine(IsBalanced("[]"));
        Console.WriteLine(IsBalanced("[]{}"));
        Console.WriteLine(IsBalanced("()[}]{"));
    }

    private static bool IsBalanced(string text)
    {
        if (string.IsNullOrEmpty(text)) return false;
        var stack = new Stack<char>();
        foreach (var t in text.AsSpan())
        {
            if (Pairs.ContainsKey(t))
            {
                stack.Push(t); continue;
            }
            if (stack.Count == 0) return false;
            if (Pairs[stack.Pop()] != t) return false;
        }
        return stack.Count==0;
    }
}