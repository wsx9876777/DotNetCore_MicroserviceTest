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
        private long aa = DateTime.Now.Ticks;

        public MyResultFilter(
            ILogger<MyResultFilter> logger)
        {
            this._logger = logger;
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
