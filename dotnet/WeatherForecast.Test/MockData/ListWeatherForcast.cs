using WeatherForecast.Contracts;

namespace WeatherForecast.Test.MockData;

public static class ListWeatherForecast
{
    public  static List<WeatherForecast> MockWeathers  =>
        [new WeatherForecast() { Date = DateOnly.Parse("08/19/2012"), TemperatureC = 7 }];
    
    public  static List<WeatherForecastResponse> MockWeathersResponse  =>
    [new WeatherForecastResponse()
    {
        Date = DateOnly.Parse("08/19/2012"), TemperatureC = 7,
        Categorization = Categorization.Cool.ToString()
    }];
}
