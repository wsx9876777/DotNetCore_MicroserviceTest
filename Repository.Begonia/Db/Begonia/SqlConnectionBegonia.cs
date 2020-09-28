using Microsoft.Extensions.Configuration;
using Repository.Begonia.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Db
{
    public class SqlConnectionBegonia: SqlConnectionBase
    {
        public SqlConnectionBegonia(IConfiguration configuration)
            :base(configuration.GetConnectionString("begonia"))
        {
        }
    }
}
