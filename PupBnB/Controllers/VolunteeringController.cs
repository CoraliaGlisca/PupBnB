using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PupBnB.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using PupBnB.ApplicationLogic.Abstractions;
using Microsoft.AspNetCore.Identity;
using PupBnB.ApplicationLogic.DataModel;

namespace PupBnB.Controllers
{
    public class VolunteeringController : Controller
    {

        private IVolunteerRepository volunteerRepository;       

        public VolunteeringController(IVolunteerRepository volunteerRepository)
        {
            this.volunteerRepository = volunteerRepository;           
        }

        [HttpGet]
        public ActionResult Volunteer()
        {
            return View();
        }      
        

        [HttpPost]
        public IActionResult Volunteer(VolunteerViewModel viewModel)
        {           
               

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!volunteerRepository.CheckUniqueEmail(viewModel.Email)) { 

                volunteerRepository.Add(new VolunteerModel()
                { 
                    VolunteerId = viewModel.VolunteerId, 
                    FirstName = viewModel.FirstName, 
                    LastName = viewModel.LastName, 
                    Email = viewModel.Email, 
                    Age = viewModel.Age, 
                    Description = viewModel.Description 
                });

                ViewBag.message = "Your registration was successful!";
            }
            else
            {
                ViewBag.message = "You already used this email to submit this form!";
            }

            return View(viewModel);
            }
    }       
    
}
