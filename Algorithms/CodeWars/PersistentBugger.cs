namespace Algorithms.CodeWars;

public static class PersistentBugger
{
    public static void Main()
    {
        Console.Write(Persistence(25));
        ;
    }

    public static int Persistence(long n)
    {
        var iteration = 0;
        while (n >= 10)
        {
            n = n.ToString().Select(val => int.Parse(val.ToString())).Aggregate((mult, e) => mult * e);
            iteration++;
        }

        return iteration;
    }

    private static IEnumerable<TResult> Select<TSource, TResult>(
        this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            yield return selector.Invoke(enumerator.Current);
        }
    }

    private static int Aggregate<TSource>(
        this IEnumerable<TSource> source,
        Func<int, TSource, int> func)
    {
        var multiply = 1;
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            multiply = func.Invoke(multiply, enumerator.Current);
        }
        return multiply;
    }
}