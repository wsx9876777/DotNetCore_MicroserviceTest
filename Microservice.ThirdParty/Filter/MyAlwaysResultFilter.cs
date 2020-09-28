using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyAlwaysResultFilter : Attribute, IAlwaysRunResultFilter
    {
        
        public void OnResultExecuted(ResultExecutedContext context)
        {
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.Result = new ContentResult()
            {
                Content = $"{this.ToString()} OnActionExecuting"
            };
        }
    }
}
