namespace Algorithms.CodeWars;
/*The Western Suburbs Croquet Club has two categories of membership, Senior and Open. They would like your help with an application form that will tell prospective members which category they will be placed.

To be a senior, a member must be at least 55 years old and have a handicap greater than 7. In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

Input
Input will consist of a list of pairs. Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.

Output
Output will consist of a list of string values (in Haskell and C: Open or Senior) stating whether the respective member is to be placed in the senior or open category.*/

public class CategorizeNewMember
{
    public static void Main()
    {
        var test = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
        OpenOrSenior(test);
    }

    private static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        var result = new string[data.Length];
        for (var i = 0; i < data.Length; i++)
        {
            if(data[i][0] >= 55)
            {
                if (data[i][1] > 7)
                {
                    result[i] = "Senior";
                    continue;
                }
            }
            result[i] = "Open";
        }
        return result;
    }
}