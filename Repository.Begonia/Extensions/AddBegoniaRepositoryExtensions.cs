using Microsoft.Extensions.DependencyInjection;
using Repository.Begonia.Db;
using Repository.Begonia.Interface;
using Repository.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Extensions
{
    public static class AddBegoniaRepositoryExtensions
    {
        public static IServiceCollection AddBegoniaRepository(this IServiceCollection services)
        {
            services.AddScoped<SqlConnectionBegonia>();
            services.AddScoped<IANNOUNCEMENT_GROUPRepository, ANNOUNCEMENT_GROUPRepository>();
            services.AddScoped<IANNOUNCEMENTRepository, ANNOUNCEMENTRepository>();
            return services;
        }
    }
}
