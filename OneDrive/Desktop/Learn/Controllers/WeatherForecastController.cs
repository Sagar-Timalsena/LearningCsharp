using Microsoft.AspNetCore.Mvc;

namespace Learn.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;
    private readonly IHttpClientFactory _httpClientFactory;



    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        _weatherService = weatherService;   
    }

    [HttpGet]
    public async Task<string> Get (string cityName)
    {
        var httpClient = _httpClientFactory.CreateClient();
        var URL = $"http://api.weatherapi.com/v1/current.json?key=334b9095319b446b81e103622232207&q={cityName}&aqi=no";
        var response = await httpClient.GetAsync(URL);
        return await response.Content.ReadAsStringAsync();
        
    }
}
