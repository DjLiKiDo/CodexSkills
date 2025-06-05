using Template.Infrastructure.Services;

namespace Template.Tests;

public class RandomWeatherForecastServiceTests
{
    [Fact]
    public void GetForecast_WithPositiveDays_ReturnsExpectedCount()
    {
        var service = new RandomWeatherForecastService();

        var result = service.GetForecast(3).ToArray();

        Assert.Equal(3, result.Length);
        Assert.Equal(DateOnly.FromDateTime(DateTime.Now.AddDays(1)), result[0].Date);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void GetForecast_WithNonPositiveDays_Throws(int days)
    {
        var service = new RandomWeatherForecastService();

        Assert.Throws<ArgumentOutOfRangeException>(() => service.GetForecast(days));
    }
}
