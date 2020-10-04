using Microsoft.Extensions.Configuration;
using Repository.Base;
using Repository.Begonia.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Begonia.Db
{
    public class SqlConnectionBegonia : SqlConnectionBase
    {
        public SqlConnectionBegonia(IConfiguration configuration)
            :base(configuration.GetConnectionString("begonia"))
        {
        }
    }
}
