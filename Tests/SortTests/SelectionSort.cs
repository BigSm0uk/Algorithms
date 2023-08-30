using Algorithms.Sort;

namespace Tests.SortTests;

public class SelectionSort
{
    [Fact]
    private void ShouldReturnSuccess()
    {
        //Arrange
        var expected = new[] {45,45,45,45,21,21,21,21,12,12,12,12,12,12,12,12,6,6,6,6,5,5,5,5,5,5,5,5,3,3,3,3,3,3,3,3,3,3,3,3,1,1,1,1};
        var actual = new[] { 1, 5, 3, 21, 3, 45, 12, 3, 5, 6, 12, 1, 5, 3, 21, 3, 45, 12, 3, 5, 6, 12, 1, 5, 3, 21, 3, 45, 12, 3, 5, 6, 12, 1, 5, 3, 21, 3, 45, 12, 3, 5, 6, 12 };
        //Act
        Selection.SelectionSort(actual, Comparer<int>.Default);
        //Assert
        Assert.Equal(expected, actual);
    }
}