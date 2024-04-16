namespace WeatherForecast.Contracts;

public class WeatherForecastResponse
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }
    public string Categorization { get; set; } = string.Empty;
}