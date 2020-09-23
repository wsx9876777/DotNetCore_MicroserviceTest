using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Begonia.Db;
using Repository.Begonia.Models;

namespace MicroService002.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly SqlConnectionBegonia _sqlConnectionBegonia;
        private readonly IANNOUNCEMENT_GROUPRepository _aNNOUNCEMENT_GROUPRepository;
        private readonly IANNOUNCEMENTRepository _aNNOUNCEMENTRepository;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            SqlConnectionBegonia sqlConnectionBegonia,
            IANNOUNCEMENT_GROUPRepository aNNOUNCEMENT_GROUPRepository,
            IANNOUNCEMENTRepository aNNOUNCEMENTRepository)
        {
            _logger = logger;
            _sqlConnectionBegonia = sqlConnectionBegonia;
            _aNNOUNCEMENT_GROUPRepository = aNNOUNCEMENT_GROUPRepository;
            _aNNOUNCEMENTRepository = aNNOUNCEMENTRepository;
        }

        [HttpGet]
        public IEnumerable<ANNOUNCEMENT_GROUP> Get()
        {
            IEnumerable<ANNOUNCEMENT_GROUP> data = null;

            _sqlConnectionBegonia.BegingSqlTransaction();
            data = _aNNOUNCEMENT_GROUPRepository.GetAll();
            _aNNOUNCEMENTRepository.Update(1, "7575");
            _aNNOUNCEMENTRepository.GetAll();
            _sqlConnectionBegonia.CommitTransaction();


            return data;
        }
    }
}
