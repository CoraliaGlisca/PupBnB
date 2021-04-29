using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PupBnB.ApplicationLogic.Abstractions;
using PupBnB.ApplicationLogic.DataModel;
using PupBnB.Models;

namespace PupBnB.Controllers
{
    public class DonationController : Controller
    {
        private IDonateRepository donateRepository;
        private IPersonRepository personRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public DonationController(
            IDonateRepository donateRepository,
            IPersonRepository personRepository, 
            UserManager<ApplicationUser> userManager)
        {
            this.donateRepository = donateRepository;
            this.personRepository = personRepository;
            _userManager = userManager;
        }


        //[Authorize(Roles= "Client")]
        [HttpGet]
        public ActionResult Donate()
        {           
            return View();

        }      


        [HttpPost]
        public ActionResult Donate(DonateViewModel viewModel)
        {
            if (!ModelState.IsValid)
             {
                 return BadRequest();
             }

            if (!personRepository.CheckIfUserExists(_userManager.GetUserId(User).ToString())) { 

                personRepository.AddUser(_userManager.GetUserId(User).ToString()); 

            }
            string UserId = _userManager.GetUserId(User).ToString();
            donateRepository.Add(new DonateModel() {DonationId = viewModel.DonationId, FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName, CardNumber = viewModel.CardNumber, Amount = viewModel.Amount, UserId = UserId });

            ViewBag.message = "Your donation was successful!";
            
            return View(viewModel);
        }
    }
}