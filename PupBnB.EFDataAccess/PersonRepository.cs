using BankingSystem.EFDataAccess;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }

        public void AddUser(string userId)
        {
            this.Add(new Person() { UserId = userId });
        }

        public bool CheckIfUserExists(string userId)
        {
            if (dbContext.People.FirstOrDefault(user => user.UserId == userId) != null)
            {
                return true;
            }
            return false;
        }
    }
}
