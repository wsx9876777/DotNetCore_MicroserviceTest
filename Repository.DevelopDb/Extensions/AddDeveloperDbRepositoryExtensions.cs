using Microsoft.Extensions.DependencyInjection;
using Repository.DevelopDb.Db;
using Repository.DevelopDb.Interface;
using Repository.DeveloperDb.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DevelopDb.Extensions
{
    public static class AddDeveloperDbRepositoryExtensions
    {
        public static IServiceCollection AddDeveloperDbRepository(this IServiceCollection services)
        {
            services.AddScoped<SqlConnectionDeveloperDb>();
            services.AddScoped<IGragesRepository, GradesRepository>();

            return services;
        }
    }
}
