using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class PostDetails
    {

        [Key]
        [Column(Order = 0)]
        public int Memberid { get; set; }
        [Key]
        [Column(Order = 1)]
        public int PostID { get; set; }


        public virtual Member Member { get; set; }

        public virtual Post Post { get; set; }


    }
}