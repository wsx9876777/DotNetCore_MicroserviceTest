using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.DevelopDb.Interface;

namespace Microservice.DevelopDb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGragesRepository _gragesRepository;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IGragesRepository gragesRepository)
        {
            _logger = logger;
            this._gragesRepository = gragesRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            _gragesRepository.Update(1, 1);
            return Ok();
        }
    }
}
