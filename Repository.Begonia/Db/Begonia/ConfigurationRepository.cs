using Dapper;
using Repository.Interface.Begonia;
using Repository.Models.Begonia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Db
{
    public class ConfigurationRepository : IConfigurationRepository
    {
        private readonly SqlConnection _sqlConnection;
        private readonly SqlTransaction _sqlTransaction;
        public ConfigurationRepository(SqlConnectionBegonia sqlConnectionBegonia)
        {
            _sqlConnection = sqlConnectionBegonia.SqlConnection;
            _sqlTransaction = sqlConnectionBegonia.SqlTransaction;
        }
        public IEnumerable<BegoniaConfiguration> GetBegoniaConfigurations()
        {
            var sql = $"SELECT key,value FROM PARAMETERS WITH (NOLOCK)";
            var data = _sqlConnection.Query<BegoniaConfiguration>(sql, transaction: _sqlTransaction);
            return data;
        }
    }
}
