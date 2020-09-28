
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Microservice.ThirdParty.Filter
{
    public class MyActionFilterAttribute:ActionFilterAttribute
    {
        private readonly ILogger<MyActionFilterAttribute> _logger;
      
        private long aa = DateTime.Now.Ticks;

        public MyActionFilterAttribute(
            ILogger<MyActionFilterAttribute> logger)
        {
            this._logger = logger;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
       

            base.OnActionExecuting(context);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var a = 123;
            base.OnResultExecuting(context);
        }

    }
}
