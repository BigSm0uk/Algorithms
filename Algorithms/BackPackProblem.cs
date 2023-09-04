using System.Security.Cryptography.X509Certificates;

namespace Algorithms;

public static class BackPackProblem
{
    private readonly struct Item
    {
        public Item(string label, int cost, int weight)
        {
            Label = label;
            Cost = cost;
            Weight = weight;
        }

        public int Cost { get; }
        public string Label { get; }
        public int Weight { get; }
    }

    public static void Main()
    {
        var items = new[]
        {
            new Item("Магнитофон", 3000, 4),
           new Item("Iphone", 2000, 1),
            new Item("Ноутбук", 2000, 3),
            new Item("Гитара", 1500, 1),
        };
        const int backPackWeight = 4;
        Solve(items, backPackWeight);
    }
    
    private static void Solve(IReadOnlyList<Item> items, int backPackWeight)
    {
        var maxWeightMatrix = new int[items.Count ,backPackWeight];
        for (var i = items[0].Weight-1; i < backPackWeight; i++)
        {
            maxWeightMatrix[0,i] = items[0].Cost;//Заполняем первую стркоу матрицы стоимостей
        }
        for (var i = 1; i < items.Count; i++)
        {
            for (var j = 0; j < backPackWeight; j++)
            {
                if (items[i].Weight - 1 > j)
                {
                    maxWeightMatrix[i, j] = maxWeightMatrix[i - 1, j]; continue;
                }
                if (items[i].Weight-1 == j)
                {
                    maxWeightMatrix[i, j] = Math.Max(maxWeightMatrix[i - 1, j], items[i].Cost);continue;
                }
                
                maxWeightMatrix[i, j] = Math.Max(maxWeightMatrix[i - 1, j],
                    items[i].Cost + maxWeightMatrix[i - 1, j - items[i].Weight]);

            }
        }
        Console.WriteLine($"Total cost = {maxWeightMatrix[items.Count-1, backPackWeight-1]}");
    }
    
}