using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using WeatherForecast.Interfaces;
using WeatherForecast.Test.MockData;

namespace WeatherForecast.Test.Fixtures;

public class ControllerIntegrationFixture
{
    private readonly WebApplicationFactory<Program> _application;

    public ControllerIntegrationFixture()
    {
        
        _application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder => { builder.ConfigureTestServices(services =>
            {
                var weatherService = Substitute.For<IWeatherService>();
                weatherService.GetForecast().Returns(ListWeatherForecast.MockWeathers);
                
                services.AddScoped<IWeatherService>(x => weatherService);
            }); });

       
    }

    public HttpClient CreateHttpClient()
    {
        return _application.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
    }
}
