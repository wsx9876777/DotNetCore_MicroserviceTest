using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdParty.Ag;

namespace Microservice.ThirdParty.Provider
{
    public class ThirdPartyCollection
    {
        private readonly IServiceProvider services;
        public ThirdPartyCollection(IServiceProvider services)
        {
            this.services = services;
        }
        public ThirdPartyCore this[string name]
        {
            get
            {
                Type implementType = Type.GetType($"ThirdParty.{name}.ThirdPartyCore, ThirdParty.{name}"); ;
                var tpService = (ThirdPartyCore)services.GetRequiredService(implementType);
                return tpService;
            }
        }

    }
}
