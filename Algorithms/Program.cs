using Algorithms;

var start = DateTime.Now;
var enumerable = Enumerable.Range(0,10001).ToArray();
Console.WriteLine(Search.BinaryRecursiveSearch(enumerable, new Random().Next(10000), Comparer<int>.Default));
Console.WriteLine(Search.BinarySearch(enumerable, new Random().Next(10000), Comparer<int>.Default));
Console.Write($"Congratulated in {(DateTime.Now - start).TotalMilliseconds}ms");
