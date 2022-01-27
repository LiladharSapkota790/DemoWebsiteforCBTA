using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Booking
    {


        [Key]
        [Column(Order = 0)]
        public int Memberid { get; set; }
        [Key]
        [Column(Order = 1)]
        public int EventId { get; set; }

        public DateTime RegisteredTime { get; set; }
        public Boolean Has_Paid { get; set; }
        public virtual Member Member { get; set; }
        public virtual Event Event { get; set; }


    }
}