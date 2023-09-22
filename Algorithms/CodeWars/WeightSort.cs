using System.Text;

namespace Algorithms.CodeWars;

public static class WeightSort
{
    public static void Main()
    {
        Console.WriteLine(OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
    }

    private static string OrderWeight(string str)
    {
        return string.Join(" ", str.Split(" ")
            .OrderBy(n => n.ToCharArray()
                .Select(c=>(int)char.GetNumericValue(c)).Sum())
            .ThenBy(n=>n));
    }
    
}