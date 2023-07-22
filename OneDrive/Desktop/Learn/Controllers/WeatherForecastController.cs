using Microsoft.AspNetCore.Mvc;

namespace Learn.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
  

    private readonly ILogger<WeatherForecastController> _logger;
    private static HttpClient _httpClient;
    static WeatherForecastController()
    {
        _httpClient = new HttpClient();
    }

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<string> Get (string cityName)
    {
        var URL = $"http://api.weatherapi.com/v1/current.json?key=334b9095319b446b81e103622232207&q={cityName}&aqi=no";
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(URL);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
