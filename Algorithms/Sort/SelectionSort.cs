namespace Algorithms.Sort;

public static class Selection
{
    public static void SelectionSort<T>(T[] array, Comparer<T> comparer)
    {
        for (var i = 0; i < array.Length-1; i++)
        {
            var minIndex = i;
            for (var j = i+1; j < array.Length; j++)
            {
                if (comparer.Compare(array[minIndex],array[j] ) < 0)
                {
                    minIndex = j;
                }
            }
            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }
    }
}