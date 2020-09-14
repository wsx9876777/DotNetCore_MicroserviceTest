using Microservice.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Provider
{
    public class ConnectionFectory: IConnectionFectory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFectory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection DbCoonection(string name)
        {
            var connStr = _configuration.GetConnectionString(name);
            var conn = new SqlConnection(connStr);
            return conn;
        } 
    }
}
