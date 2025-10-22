using FizzBuzzGame.Core;

namespace FizzBuzzGame.Tests;

public class FizzBuzzTests
{
    private static readonly List<(string, int)> RulesSet1 = [("Fizz", 3), ("Buzz", 5)];
    private static readonly List<(string, int)> RulesSet2 = [("Jazz", 9), ("Fuzz", 4)];

    public static IEnumerable<object[]> TestCases =>
    new List<object[]>
    {
            new object[] { 2, RulesSet1, "2" },
            new object[] { 3, RulesSet1, "Fizz" },
            new object[] { 5, RulesSet1, "Buzz" },
            new object[] { 15, RulesSet1, "FizzBuzz" },

            new object[] { 9, RulesSet2, "Jazz" },
            new object[] { 4, RulesSet2, "Fuzz" },
            new object[] { 36, RulesSet2, "JazzFuzz" }
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