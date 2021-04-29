using BankingSystem.EFDataAccess;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class BreedsRepository : BaseRepository<Breeds>, IBreedsRepository
    {
        public BreedsRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }

        public void AddBreed(int BreedId, string BreedName)
        {
            this.Add(new Breeds() { BreedId = BreedId, BreedName =  BreedName});
        }

        public bool CheckIfBreedExists(string BreedName)
        {
            if (dbContext.Breeds.FirstOrDefault(breed => breed.BreedName == BreedName) != null)
            {
                return true;
            }
            return false;
        }

        public Breeds GetBreeds(int BreedId)
        {
            return dbContext.Breeds.SingleOrDefault(s => s.BreedId == BreedId);
        }

        public string GetBreedsById(int BreedId)
        {
            return dbContext.Breeds.SingleOrDefault(s => s.BreedId == BreedId).BreedName.ToString();
        }

        public List<Breeds> getAllBreeds()
        {
            return dbContext.Breeds.ToList();
        }

        public int GetBreedsIdByName( string BreedName)
        {
            return dbContext.Breeds.FirstOrDefault(s => s.BreedName == BreedName).BreedId;
        }

       
    }
}
