using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class AddHeaderAttribute:ResultFilterAttribute
    {
        private readonly string _author;
        private readonly string _value;

        public AddHeaderAttribute(string author,string value)
        {
            this._author = author;
            this._value = value;
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            //context.HttpContext.Response.Headers.Add(_author, _value);
            //base.OnResultExecuting(context);
        }
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            await next();
        }
    }
}
