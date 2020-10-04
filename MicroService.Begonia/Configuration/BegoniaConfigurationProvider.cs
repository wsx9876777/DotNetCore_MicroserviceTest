using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Repository.Db;
using System.Collections.Immutable;
using Repository.Models.Begonia;

namespace MicroService.Begonia.Configuration
{
    public class BegoniaConfigurationProvider : ConfigurationProvider
    {
        private ConfigurationReloadToken _reloadToken = new ConfigurationReloadToken();
        public override void Load()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            var conn = new SqlConnectionDeveloperDb(config);
            var repository = new ConfigurationRepository(conn);
            var data = repository.GetBegoniaConfigurations();
            var prefix = "BegoniaConfig";
            foreach (var item in data)
            {
                base.Data.Add($"{prefix}{item.key}", item.value);
            }
        }
     
    }
}
