using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PupBnB.Models;

namespace PupBnB.Data
{
    
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Administrator", NormalizedName = "Admin" });
            //modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "Client", NormalizedName = "Client" });
        }*/
    }
}
