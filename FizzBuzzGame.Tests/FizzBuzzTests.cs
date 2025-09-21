using FizzBuzzGame.Core;

namespace FizzBuzzGame.Tests;

public class FizzBuzzTests
{
    private static readonly List<(string, int)> RulesSet1 = [("Fizz", 3), ("Buzz", 5)];

    public static IEnumerable<object[]> TestCases =>
    new List<object[]>
    {
            new object[] { 2, RulesSet1, "2" },
            new object[] { 3, RulesSet1, "Fizz" },
            new object[] { 5, RulesSet1, "Buzz" },
            new object[] { 15, RulesSet1, "FizzBuzz" }
    };

    [Theory]
    [MemberData(nameof(TestCases))]
    public void Play_InputMatchingRules_ReturnsExpectedResult(int input, List<(string, int)> rules, string expectedResult)
    {
        var fizzBuzz = new FizzBuzz(rules);

        var result = fizzBuzz.Play(input);

        Assert.Equal(expectedResult, result);
    }
}