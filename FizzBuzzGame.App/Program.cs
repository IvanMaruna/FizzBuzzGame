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
        RunGame(1, 100, fizzBuzzDict);

        var jazzFuzzDict = new Dictionary<string, int>
        {
            { "Jazz", 9 },
            { "Fuzz", 4 }
        };
        RunGame(100, 1, jazzFuzzDict);
    }

    static void RunGame(int start, int end, Dictionary<string, int> rules)
    {
        var fizzBuzz = new FizzBuzz(rules);

        if(start < end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(fizzBuzz.GetValue(i));
            }
        }
        else
        {
            for (int i = start; i >= end; i--)
            {
                Console.WriteLine(fizzBuzz.GetValue(i));
            }
        }
    }
}