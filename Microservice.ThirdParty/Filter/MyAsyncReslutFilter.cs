using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyAsyncReslutFilter : Attribute,IAsyncResultFilter
    {
        private readonly ILogger<MyAsyncReslutFilter> _logger;

        public MyAsyncReslutFilter()
        {
    
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var a = 123;
            await next();
        }
    }
}
