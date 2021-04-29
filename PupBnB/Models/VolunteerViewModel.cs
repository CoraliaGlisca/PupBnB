using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.Models
{
    public class VolunteerViewModel
    {
            public Guid VolunteerId;

            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress]           
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Age")]
            public int Age { get; set; }

            [Required]
            [MaxLength(200)]
            [Display(Name = "Give us a short descripion of yourself!(200 car. max)")]
            public string Description { get; set; }

    }
}
