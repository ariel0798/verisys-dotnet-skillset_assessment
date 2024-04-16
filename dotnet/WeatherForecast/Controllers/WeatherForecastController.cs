using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using WeatherForecast.Contracts;
using WeatherForecast.Extension;
using WeatherForecast.Interfaces;

namespace WeatherForecast.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecastResponse>> Get()
    {
        var result = await _weatherService.GetForecast();
        return result.ToWeatherForecastResponse();
    }
}
