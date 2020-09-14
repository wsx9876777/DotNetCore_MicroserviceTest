using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IEnumerable<Announcement>> Get()
        {
            var list = await _announcementProvider.GetList();

            return list;
        }
    }
}
