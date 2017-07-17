using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microblog.Models
{
    public class User
    {
        public int id { get; set; }
        public string user { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public string name { get; set; }
        public int rule { get; set; }
    }
}