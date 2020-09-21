using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyActionFilter : IActionFilter
    {
        private readonly ILogger<MyActionFilter> _logger;
        private readonly IAnnouncementProvider _announcementProvider;
        private readonly Position _position;
        private long aa = DateTime.Now.Ticks;

        public MyActionFilter(
            string aaa)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "OnActionExecuting"
            };

        }
    }
}
