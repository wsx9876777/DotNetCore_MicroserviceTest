using Dapper;
using Repository.Begonia.Interface;
using Repository.Begonia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Begonia.Db
{
    public class ANNOUNCEMENT_GROUPRepository : IANNOUNCEMENT_GROUPRepository
    {

        private readonly SqlConnectionBegonia _begonia;

        public ANNOUNCEMENT_GROUPRepository(SqlConnectionBegonia sqlConnectionBegonia)
        {
         
            this._begonia = sqlConnectionBegonia;
        }
        public IEnumerable<ANNOUNCEMENT_GROUP> GetAll()
        {
            var sql = $"SELECT ID,groupName,listOrder,createTime,updateTime,language FROM ANNOUNCEMENT_GROUP";
            var data = _begonia.SqlConnection.Query<ANNOUNCEMENT_GROUP>(sql,buffered:false, transaction: _begonia.SqlTransaction);
            return data;
        }

        public void Update(int ID,DateTime createTime)
        {
            var sql = $"UPDATE ANNOUNCEMENT_GROUP SET createTime=@createTime WHERE ID=@id";
            object @params = new { createTime = createTime, id = ID };
            var data = _begonia.SqlConnection.Execute(
                sql, 
                @params, 
                transaction: _begonia.SqlTransaction);
        }
    }
}
