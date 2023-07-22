namespace Learn
{
    public interface WeatherService
    {
        Task<<string>> Get(string cityName);
    }
    public class WeatherService : IWeatherService
    {
        private HttpClient _httpClient;
        public WeatherService(HttpClient httpClient)

        {
            _httpClient = httpClient;
        }
        public async Task<string> Get(string cityName)
        {
         return await _weatherService.Get(cityName);
        }
    }
}