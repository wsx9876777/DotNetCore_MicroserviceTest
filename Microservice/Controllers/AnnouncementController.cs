using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Filter;
using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class AnnouncementController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<AnnouncementController> _logger;
        private readonly IAnnouncementProvider _announcementProvider;

        public AnnouncementController(
            ILogger<AnnouncementController> logger,
            IAnnouncementProvider announcementProvider)
        {
            _logger = logger;
            this._announcementProvider = announcementProvider;
        }

        [HttpGet]
        
        [ServiceFilter(typeof(MyActionFilterAttribute))]
        public async Task<IEnumerable<Announcement>> Get(string abc)
        {
            _logger.LogInformation("你好嗎");
            var list = await _announcementProvider.GetList();

            return list;
        }
    }
}
