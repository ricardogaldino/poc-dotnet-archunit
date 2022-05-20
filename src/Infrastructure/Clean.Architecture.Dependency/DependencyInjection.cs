using Clean.Architecture.Adapter.Database.Repositories;
using Clean.Architecture.Adapter.External.Services;
using Clean.Architecture.Core.Interfaces.Database.Repositories;
using Clean.Architecture.Core.Interfaces.External.Services;
using Clean.Architecture.Core.Interfaces.UseCases.Services;
using Clean.Architecture.Core.UseCases.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Architecture.Dependency;

public static class DependencyInjection
{
    public static void AddDependencyInjection(this IServiceCollection services)
    {
        //Use Case
        services.AddTransient<IWeatherForecastUseCase, WeatherForecastUseCase>();

        //Database
        services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

        //External
        services.AddTransient<IWeatherForecastExternal, WeatherForecastExternal>();
    }
}