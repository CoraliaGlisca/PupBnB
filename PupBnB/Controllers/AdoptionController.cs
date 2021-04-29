using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using PupBnB.Models;

namespace PupBnB.Controllers
{
    public class AdoptionController : Controller
    {
        private IAdminRepository adminRepository;
        private IBreedsRepository breedRepository;
        private IGendersRepository gendersRepository;
        private IAppoinmentRepository appoinmentRepository;
        private IPersonRepository personRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public IConfiguration Configuration { get; }
        public AdoptionController(
            IConfiguration configuration,
            IAdminRepository adminRepository,
            IBreedsRepository breedRepository,
            IGendersRepository gendersRepository,
            IAppoinmentRepository appoinmentRepository,
            UserManager<ApplicationUser> userManager, 
            IPersonRepository personRepository)
        {
            Configuration = configuration;
            this.adminRepository = adminRepository;
            this.breedRepository = breedRepository;
            this.gendersRepository = gendersRepository;
            this.appoinmentRepository =appoinmentRepository;
            _userManager = userManager;
            this.personRepository = personRepository;
        }

        [HttpGet]
        public ActionResult Adopt()
        {
            IEnumerable<DogViewModel> viewModel = adminRepository.GetAll().Select(s => new DogViewModel
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
            });
            return View(viewModel);

        }

        [HttpPost]

        public ActionResult Adopt(DogViewModel viewModel)
        {
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Appointments()
        {           
            AppointmentsViewModel model= new AppointmentsViewModel();
           
            return View(model);
           
        }

        [HttpPost]
        public IActionResult Appointments(AppointmentsViewModel viewModel, int? id)
         {
            if (ModelState.IsValid)
            {               
                if (id.HasValue)
                {
                    Dogs dogs = adminRepository.GetDogs(id.Value);
                    {
                        viewModel.DogId = dogs.DogId;
                    }
                }

                if (!personRepository.CheckIfUserExists(_userManager.GetUserId(User).ToString()))
                {

                    personRepository.AddUser(_userManager.GetUserId(User).ToString());

                }
                string UserId = _userManager.GetUserId(User).ToString();
                if (!appoinmentRepository.CheckUniqueDateByDogId(viewModel.Date, viewModel.DogId))
                {

                    appoinmentRepository.Add(new AppointmentsModel()
                    {
                        AppointmentId = viewModel.AppointmentId,
                        FirstName = viewModel.FirstName,
                        LastName = viewModel.LastName,
                        Date = viewModel.Date,
                        DogId = viewModel.DogId,
                        UserId = UserId
                    });

                    ViewBag.message = "Your appointment was successful! See you soon!";
                }
                else
                {
                    ViewBag.message = "There already exists an appointment at this hour!";
                }

                return View(viewModel);
            }
            //string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string insertString = $"Insert Into Appointments (FirstName, LastName, Date) Values ('{viewModel.FirstName}', '{viewModel.LastName}','{viewModel.Date}')";
            //    using (SqlCommand command = new SqlCommand(insertString, connection))
            //    {
            //        command.CommandType = CommandType.Text;
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        connection.Close();
            //    }
            //    return RedirectToAction("Appointments");
            //}
            else
                return View();
        }
            
        }       

    }

    