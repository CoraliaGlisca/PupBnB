using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class Person
    {       

        public string UserId { get; set; }

        public ICollection<DonateModel> Donations { get; set; }

        public ICollection<AppointmentsModel> Appointments { get; set; }
    }
}
