using FizzBuzzGame.Core;

namespace FizzBuzzGame.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void ReturnsFizzForMultiplesOf3()
    {
        var rules = new Dictionary<string, int> { { "Fizz", 3 }, { "Buzz", 5 } };
        var fizzBuzz = new FizzBuzz(rules);
        Assert.Equal("Fizz", fizzBuzz.GetValue(3));
    }

    [Fact]
    public void ReturnsBuzzForMultiplesOf5()
    {
        var rules = new Dictionary<string, int> { { "Fizz", 3 }, { "Buzz", 5 } };
        var fizzBuzz = new FizzBuzz(rules);
        Assert.Equal("Buzz", fizzBuzz.GetValue(5));
    }

    [Fact]
    public void ReturnsFizzBuzzForMultiplesOf3And5()
    {
        var rules = new Dictionary<string, int> { { "Fizz", 3 }, { "Buzz", 5 } };
        var fizzBuzz = new FizzBuzz(rules);
        Assert.Equal("FizzBuzz", fizzBuzz.GetValue(15));
    }

    [Fact]
    public void ReturnsNumberForNonMultiples()
    {
        var rules = new Dictionary<string, int> { { "Fizz", 3 }, { "Buzz", 5 } };
        var fizzBuzz = new FizzBuzz(rules);
        Assert.Equal("2", fizzBuzz.GetValue(2));
    }
}
