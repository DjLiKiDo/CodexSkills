using Template.Application.Abstractions;
using Template.Domain.Entities;

namespace Template.Infrastructure.Services;

public class RandomWeatherForecastService : IWeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GetForecast(int days)
    {
        if (days <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(days), "Days must be greater than zero.");
        }

        return Enumerable.Range(1, days).Select(index =>
            new WeatherForecast(
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Random.Shared.Next(-20, 55),
                Summaries[Random.Shared.Next(Summaries.Length)]
            ));
    }
}
