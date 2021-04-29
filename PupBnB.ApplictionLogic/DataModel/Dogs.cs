using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class Dogs
    {
        
        public int DogId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }

        public int BreedId { get; set; }
        public Breeds Breeds { get; set; }
        //public int AppointmentId { get; set; }
        public ICollection<AppointmentsModel> Appointments { get; set; }

        public int GenderId { get; set; }
        public Genders Genders{ get; set; }

        public string Description { get; set; }
    }
}
