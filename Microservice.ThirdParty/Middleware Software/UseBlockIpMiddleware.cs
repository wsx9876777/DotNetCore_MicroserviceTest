using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.ThirdParty.Middleware_Software
{
    public class UseBlockIpMiddleware
    {
        private readonly RequestDelegate _next;

        public UseBlockIpMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var a = 321;
            await _next.Invoke(context);
        }
    }
}
