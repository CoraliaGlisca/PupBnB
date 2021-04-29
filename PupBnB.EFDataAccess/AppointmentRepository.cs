using BankingSystem.EFDataAccess;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class AppointmentRepository : BaseRepository<AppointmentsModel>, IAppoinmentRepository
    {
        public AppointmentRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }

        public bool CheckUniqueDateByDogId(DateTime Date, int DogId)
        {
            var dbEntry = dbContext.Appointments.FirstOrDefault(x => x.Date == Date && x.DogId == DogId);

            if (dbEntry != null)
                return true;
            return false;
        }
    }
}
