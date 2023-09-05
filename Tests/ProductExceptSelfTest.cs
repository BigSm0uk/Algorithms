using Algorithms.CodeWars;

namespace Tests;

public class ProductExceptSelfTest
{
    [Fact]
    public void ShouldReturnSuccess()
    {
        //Arrange
        var arr = new[] { 2, 3, 4, 5 };
        var expected = new[] { 60, 40, 30, 24 };
        //Act
        var actual = ProductExceptSelf.Solve(arr);
        //Assert
        Assert.Equivalent(expected, actual);
    }
}