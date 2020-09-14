using Dapper;
using Microservice.Interface;
using Microservice.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Provider
{
    public class AnnouncementProvider : IAnnouncementProvider
    {
        private readonly IConfiguration _Configuration;
        private readonly IConnectionFectory _connectionFectory;

        public AnnouncementProvider(IConfiguration configuration,
            IConnectionFectory connectionFectory)
        {
            _Configuration = configuration;
            _connectionFectory = connectionFectory;
        }

        public async Task<IEnumerable<Announcement>> GetList()
        {
            IEnumerable<Announcement> data =null;
            var sql = "Select * from ANNOUNCEMENT where id=@id";
            //var sql2 = $"update ANNOUNCEMENT set Title = @title  where id = @id";
            
            using (var conn = _connectionFectory.DbCoonection("begonia"))
            {
                //conn.Open();
               // using (var tran = conn.BeginTransaction())
               // {
                   // conn.Execute(sql2, new { title = "asdsa", id = 1 }, tran);

                   // conn.Execute(sql2, new { title = "ssss", id = 1 }, tran);
                   // tran.Commit();
                    data = await conn.QueryAsync<Announcement>(sql, new { id = 1 });
               // }
            }
            
            return data;
        }

    }
}
