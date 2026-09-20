using Demo_02;

namespace Demo_02.Tests;

public class ArithmeticsTests
{
    [Theory]
    [InlineData(2, 5, 5)]
    [InlineData(9, 3, 9)]
    [InlineData(-4, -2, -2)]
    public void Max_ReturnsGreaterNumber(int firstNumber, int secondNumber, int expected)
    {
        int actual = Arithmetics.Max(firstNumber, secondNumber);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-2, 3, 1)]
    [InlineData(-2, -3, -5)]
    public void Add_WithTwoIntegers_ReturnsSum(int firstNumber, int secondNumber, int expected)
    {
        int actual = Arithmetics.Add(firstNumber, secondNumber);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2.5, 3.2, 5.7)]
    [InlineData(-2.5, 3.0, 0.5)]
    public void AddWithTwoDoublesReturnsSum(double firstNumber, double secondNumber, double expected)
    {
        double actual = Arithmetics.Add(firstNumber, secondNumber);

        Assert.Equal(expected, actual, 10);
    }

    [Fact]
    public void Add_WithIntegerAndDouble_ReturnsSum()
    {
        double actual = Arithmetics.Add(2, 3.5);

        Assert.Equal(5.5, actual, 10);
    }

    [Fact]
    public void Add_WithDoubleAndInteger_ReturnsSum()
    {
        double actual = Arithmetics.Add(2.5, 3);

        Assert.Equal(5.5, actual, 10);
    }

    [Fact]
    public void Add_WithThreeIntegers_ReturnsSum()
    {
        double actual = Arithmetics.Add(2, 3, 4);

        Assert.Equal(9, actual);
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(-3, 4, -12)]
    [InlineData(0, 4, 0)]
    public void Multiply_ReturnsProduct(int firstNumber, int secondNumber, int expected)
    {
        int actual = Arithmetics.Multiply(firstNumber, secondNumber);

        Assert.Equal(expected, actual);
    }
}
