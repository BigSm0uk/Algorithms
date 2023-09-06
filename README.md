# Привет, я [Денис](https://t.me/BigSm0ukRU) ![](https://github.com/blackcater/blackcater/raw/main/images/Hi.gif) 
### Студент НИУ МГСУ, 4 курс, тут буду выкладывать решения разного рода задачек на ЯП C#
[![codewars](https://www.codewars.com/users/BigSm0uk/badges/large)](https://www.codewars.com/users/BigSm0uk)
[![GitHub Streak](https://github-readme-streak-stats.herokuapp.com/?user=DenverCoder1)](https://git.io/streak-stats)
____
### Задача с литкода:https://leetcode.com/problems/product-of-array-except-self/
#### Задача состоит в том, чтобы каждому элементу массива присвоить произведение всех оставшихся членов этого массива без использования оператора "/" с ограничением O(n)
```
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
```
#### Для массива { 1, 2, 3, 4, 5 } ответ будет таким : 120, 60, 40, 30, 24
____
