using Repository.DevelopDb.Db;
using Repository.DevelopDb.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Data;

namespace Repository.DeveloperDb.Db
{
    public class GradesRepository : IGragesRepository
    {
        private readonly SqlConnectionDeveloperDb _conn;

        public GradesRepository(SqlConnectionDeveloperDb conn)
        {
            this._conn = conn;
        }

        public int Update(int id, int count)
        {
            var proc = "dbo.usp_updateGrades";
            var result =_conn.SqlConnection.Execute(
                sql: proc,
                param: new { id = 1, count = 1 },
                transaction: _conn.SqlTransaction,
                commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
