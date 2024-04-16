using System.Net.Http.Json;
using FluentAssertions;
using WeatherForecast.Contracts;
using WeatherForecast.Test.Fixtures;
using WeatherForecast.Test.MockData;

namespace WeatherForecast.Test;

public class WeatherForecastControllerTest : IClassFixture<ControllerIntegrationFixture>
{
    private readonly HttpClient _httpClient;

    public WeatherForecastControllerTest(ControllerIntegrationFixture fixture)
    {
        _httpClient = fixture.CreateHttpClient();
    }

    [Fact]
    public async Task Get_Should_ReturnListOfWeathers_WhenCallingMethod()
    {
        // Arrange
        
        // Act
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecastResponse>>("WeatherForecast");
        
        // Assert
        var weatherForecasts = response!.ToList();
        
        weatherForecasts.Should().BeOfType<List<WeatherForecastResponse>>();
        weatherForecasts.Should().BeEquivalentTo(ListWeatherForecast.MockWeathersResponse);
    }
}
