using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WholesaleMarketHall.Web.MediatR.Application.Queries;
using WholesaleMarketHall.Web.MediatR.Domain.ProductAggregate;
using WholesaleMarketHall.Web.UnitOfWork;

namespace WholesaleMarketHall.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IMediator _mediator;
        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;



        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            return Ok(await _mediator.Send(new GetProductsByNameQuery
            {
                Name = name
            }));
        }
    }
}