using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyAsyncActionFilter :Attribute, IAsyncActionFilter
    {
        private readonly ILogger<MyAsyncReslutFilter> _logger;

        public MyAsyncActionFilter()
        {
           
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            context.Result = new ContentResult()
            {
                Content = "{\"abc\":123}"
            };
            //await next();

        }
    }
}
