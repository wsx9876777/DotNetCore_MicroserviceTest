using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Interface
{
    public interface IConnectionFectory
    {
        IDbConnection DbCoonection(string name);
    }
}
