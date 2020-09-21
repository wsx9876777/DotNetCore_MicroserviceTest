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
    public class MyResultFilter : IResultFilter
    {
        private readonly ILogger<MyResultFilter> _logger;
        private readonly IAnnouncementProvider _announcementProvider;
        private readonly Position _position;
        private long aa = DateTime.Now.Ticks;

        public MyResultFilter(
            ILogger<MyResultFilter> logger,
            IOptions<Position> options,
            IAnnouncementProvider announcementProvider)
        {
            this._logger = logger;
            this._announcementProvider = announcementProvider;
            this._position = options.Value;
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "OnResultExecuting"
            };
        }
    }
}
