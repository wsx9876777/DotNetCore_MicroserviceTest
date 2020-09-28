using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.ThirdParty.Middleware_Software
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

            byte[] data = Encoding.UTF8.GetBytes("你好嗎");
            await context.Response.Body.WriteAsync(data,0,data.Length);
            //await next(context);
        }
    }
}
