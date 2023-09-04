namespace Algorithms.CodeWars;

public static class TwoSum
{
    public static void Main()
    {
        var arr = new[] { 1, 2, 3, 4 };
        Console.WriteLine(string.Join(", ", TwoSumMethod(arr, 5)));
    }

    private static IEnumerable<int> TwoSumMethod(int[] numbers, int target)
    {
        var hs = new HashSet<int>();
        for (var i = 0; i < numbers.Length; i++)
        {
            var needed = target - numbers[i];
            if (hs.Contains(needed))
            {
                return new[] { Array.IndexOf(numbers, needed), i };
            }
            hs.Add(numbers[i]);
        }
        return new[] { 0, 0 };
    }
}