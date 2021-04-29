using BankingSystem.EFDataAccess;
using Microsoft.EntityFrameworkCore;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class VolunteerRepository : BaseRepository<VolunteerModel>, IVolunteerRepository
    {
        public VolunteerRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckUniqueEmail(string Email)
        {
            var dbEntry = dbContext.Volunteers.FirstOrDefault(x => x.Email == Email);

            if (dbEntry != null)
                return true;
            return false;
        }
    }
}
