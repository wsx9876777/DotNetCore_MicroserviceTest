using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DevelopDb.Interface
{
    public interface IGragesRepository
    {
        public int Update(int id, int count);
        public int Insert();
    }
}
