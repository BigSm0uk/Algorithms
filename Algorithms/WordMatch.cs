namespace Algorithms;

public static class WordMatch
{
    private static void Main()
    {
        const string wrongWord = "fosh";
        var dictionary = new[] { "fish", "vista" }; 
        FindMatch(wrongWord, dictionary);
    }

    public static string FindMatch(string wrongWord, string[] dictionary)
    {
        for (var i = 0; i < dictionary.Length; i++)
        {
            var matrix = new int[wrongWord.Length,dictionary[i].Length];
            for (var j = 0; j < wrongWord.Length; j++)
            {
                for (var k = 0; k < dictionary[i].Length; k++)
                {
                    
                }
            }
        }
        return "";
    }
}