using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebsiteforCBTA.Models
{
    public class Member
    {
        [Key]
        public int Memberid { get; set; }



        [DisplayName(" Member First Name")]
        [Required(ErrorMessage = "Enter your First Name")]

        public string MFirstName { get; set; }

        [DisplayName(" Member LastName Name")]
        [Required(ErrorMessage = "Enter your Last Name")]

        public string MLastName{ get; set; }

        [DisplayName("Preferred Pronoun")]
        [Required(ErrorMessage = "Enter preferred pronoun")]

        public string PreferredPronoun { get; set; }

        [DisplayName(" Date of Birth")]
        [Required(ErrorMessage = "Enter your Date of birth here")]
        public DateTime DateofBirth { get; set; }



          [Required(ErrorMessage = "Enter your unit number here")]
        public string  Address1 { get; set; }

        [Required(ErrorMessage = "Enter your Street Number and Name here")]
        public string Address2 { get; set; }

        public string State { get; set; }


        public string City { get; set; }

        public string Country { get; set; }
        [Required(ErrorMessage = "please enter valid postcode")]
        public string Postcode { get; set; }

        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }






        public virtual ICollection<Booking> EventBookings { get; set; }





    }
}