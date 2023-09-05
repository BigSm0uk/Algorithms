namespace Algorithms.CodeWars;

/*Задача состоит в том, чтобы каждому элементу массива присвоить произведение всех оставшихся членов этого массива
 без использования оператора / с ограничением O(n)*/
public static class MultiplyArray
{
    private static void Main()
    {
        var arr = new[] { 2,3,4,5};
        Solve(arr);
        
    }
    public static int[] Solve(int[] arr)
    {
        var leftArr = new int[arr.Length];
        var rightArr = new int[arr.Length];
        leftArr[0] = 1;
        rightArr[^1] = 1;
        for (var i = 1; i < leftArr.Length; i++)
        {
            leftArr[i] = arr[i-1] * leftArr[i - 1];
        }
        for (var i = rightArr.Length -2; i >= 0; i--)
        {
            rightArr[i] = arr[i+1] * rightArr[i + 1];
        }
        for (var i = 0; i < arr.Length; i++)
        {
            arr[i] = leftArr[i] * rightArr[i];
        }
        return arr;
    }
}