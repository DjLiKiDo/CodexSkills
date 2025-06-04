using Template.Domain.Entities;

namespace Template.Application.Abstractions;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetForecast(int days);
}
