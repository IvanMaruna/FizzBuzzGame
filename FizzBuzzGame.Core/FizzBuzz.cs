namespace FizzBuzzGame.Core
{
    public class FizzBuzz
    {
        private readonly Dictionary<string, int> _fizzBuzzDict;

        public FizzBuzz(Dictionary<string, int> fizzBuzzDict)
        {
            _fizzBuzzDict = fizzBuzzDict;
        }

        public string GetValue(int number)
        {
            string output = string.Empty;
            foreach (var kvp in _fizzBuzzDict)
            {
                if (number % kvp.Value == 0)
                {
                    output += kvp.Key;
                }
            }
            return string.IsNullOrEmpty(output) ? number.ToString() : output;
        }
    }
}