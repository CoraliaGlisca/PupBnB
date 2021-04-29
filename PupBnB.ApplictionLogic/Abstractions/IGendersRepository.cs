using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IGendersRepository : IRepository<Genders>
    {
        string GetGendersById(int GenderId);

        bool CheckIfGenderExists(int GenderId);

        void AddGender(int GenderId, string Type);

        Genders GetGenders(int GenderId);

        List<Genders> getAllGenders();

        int GetGendersIdByName(string Type);
    }
}
