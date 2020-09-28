using Repository.Begonia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Begonia.Interface
{
    public interface IANNOUNCEMENT_GROUPRepository
    {
        public IEnumerable<ANNOUNCEMENT_GROUP> GetAll();
        public void Update(int ID,DateTime dateTime);
    }
}