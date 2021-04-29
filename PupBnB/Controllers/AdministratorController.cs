using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using PupBnB.Models;

namespace PupBnB.Controllers
{
    public class AdministratorController : Controller
    {        
        private IAdminRepository adminRepository;
        private IBreedsRepository breedRepository;
        private IGendersRepository gendersRepository;
        private readonly IProfileImageRepository imageRepository;

        public AdministratorController(IAdminRepository adminRepository, IBreedsRepository breedRepository,
            IGendersRepository gendersRepository, IProfileImageRepository imageRepository)
        {
            this.adminRepository = adminRepository;
            this.breedRepository = breedRepository;
            this.gendersRepository = gendersRepository;
            this.imageRepository = imageRepository;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Admin()
        {

            IEnumerable<DogViewModel> model = adminRepository.GetAll().Select(s => new DogViewModel
            {

                DogId = s.DogId,
                Name = $"{s.Name}",
                Age = s.Age,
                Image = s.Image,
                BreedId = s.BreedId,
                Breeds = breedRepository.GetBreedsById(s.BreedId),
                GenderId = s.GenderId,
                Genders = gendersRepository.GetGendersById(s.GenderId),
                Description = s.Description,
            }) ;
            return View("Admin", model);
        }

        [HttpGet]
         public IActionResult AddEditDog(int? id)
        {
            DogViewModel model = new DogViewModel();

            if (id.HasValue)
            {
                Dogs dogs = adminRepository.GetDogs(id.Value);
                {
                    model.DogId = dogs.DogId;
                    model.Name = dogs.Name;
                    model.Age = dogs.Age;
                    model.Image = dogs.Image;
                    model.BreedId = dogs.BreedId;
                    model.Breeds = breedRepository.GetBreedsById(dogs.BreedId);
                    model.GenderId = dogs.GenderId;
                    model.Genders = gendersRepository.GetGendersById(dogs.GenderId);
                    model.Description = dogs.Description;                   
                }
            }
            return PartialView("~/Views/Administrator/_AddEditDog.cshtml", model);
        }

        [HttpPost]
        public IActionResult AddEditDog(int? id, DogViewModel model, IFormFile file)
        {          
            try
            {
                if (ModelState.IsValid)
                {
                    bool isNew = !id.HasValue;
                    Dogs dogs = isNew ? new Dogs
                    {                      
                    } : adminRepository.GetDogs(id.Value);
                    //var Id = breedRepository.GetBreedsIdByName(model.Breeds);
                    if (!breedRepository.CheckIfBreedExists(model.Breeds))
                    {
                        
                        breedRepository.AddBreed(model.BreedId, model.Breeds);

                    }
                    //if (!gendersRepository.CheckIfGenderExists(model.GenderId))
                    //{

                    //    gendersRepository.AddGender(model.GenderId, model.Genders);

                    //}
                    dogs.Name = model.Name;
                    dogs.Age = model.Age;
                    dogs.Image = model.Image;
                    dogs.BreedId = breedRepository.GetBreedsIdByName(model.Breeds);
                    List<Breeds> breeds = breedRepository.getAllBreeds();
                    dogs.GenderId = gendersRepository.GetGendersIdByName(model.Genders);
                    List<Genders> genders = gendersRepository.getAllGenders();
                    dogs.Description = model.Description;
                    
                    if (isNew)
                    {
                        adminRepository.Add(dogs);
                        UploadFile(file, dogs.DogId);
                        //dogs.Image = file.FileName;

                    }
                    else
                    {
                        adminRepository.Update(dogs);
                        UploadFile(file, dogs.DogId);
                        //dogs.Image = file.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Admin");
        }
        public void UploadFile(IFormFile file, int DogId)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            var dog = adminRepository.UploadDogFile(DogId);
            dog.Image = fileName;
            adminRepository.Update(dog);
        }

        [HttpGet]
        public IActionResult DeleteDog(int id)
        {
            Dogs dog = adminRepository.GetDogs(id);
            DogViewModel model = new DogViewModel
            {
                Name = $"{dog.Name}"
            };
            return PartialView("~/Views/Administrator/_DeleteDog.cshtml", model);
        }
        [HttpPost]
        public IActionResult DeleteDog(int id, IFormCollection form)
        {
            adminRepository.DeleteDogs(id);
            return RedirectToAction("Admin");
        }
    }
}