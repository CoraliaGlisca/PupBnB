using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.Models
{
    public class AppointmentsViewModel
    {        

        [Required]
        [Display(Name = "Enter your first name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Enter your last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "The date you wish to appoint")]
        public DateTime Date { get; set; }

        public int AppointmentId { get; set; }

        public int DogId { get; set; }
        public Dogs Dog { get; set; }

        public string UserId { get; set; }

        public Person Person { get; set; }
    }
}
