using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PupBnB.ApplicationLogic.Abstractions
{
    public interface IBreedsRepository : IRepository<Breeds>
    {
        string GetBreedsById(int BreedId);

        bool CheckIfBreedExists(string BreedName);

        void AddBreed(int BreedId, string BreedName);

        Breeds GetBreeds(int BreedId);

        int GetBreedsIdByName(string BreedName);

        //Breeds GetListOfBreeds(int BreedId, string BreedName);
        List<Breeds> getAllBreeds();

    }
}
