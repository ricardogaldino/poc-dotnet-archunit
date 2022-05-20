using Clean.Architecture.Core.Interfaces.Database.Repositories;
using Clean.Architecture.Core.Interfaces.UseCases.Services;

namespace Clean.Architecture.Core.UseCases.Services;

public class WeatherForecastUseCase : IWeatherForecastUseCase
{
    private readonly IWeatherForecastRepository _weatherForecastRepository;

    public WeatherForecastUseCase(
        IWeatherForecastRepository weatherForecastRepository
    )
    {
        _weatherForecastRepository = weatherForecastRepository;
    }
}