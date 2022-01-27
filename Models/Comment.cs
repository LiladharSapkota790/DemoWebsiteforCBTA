using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Comment
    {

     
        public int CommentID { get; set; }


        [ForeignKey("Member")]
        public int Memberid { get; set; }
        public virtual Member Member { get; set; }

        [Key]
        [ForeignKey("Post")]
        public int PostID { get; set; }
      

        public virtual Post Post { get; set; }  
        public string CommentText { get; set; }
        public DateTime CommentedDate { get; set; }     

    }
}