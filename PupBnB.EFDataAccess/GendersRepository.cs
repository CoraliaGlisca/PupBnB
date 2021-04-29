using BankingSystem.EFDataAccess;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class GendersRepository : BaseRepository<Genders>, IGendersRepository
    {
        public GendersRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }

        public void AddGender(int GenderId, string Type)
        {
            this.Add(new Genders() { GenderId = GenderId, Type = Type});
        }

        public bool CheckIfGenderExists(int GenderId)
        {
            if (dbContext.Genders.FirstOrDefault(b => b.GenderId == GenderId) != null)
            {
                return true;
            }
            return false;
        }

        public List<Genders> getAllGenders()
        {
            return dbContext.Genders.ToList();
        }

        public Genders GetGenders(int GenderId)
        {
            return dbContext.Genders.SingleOrDefault(s => s.GenderId == GenderId);
        }

        public string GetGendersById(int GenderId)
        {
            return dbContext.Genders.SingleOrDefault(s => s.GenderId == GenderId).Type.ToString();
        }

        public int GetGendersIdByName(string Type)
        {
            return dbContext.Genders.FirstOrDefault(s => s.Type == Type).GenderId;
        }
    }
}
