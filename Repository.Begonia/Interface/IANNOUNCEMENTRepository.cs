using Repository.Begonia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Begonia.Interface
{
    public interface IANNOUNCEMENTRepository
    {
        public IEnumerable<ANNOUNCEMENT> GetAll();
        public void Update(int ID, string Desc);
    }
}
