namespace Algorithms.Sort;

public static class Quick
{
    public static void QuickGenericSort<T>(T[] array, Comparer<T> comparer) where T : IComparable
    {
        QuickGenericSort(array, 0, array.Length - 1, comparer);
    }

    private static void QuickGenericSort<T>(T[] array, int startIndex, int endIndex, Comparer<T> comparer) where T : IComparable
    {
        if(startIndex >= endIndex) return;
        var pivot = FindGenericPivot(array, startIndex, endIndex, comparer);
        QuickGenericSort(array, 0, pivot -1, comparer);
        QuickGenericSort(array, pivot+1, endIndex, comparer);
    }

    private static int FindGenericPivot<T>(T[] array, int startIndex, int endIndex, Comparer<T> comparer) where T : IComparable
    {
        var pivot = startIndex - 1;
        for (var i = startIndex; i < endIndex; i++)
        {
            if (comparer.Compare(array[i], array[endIndex]) >= 0) continue;
            pivot++;
            (array[i], array[pivot]) = (array[pivot], array[i]);
        }
        pivot++;
        (array[pivot], array[endIndex]) = (array[endIndex], array[pivot]);
        return pivot;
    }
    
    
    private static int FindPivot(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] >= array[maxIndex]) continue;
            pivot++;
            (array[i], array[pivot]) = (array[pivot], array[i]);
        }

        pivot++;
        (array[maxIndex], array[pivot]) = (array[pivot], array[maxIndex]);
        return pivot;
    }

    private static void QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex) return;
        var pivot = FindPivot(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivot - 1);
        QuickSort(array, pivot + 1, maxIndex);
    }

    public static void QuickSort(int[] array)
    {
        QuickSort(array, 0, array.Length - 1);
    }
}