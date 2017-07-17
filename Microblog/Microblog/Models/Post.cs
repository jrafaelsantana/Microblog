using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Microblog.Models
{
    public class Post
    {
        public int id { get; set; }
        public int idUser { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }
        public string urlImgFeatured { get; set; }
        public bool isPublished { get; set; }

    }
}