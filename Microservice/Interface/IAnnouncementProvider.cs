using Microservice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Interface
{
    public interface IAnnouncementProvider
    {
        Task<IEnumerable<Announcement>> GetList();
        
    }
}
