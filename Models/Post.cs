using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Post
    {

        public int PostID { get; set; }

        public string PostTitle { get; set; }

        public string PostSubject { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }



    }
}