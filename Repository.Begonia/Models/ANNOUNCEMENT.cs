using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Begonia.Models
{
    public class ANNOUNCEMENT
    {
        public int ID { get; set; }
        public int language { get; set; }
        public int GroupID { get; set; }
        public string TITLE { get; set; }
        public string DESCRIPTION { get; set; }
        public string PDF { get; set; }
    }
}