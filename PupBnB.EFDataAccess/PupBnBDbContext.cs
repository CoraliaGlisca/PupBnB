using Microsoft.EntityFrameworkCore;
using PupBnB.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupBnB.EFDataAccess
{
    public class PupBnBDbContext: DbContext
    {
        public PupBnBDbContext(DbContextOptions<PupBnBDbContext> options)
            : base(options)
        {
        }

        public DbSet<VolunteerModel> Volunteers { get; set; }

        public DbSet<DonateModel> Donations { get; set; }

        public DbSet<AppointmentsModel> Appointments { get; set; }

        public DbSet<Dogs> Dogs { get; set; }

        public DbSet<Breeds> Breeds { get; set; }

        public DbSet<Genders> Genders { get; set; }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentsModel>().HasKey(t => t.AppointmentId);
            modelBuilder.Entity<VolunteerModel>().HasKey(t => t.VolunteerId);            
            modelBuilder.Entity<DonateModel>().HasKey(t => t.DonationId);
            modelBuilder.Entity<Breeds>().HasKey(t => t.BreedId);
            modelBuilder.Entity<Dogs>().HasKey(t => t.DogId);
            modelBuilder.Entity<Genders>().HasKey(t => t.GenderId);
            modelBuilder.Entity<Person>().HasKey(t => t.UserId);

            modelBuilder.Entity<Dogs>()
                .HasOne(t => t.Breeds)
                .WithMany(t => t.Dogs)
                .HasForeignKey(f => f.BreedId);

            modelBuilder.Entity<Dogs>()
                .HasOne(t => t.Genders)
                .WithMany(t => t.Dogs)
                .HasForeignKey(f => f.GenderId);

            modelBuilder.Entity<AppointmentsModel>()
                .HasOne(t => t.Dog)
                .WithMany(t => t.Appointments)                
                .HasForeignKey(f => f.DogId);

            modelBuilder.Entity<AppointmentsModel>()
                .HasOne(t => t.Person)
                .WithMany(t => t.Appointments)
                .HasForeignKey(f => f.UserId);

            modelBuilder.Entity<DonateModel>()
                .HasOne(t => t.Person)
                .WithMany(t => t.Donations)
                .HasForeignKey(f => f.UserId);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
