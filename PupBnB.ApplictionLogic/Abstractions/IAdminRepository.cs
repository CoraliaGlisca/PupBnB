using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IAdminRepository : IRepository<Dogs>
    {
        
        Dogs GetDogs(int id);

        void DeleteDogs(int id);

        Dogs UploadDogFile(int id);

        int GetDogId(string dogName);

       
    }
}
