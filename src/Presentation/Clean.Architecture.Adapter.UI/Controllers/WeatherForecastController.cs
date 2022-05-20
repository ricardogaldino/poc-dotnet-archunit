using Clean.Architecture.Core.Entities.Models;
using Clean.Architecture.Core.Interfaces.UseCases.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Architecture.Adapter.UI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] _summaries =
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherForecastUseCase _weatherForecastUseCase;

    public WeatherForecastController(IWeatherForecastUseCase weatherForecastUseCase)
    {
        _weatherForecastUseCase = weatherForecastUseCase;
    }

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summaries[Random.Shared.Next(_summaries.Length)]
            })
            .ToArray();
    }
}