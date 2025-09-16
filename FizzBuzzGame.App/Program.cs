using FizzBuzzGame.Core;

class Program
{
    static void Main(string[] args)
    {
        var fizzBuzzDict = new Dictionary<string, int>
        {
            { "Fizz", 3 },
            { "Buzz", 5 }
        };

        var fizzBuzz = new FizzBuzz(fizzBuzzDict);

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.GetValue(i));
        }
    }
}