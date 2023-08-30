namespace Algorithms;

public static class Search
{
    public static int BinarySearch<T>(IReadOnlyList<T> enumerable, T value, Comparer<T> comparer)
    {
        var high = enumerable.Count - 1;
        var low = 0;
        while (high >= low)
        {
            var mid = (high + low) / 2;
            var compareResult = comparer.Compare(enumerable[mid], value);
            switch (compareResult)
            {
                case 0:
                    return mid;
                case > 0:
                    high = mid - 1;
                    break;
                default:
                    low = mid + 1;
                    break;
            }
        }
        return -1;
    }

    public static int BinaryRecursiveSearch<T>(IReadOnlyList<T> enumerable, T value, Comparer<T> comparer)
    {
        return BinarySearch(enumerable, value, 0, enumerable.Count - 1, comparer);
    }

    private static int BinarySearch<T>(IReadOnlyList<T> array, T value, int low, int high, IComparer<T> comparer)
    {
        if (high < low) return -1;
        var mid = (low + high) / 2;
        var compareResult = comparer.Compare(array[mid], value);
        return compareResult switch
        {
            0 => mid,
            > 0 => BinarySearch(array, value, low, mid - 1, comparer),
            < 0 => BinarySearch(array, value, mid + 1, high, comparer)
        };
    }
}