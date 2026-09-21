using Xunit;
using Assignmet7;

namespace Assignment7.Tests;

public class FineCalculatorTests
{
    private readonly FineCalculator _calculator;

    public FineCalculatorTests()
    {
        _calculator = new FineCalculator();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange 
        int a = 5;
        int b = 2;
        
        // Act 
        int result = _calculator.Add(a, b);
        
        // Assert 
        Assert.Equal(7, result);
    }
    
    [Fact]
    public void Add_ShouldReturnNotEqual()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.NotEqual(20, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 5;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(5, 4, 20)]
    [InlineData(-2, 3, -6)]
    public void Multiply_ShouldReturnCorrectResult(int a, int b, int expected)
    {
        // Arrange

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 10)]
    [InlineData(5, 4, 15)]
    [InlineData(-2, 3, 6)]
    public void Multiply_ShouldReturnNotEqual(int a, int b, int notExpected)
    {
        // Arrange

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.NotEqual(notExpected, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }
    
}
