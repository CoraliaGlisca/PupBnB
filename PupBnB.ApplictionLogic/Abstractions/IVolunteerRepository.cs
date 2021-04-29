using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IVolunteerRepository : IRepository<VolunteerModel>
    {
        bool CheckUniqueEmail(string Email);
    }
}
