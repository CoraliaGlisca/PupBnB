using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class AppointmentsModel
    {              
        public int AppointmentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Date { get; set; }

        public int DogId { get; set; }
        public Dogs Dog { get; set; }

        public string UserId { get; set; }

        public Person Person { get; set; }
    }
}
