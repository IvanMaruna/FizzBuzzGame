namespace FizzBuzzGame.Core;

public class FizzBuzz(List<(string Word, int Divisor)> rules)
{
    public string Play(int number)
    {
        string gameResult = string.Concat(
            rules
                .Where(rule => number % rule.Divisor == 0)
                .Select(rule => rule.Word)
                .DefaultIfEmpty(number.ToString())
        );
        return gameResult;
    }
}