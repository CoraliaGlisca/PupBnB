using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IPersonRepository : IRepository<Person>
    {
        void AddUser(string userId);
        bool CheckIfUserExists(string userId);
    }
}
