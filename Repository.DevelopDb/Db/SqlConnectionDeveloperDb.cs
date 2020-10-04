using Microsoft.Extensions.Configuration;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.DevelopDb.Db
{
    public class SqlConnectionDeveloperDb : SqlConnectionBase
    {
        public SqlConnectionDeveloperDb(IConfiguration configuration)
            :base(configuration.GetConnectionString("DeveloperDb"))
        {
        }
    }
}
