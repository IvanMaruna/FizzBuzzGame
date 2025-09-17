namespace FizzBuzzGame.Core.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDataAsync(string endpoint)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(endpoint);
                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error fetching data from API.", ex);
            }
            catch (TaskCanceledException ex)
            {
                throw new Exception("API request timed out.", ex);
            }
        }
    }
}
