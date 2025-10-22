using FizzBuzzGame.Core;

RunGame([("Fizz", 3), ("Buzz", 5)], Enumerable.Range(1, 100));
RunGame([("Jazz", 9), ("Fuzz", 4)], Enumerable.Range(1, 100).Reverse());

static void RunGame(List<(string Word, int Divisor)> rules, IEnumerable<int> range)
{
    var fizzBuzz = new FizzBuzz(rules);

    foreach (var number in range)
    {
        Console.WriteLine(fizzBuzz.Play(number));
    }
}