namespace FizzBuzzGame.Core;

public class FizzBuzz(List<(string Word, int Divisor)> rules)
{
    private readonly List<(string Word, int Divisor)> _rules = rules;

    public string Play(int number)
    {
        string gameResult = string.Concat(
            _rules
                .Where(rule => number % rule.Divisor == 0)
                .Select(rule => rule.Word)
                .DefaultIfEmpty(number.ToString())
        );
        return gameResult;
    }
}