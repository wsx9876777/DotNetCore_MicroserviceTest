using MicroService.Begonia.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService.Begonia.Extensions
{
    public static class AddBegoniaConfigExtensions
    {
        public static IConfigurationBuilder AddBegoniaConfig(this IConfigurationBuilder builder)
        {
            return builder.Add(new BegoniaConfigSource());
        }
    }
}
