using Microsoft.EntityFrameworkCore;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BankingSystem.EFDataAccess;
using System.Linq.Expressions;

namespace PupBnB.EFDataAccess
{
    public class AdminRepository : BaseRepository<Dogs>, IAdminRepository
    {

        public AdminRepository(PupBnBDbContext dbContext) : base(dbContext)
        {

        }


        public Dogs GetDogs(int id)
        {
            return dbContext.Dogs.SingleOrDefault(s => s.DogId == id);
        }

        public void DeleteDogs(int id)
        {
            Dogs dog = GetDogs(id);
            dbContext.Dogs.Remove(dog);
            dbContext.SaveChanges();
        }

        public Dogs UploadDogFile(int id)
        {
            return dbContext.Dogs.FirstOrDefault(x => x.DogId == id);
        }

        public int GetDogId(string dogName)
        {
            return dbContext.Dogs.FirstOrDefault((x => x.Name == dogName)).DogId;
        }

        //public Dogs GetBreedById(int Id)
        //{
        //    return dbContext.Dogs.SingleOrDefault(s => s.BreedId == Id);
        //}

    }
}