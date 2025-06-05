using Template.Domain.Entities;

namespace Template.Application.Abstractions;

public interface IWeatherForecastService
{
    /// <summary>
    /// Returns a collection of randomly generated weather forecasts.
    /// </summary>
    /// <param name="days">The number of days to generate forecasts for.</param>
    /// <returns>A sequence of <see cref="WeatherForecast"/> instances.</returns>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="days"/> is less than or equal to zero.
    /// </exception>
    IEnumerable<WeatherForecast> GetForecast(int days);
}
