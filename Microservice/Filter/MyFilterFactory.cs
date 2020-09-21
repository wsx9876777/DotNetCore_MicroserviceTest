using Microservice.Interface;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Microservice.Filter
{
    public class MyFilterFactory : Attribute, IFilterFactory
    {
        private readonly string _name;

        public bool IsReusable => true;
        public MyFilterFactory(string name)
        {
            this._name = name;
        }
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var logger = serviceProvider.GetRequiredService<ILogger<MyActionFilter>>();
            var options = serviceProvider.GetRequiredService<IOptions<Position>>();
            var announcementProvider = serviceProvider.GetRequiredService<IAnnouncementProvider>();
            var args = new object[]{ logger, options, announcementProvider };
            var type = typeof(MyActionFilter);


            IFilterMetadata filterMetadata = Activator.CreateInstance(type, args) as IFilterMetadata;

            return filterMetadata;
        }
    }
}
