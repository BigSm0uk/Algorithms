using Algorithms.Sort;

var actual = new int[1000];
actual = RandomizeWithOrderByAndRandom(actual);
var actual2 = new int[1000];
actual2 = RandomizeWithOrderByAndRandom(actual2);
var start2 = DateTime.Now;
Selection.SelectionSort(actual2, Comparer<int>.Default);
Console.WriteLine($"Congratulated in {(DateTime.Now - start2).TotalMilliseconds}ms");
Console.WriteLine(string.Join(", ", actual2));

var start = DateTime.Now;
Quick.QuickSort(actual);
Console.WriteLine($"Congratulated in {(DateTime.Now - start).TotalMilliseconds}ms");
Console.WriteLine(string.Join(", ", actual));

static int[] RandomizeWithOrderByAndRandom(int[] array) =>
    array.Select(_ => Random.Shared.Next(array.Length-1)).ToArray();