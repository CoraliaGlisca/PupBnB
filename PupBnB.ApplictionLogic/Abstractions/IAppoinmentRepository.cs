using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IAppoinmentRepository : IRepository<AppointmentsModel>
    {
        bool CheckUniqueDateByDogId(DateTime Date, int DogId);
    }
}
