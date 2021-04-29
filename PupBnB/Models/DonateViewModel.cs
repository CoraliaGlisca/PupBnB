using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.Models
{
    public class DonateViewModel
    {
        public Guid DonationId;

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int CardNumber { get; set; }

        public string UserId { get; set; }
    }
}
