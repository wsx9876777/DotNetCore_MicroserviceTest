using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Middleware_Software
{
    public class UseFactoryBlockIpMiddleware:IMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        public UseFactoryBlockIpMiddleware(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var a = _configuration["block:0:ip"];
            await next(context);
        }
    }
}
