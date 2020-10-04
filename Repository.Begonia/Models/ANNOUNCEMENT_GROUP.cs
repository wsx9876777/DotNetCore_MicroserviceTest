using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Begonia.Models
{
    public class ANNOUNCEMENT_GROUP
    {
        public int id { get; set; }
        public string groupName { get; set; }
        public int listOrder { get; set; }
        public DateTime createTime { get; set; }
        public DateTime updateTime { get; set; }
        public int language { get; set; }
    }
}