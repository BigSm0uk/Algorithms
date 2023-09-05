using Algorithms.CodeWars;

namespace Tests;

public class MultiplyArrayTest
{
    [Fact]
    public void ShouldReturnSuccess()
    {
        //Arrange
        var arr = new[] { 2, 3, 4, 5 };
        var expected = new[] { 60, 40, 30, 24 };
        //Act
        var actual = MultiplyArray.Solve(arr);
        //Assert
        Assert.Equivalent(expected, actual);
    }
}