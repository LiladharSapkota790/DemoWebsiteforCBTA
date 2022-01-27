using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Subscription
    {
       
        public int Memberid { get; set; }
    
        public int SubscriptionId { get; set; }

   


        public virtual Member Member { get; set; }


        [Key]
        [ForeignKey("MembershipTypes")]
        public int MembershipTypesId { get; set; }
        public virtual MembershipTypes MembershipTypes { get; set; }

        public DateTime JoinedDate { get; set; }
        public DateTime? CanceldDate { get; set; }

        public Boolean? Has_paid { get; set; }




    }
}