namespace MathService.Tests;

public class FactorialTests
{
    [Fact]
    public void Factorial_BaseValue_0()
    {
        Assert.Equal(1, FactorialService.GetFactorialOf(0));
    }

    [Fact]
    public void Factorial_BaseValue_1()
    {
        Assert.Equal(1, FactorialService.GetFactorialOf(1));
    }

    [Fact]
    public void Factorial_Of_Positive_Num()
    {
        Assert.Equal(2, FactorialService.GetFactorialOf(2));
    }

    [Fact]
    public void Factorial_Of_Negative_Num()
    {
        Assert.Throws<ArgumentException>(() => FactorialService.GetFactorialOf(-1));
    }


}