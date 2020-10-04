using Repository.DevelopDb.Db;
using Repository.DevelopDb.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Data;
using System.Threading;

namespace Repository.DeveloperDb.Db
{
    public class GradesRepository : IGragesRepository
    {
        private readonly SqlConnectionDeveloperDb _conn;
        private static object _object = 1;
        public GradesRepository(SqlConnectionDeveloperDb conn)
        {
            this._conn = conn;
        }

        public int Update(int id, int count)
        {
            int result = 0;
            var proc = "dbo.usp_updateGrades";
            result = _conn.SqlConnection.Execute(
                sql: proc,
                param: new { id = 1, count = 1 },
                transaction: _conn.SqlTransaction,
                commandType: CommandType.StoredProcedure);
            return result;
        }

        public int Insert()
        {
            int result = 0;
            var proc = "dbo.usp_InsertGrades";
            result = _conn.SqlConnection.Execute(
                sql: proc,
                transaction: _conn.SqlTransaction,
                commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
