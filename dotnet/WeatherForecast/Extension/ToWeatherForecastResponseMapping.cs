using System.Diagnostics;
using WeatherForecast.Contracts;

namespace WeatherForecast.Extension;

public static class ToWeatherForecastResponseMapping
{
    public static IEnumerable<WeatherForecastResponse> ToWeatherForecastResponse(
        this IEnumerable<WeatherForecast> listOfWeathers)
    {
        return listOfWeathers.Select(GetWeatherForecastResponse);
    }

    private static WeatherForecastResponse GetWeatherForecastResponse(WeatherForecast weatherForecast)
    {
        Categorization categorization;

        if (weatherForecast.TemperatureC <= 0)
            categorization = Categorization.Cold;
        else if (weatherForecast.TemperatureC is > 0 and <= 15)
            categorization = Categorization.Cool;
        else if (weatherForecast.TemperatureC is > 15 and <= 20)
            categorization = Categorization.Warm;
        else
            categorization = Categorization.Hot;

        return new WeatherForecastResponse
        {
            Date = weatherForecast.Date,
            TemperatureC = weatherForecast.TemperatureC,
            Categorization = categorization.ToString()
        };
    }
}