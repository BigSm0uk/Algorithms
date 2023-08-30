using Algorithms;

namespace Tests;

public class BinarySearchTests
{
    [Fact]
    public void ShouldReturnSuccess()
    {
        // Arrange
        var enumerable = Enumerable.Range(0,10001).ToArray();
        var random = new Random().Next(10000);
        // Act
        var result = Search.BinarySearch(enumerable, random, Comparer<int>.Default);
        var resultRecurs = Search.BinaryRecursiveSearch(enumerable, random, Comparer<int>.Default);
        // Assert
        Assert.Equal(random, result);
        Assert.Equal(random, resultRecurs);
    }
}