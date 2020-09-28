using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.ThirdParty.Filter;
using Microservice.ThirdParty.Poco;
using Microservice.ThirdParty.Provider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using ThirdParty.Ag;

namespace Microservice.ThirdParty.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ThirdPartyController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly ThirdPartyCollection _thirdPartyCollection;
        private readonly ILogger<ThirdPartyController> _logger;
        public ThirdPartyController(
            ThirdPartyCollection thirdPartyCollection,
            ILogger<ThirdPartyController> logger)
        {
            _thirdPartyCollection = thirdPartyCollection;
            _logger = logger;
        }

        [HttpGet]
        
        //[ServiceFilter(typeof(MyActionFilterAttribute))]
        public async Task<IActionResult> Get(TpInfo tpInfo)
        {
            ThirdPartyCore serive = _thirdPartyCollection[tpInfo.TpType];
            return Ok(serive.tset());
        }
        [HttpPost]

        //[ServiceFilter(typeof(MyActionFilterAttribute))]
        public async Task<IActionResult> GotoGame(TpInfo tpInfo)
        {
            ThirdPartyCore serive = _thirdPartyCollection[tpInfo.TpType];
            return Ok(serive.tset());
        }
    }
}
