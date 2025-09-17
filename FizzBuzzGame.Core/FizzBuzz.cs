namespace FizzBuzzGame.Core
{
    public class FizzBuzz
    {
        private readonly Dictionary<string, int> _fizzBuzzDict;

        public FizzBuzz(Dictionary<string, int> fizzBuzzDict)
        {
            if(fizzBuzzDict == null)
                throw new ArgumentNullException(nameof(fizzBuzzDict), "Rules dictionary cannot be null.");
            if(fizzBuzzDict.Values.Any(v => v == 0))
                throw new ArgumentException("Divisor values cannot be zero.", nameof(fizzBuzzDict));
            _fizzBuzzDict = fizzBuzzDict;
        }

        public string GetValue(int number)
        {
            string output = string.Concat(
                _fizzBuzzDict
                    .Where(kvp => number % kvp.Value == 0)
                    .Select(kvp => kvp.Key)
            );
            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }
    }
}