using FizzBuzzGame.Core;
using FizzBuzzGame.Core.Models;
using FizzBuzzGame.Core.Services;
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string staticUrl = "https://epinova-fizzbuzz.azurewebsites.net/api/static-rules";
        string dynamicUrl = "https://epinova-fizzbuzz.azurewebsites.net/api/dynamic-rules";
        string apiUrl = staticUrl;

        if (args.Length > 0 && args[0].Equals("dynamic"))
        {
            apiUrl = dynamicUrl;
        }

        ApiService apiService = new ApiService(new HttpClient());
        string json = apiService.GetDataAsync(apiUrl).Result;

        List<ApiResponse> rulesList = new List<ApiResponse>();
        try
        {
            rulesList = JsonSerializer.Deserialize<List<ApiResponse>>(json);
            if (rulesList == null || rulesList.Count == 0)
                throw new Exception("No rules found in API response.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine("Failed to parse rules: " + ex.Message);
            return;
        }

        Console.WriteLine("Game rules:");
        foreach (var rule in rulesList)
        {
            Console.WriteLine($"{rule.Word}: {rule.Number}");
        }
        Console.WriteLine();

        Dictionary<string, int> rules = rulesList.ToDictionary(r => r.Word, r => r.Number);
        RunGame(1, 100, rules);
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