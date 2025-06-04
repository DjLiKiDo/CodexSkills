using Microsoft.AspNetCore.Mvc;
using Template.Application.Abstractions;
using Template.Domain.Entities;

namespace Template.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecastService _service;

    public WeatherForecastController(IWeatherForecastService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return _service.GetForecast(5);
    }
}
