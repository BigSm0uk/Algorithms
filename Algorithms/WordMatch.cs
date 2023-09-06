namespace Algorithms;

public static class WordMatch
{
    public static void Main()
    {
        const string wrongWord = "fosh";
        var dictionary = new[] { "fish", "vista", "fort"};
        Console.WriteLine(FindMatch(wrongWord, dictionary));
    }

    public static string FindMatch(string wrongWord, string[] dictionary)
    {
        var fondedMax = new int[dictionary.Length];
        for (var i = 0; i < dictionary.Length; i++)
        {
            var matrix = new int[dictionary[i].Length, wrongWord.Length];
            InitMatrix(matrix, wrongWord, dictionary[i]);
            for (var j = 1; j < dictionary[i].Length; j++)
            {
                for (var k = 1; k <  wrongWord.Length; k++)
                {
                    if (wrongWord[k] == dictionary[i][j])
                    {
                        var value = matrix[j - 1, k - 1] + 1;
                        matrix[k, j] = value;
                    }
                    else matrix[j, k] = Math.Max(matrix[j, k - 1], matrix[j - 1, k]);
                }
            }
            fondedMax[i] = matrix[dictionary[i].Length - 1,wrongWord.Length - 1];
        }
        var maxIndex = Array.IndexOf(fondedMax, fondedMax.Max());
        return dictionary[maxIndex];
    }

    private static void InitMatrix(int[,] matrix, string wrongWord, string expectedWord)
    {
        if (wrongWord[0] == expectedWord[0]) matrix[0, 0] = 1;
        for (var i = 1; i < wrongWord.Length; i++)
        {
            if (wrongWord[i] == expectedWord[0]) matrix[0, i] += 1;
            else matrix[0, i] = matrix[0, i - 1];
        }

        for (var i = 1; i < expectedWord.Length; i++)
        {
            if (wrongWord[0] == expectedWord[i]) matrix[i, 0] += 1;
            else matrix[i, 0] = matrix[i - 1, 0];
        }
    }
}