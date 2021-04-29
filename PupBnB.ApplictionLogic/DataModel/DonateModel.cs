using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.ApplicationLogic.DataModel
{
    public class DonateModel
    {
        public Guid DonationId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Amount { get; set; }
        
        public int CardNumber { get; set; }

        public string UserId { get; set; }

        public Person Person { get; set; }
    }
}
