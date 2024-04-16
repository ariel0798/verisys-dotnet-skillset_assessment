using WeatherForecast.Interfaces;

namespace WeatherForecast.Implementation;

public class WeatherService : IWeatherService
{
    public Task<IEnumerable<WeatherForecast>> GetForecast()
    {
        return Task.FromResult<IEnumerable<WeatherForecast>>(new List<WeatherForecast>());
    }
}