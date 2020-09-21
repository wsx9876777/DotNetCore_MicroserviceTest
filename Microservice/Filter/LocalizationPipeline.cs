using Microservice.Middleware_Software;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class LocalizationPipeline
    {
        public void Configure(IApplicationBuilder applicationBuilder)
        {
            
            applicationBuilder.UseMiddleware<UseFactoryBlockIpMiddleware>();
        }
    }
}
