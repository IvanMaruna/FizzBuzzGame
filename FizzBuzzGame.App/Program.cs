using FizzBuzzGame.Core;

var rules = new List<(string Word, int Divisor)> { ("Fizz", 3), ("Buzz", 5) };

var fizzBuzz = new FizzBuzz(rules);

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzz.Play(i));
}