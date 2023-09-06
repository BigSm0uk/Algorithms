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
### Задача о поиске самой длиннлй общей подпоследовательности.
### Необходимо для входного слова, содержащего ошибку, "fosh" найти в словаре то слово, которое пользователь имел ввиду.
### Например, в словаре имеются слова {"fish", "fort", "vista"}, необзодимо, чтобы алгоримт вернул слово, наиболее похожее на входное слвово - "fish".
### Полное решение находится по пути: Algoritms/WordMatch
``` cs
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
```
