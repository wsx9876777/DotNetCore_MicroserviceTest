using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.ThirdParty.Poco
{
    public class ThirdPartyConfigs
    {
        public IEnumerable<ThirdPartyConfig> ThridPartys { get; set; }
    }
    public class ThirdPartyConfig
    {
        public string name { get; set; }
        public int code { get; set; }
    }
}
