using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class Genders
    {       
        public Genders()
        {
            Dogs = new List<Dogs>();
        }
        public int GenderId { get; set; }

        public string Type { get; set; }

        public ICollection<Dogs> Dogs { get; set; }

    }
}
