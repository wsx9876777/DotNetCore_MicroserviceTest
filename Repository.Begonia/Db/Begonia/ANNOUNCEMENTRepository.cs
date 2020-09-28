using Dapper;
using Repository.Begonia.Interface;
using Repository.Begonia.Models;
using Repository.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Begonia.Db
{
    public class ANNOUNCEMENTRepository : IANNOUNCEMENTRepository
    {
        private readonly SqlConnectionBegonia _begonia;

        public ANNOUNCEMENTRepository(SqlConnectionBegonia sqlConnectionBegonia)
        {
            this._begonia = sqlConnectionBegonia;
        }
        public IEnumerable<ANNOUNCEMENT> GetAll()
        {
            var sql = $"SELECT ID,language,GroupID,TITLE,DESCRIPTION,PDF FROM ANNOUNCEMENT";
            var data = _begonia.SqlConnection.Query<ANNOUNCEMENT>(
                sql,
                buffered: false,
                transaction: _begonia.SqlTransaction);
            return data;
        }

        public void Update(int ID,string Desc)
        {
            var sql = $"UPDATE ANNOUNCEMENT SET DESCRIPTION=@Desc WHERE ID=@ID";
            object @params = new { Desc = Desc, ID = ID };
            var data = _begonia.SqlConnection.Execute(
                sql, 
                @params,
                transaction: _begonia.SqlTransaction);
        }
    }
}
