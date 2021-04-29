using Microsoft.AspNetCore.Mvc.Rendering;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PupBnB.Models
{
    public class DogViewModel
    {
        public int DogId { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }

        //[Required(ErrorMessage ="Enter Breed")]
        public int BreedId { get; set; }

        //[Required(ErrorMessage ="Enter Gender")]
        public int GenderId { get; set; }
      
        public string Breeds { get; set; }
       
        public string Genders { get; set; }

        //public List<SelectListItem> GenderList { get; set; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "F", Text = "F" },
        //    new SelectListItem { Value = "M", Text = "M" },
        //};
        public string Description { get; set; }

    }
}
