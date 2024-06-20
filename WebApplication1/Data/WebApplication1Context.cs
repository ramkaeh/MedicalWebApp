using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Hosting;

namespace WebApplication1.Data
{
    public class WebApplication1Context : IdentityDbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<DoctorClinic>()
               .HasKey(ri => new { ri.ClinicId, ri.DoctorId });

            modelBuilder.Entity<DoctorClinic>()
               .HasOne(ri => ri.Clinic)
               .WithMany(r => r.DoctorClinics)
               .HasForeignKey(ri => ri.ClinicId);

            modelBuilder.Entity<DoctorClinic>()
                .HasOne(ri => ri.Doctor)
                .WithMany(i => i.DoctorClinics)
                .HasForeignKey(ri => ri.DoctorId);


            modelBuilder.Entity<Clinic>().HasData(
            new Clinic { Id = 1, Name = "Clinic 1", Location ="Bialystok"  },
            new Clinic { Id = 2, Name = "Clinic 3", Location = "Białystok" },
            new Clinic { Id = 3, Name = "Clinic 3", Location = "Warszawa" }
            );
            modelBuilder.Entity<Doctor>().HasData(
            new Doctor { Id = 1, Name = "Damian 1", Surname = "Jankowski", Age=26, Gender="Male", Major="Kardiolog"},
            new Doctor { Id = 2, Name = "Kacper 2", Surname = "Kowalski", Age = 60, Gender = "Male", Major = "Chirurg" },
            new Doctor { Id = 3, Name = "Damiano 3", Surname = "Warszawa", Age = 34, Gender = "Male", Major = "Ortopeda" }
            );
/*
            modelBuilder.Entity<ClinicEmployees>().HasData(
            new ClinicEmployees { DoctorId = 1, ClinicId = 1 },
            new ClinicEmployees { DoctorId = 1, ClinicId = 2 },
            new ClinicEmployees { DoctorId = 2, ClinicId = 2 },
            new ClinicEmployees { DoctorId = 3, ClinicId = 1 }
            );

*/

        }


        public DbSet<WebApplication1.Models.Doctor> Doctors { get; set; } = default!;
        public DbSet<WebApplication1.Models.Appointment> Appointments { get; set; } = default!;
        public DbSet<WebApplication1.Models.Clinic> Clinics { get; set; } = default!;
        public DbSet<WebApplication1.Models.Patient> Patients { get; set; } = default!;


    }
}
