using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class Breeds
    {
        public Breeds()
        {
            Dogs = new List<Dogs>();          
        }
        public int BreedId { get; set; }

        public string BreedName { get; set; }

        public ICollection<Dogs> Dogs { get; set; }
    }
}
