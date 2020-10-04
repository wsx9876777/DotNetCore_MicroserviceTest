using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Begonia.Db;
using Repository.Begonia.Interface;
using Repository.Begonia.Models;
using Repository.Db;

namespace MicroService.Begonia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly SqlConnectionDeveloperDb _sqlConnectionBegonia;
        private readonly IANNOUNCEMENT_GROUPRepository _aNNOUNCEMENT_GROUPRepository;
        private readonly IANNOUNCEMENTRepository _aNNOUNCEMENTRepository;

        public WeatherForecastController(
            IConfiguration configuration,
            ILogger<WeatherForecastController> logger,
            SqlConnectionDeveloperDb sqlConnectionBegonia,
            IANNOUNCEMENT_GROUPRepository aNNOUNCEMENT_GROUPRepository,
            IANNOUNCEMENTRepository aNNOUNCEMENTRepository)
        {
            _configuration = configuration;
            _logger = logger;
            _sqlConnectionBegonia = sqlConnectionBegonia;
            _aNNOUNCEMENT_GROUPRepository = aNNOUNCEMENT_GROUPRepository;
            _aNNOUNCEMENTRepository = aNNOUNCEMENTRepository;
        }

        [HttpGet]
        public IEnumerable<ANNOUNCEMENT> Get()
        {
            IEnumerable<ANNOUNCEMENT> data = null;
            IEnumerable<ANNOUNCEMENT_GROUP> data2 = null;


            //_sqlConnectionBegonia.BegingSqlTransaction();
            //data2 = _aNNOUNCEMENT_GROUPRepository.GetAll();
            //var data3 = _aNNOUNCEMENTRepository.GetAll();
            Task.Run(() =>
            {
                _aNNOUNCEMENTRepository.Update(1, "123");

            });
            //var a = data3.GetHashCode();
            //_aNNOUNCEMENTRepository.Update(1, DateTime.Now.Millisecond.ToString());
            // data3 = _aNNOUNCEMENTRepository.GetAll();
            //var aa = data3.GetHashCode();
            //_sqlConnectionBegonia.Commit();

            data = _aNNOUNCEMENTRepository.GetAll();
            
            return data;
        }
        [HttpGet("Tommy")]
        public IActionResult GetTommy()
        {
            var a = _configuration.AsEnumerable();
            return Ok(a);
        }
    }
}
