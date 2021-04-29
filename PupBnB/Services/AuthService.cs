using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using PupBnB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Services
{
    public class AuthService
    {

        ApplicationUser user;


        public InputModel Input { get; set; }
        public class InputModel
        {
            [Required]
            public string FullName { get; set; }

            public string ImagePath { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public void Logout(SignInManager<ApplicationUser> signInManager)
        {
            signInManager.SignOutAsync();
        }

        public async System.Threading.Tasks.Task<IdentityResult> CreateApplicationUserAsync( UserManager<ApplicationUser> userManager, 
            ApplicationUser user, string password)
        {

            /*ApplicationUser user = new ApplicationUser
            {
                UserName = Input.Email,
                Email = Input.Email,
                FullName = Input.FullName,
            };*/

            this.user = user;
            return await userManager.CreateAsync(user, password);

        }

        public ApplicationUser GetUser(string email, string name, string file)
        {
           ApplicationUser user = new ApplicationUser
           { 
               FullName = name,
               UserName = email, 
               Email = email,
               ImagePath = file
           };
            this.user = user;
            return user;
        }
        public async System.Threading.Tasks.Task<SignInResult> LogInAsync(SignInManager<ApplicationUser> signInManager, string Email, string Password, Boolean RememberMe, Boolean lockoutOnFailure)
        {
            return await signInManager.PasswordSignInAsync(Email, Password, RememberMe, lockoutOnFailure);
        }
    }
}
