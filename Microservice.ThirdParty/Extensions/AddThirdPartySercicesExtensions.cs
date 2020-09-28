using Microservice.ThirdParty.Poco;
using Microservice.ThirdParty.Provider;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.ThirdParty.Extensions
{
    public static class AddThirdPartySercicesExtensions
    {
        public static IServiceCollection AddThirdPartySercices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var obj = new ThirdPartyConfigs();
            configuration.Bind(obj);
            foreach (var x in obj.ThridPartys)
            {
                Type serviceType = Type.GetType($"ThirdParty.{x.name}.ThirdPartyCore, ThirdParty.{x.name}");
                Type implementType = Type.GetType($"ThirdParty.{x.name}.TpHelper, ThirdParty.{x.name}");
                if (serviceType == null || implementType == null)
                {
                    //write log
                }
                else
                {
                    services.AddScoped(serviceType, implementType);
                }
               
            }
            services.AddScoped(x => new ThirdPartyCollection(x));
            return services;
        }
    }
}
