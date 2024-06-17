using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

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
            
            modelBuilder.Entity<Doctor>()
                .HasMany(s => s.Clinics)
                .WithMany(c => c.Doctors)
                .UsingEntity<Dictionary<string, object>>(
                    "DoctorClinic",
                    j => j.HasOne<Clinic>().WithMany().HasForeignKey("Id"),
                    j => j.HasOne<Doctor>().WithMany().HasForeignKey("Id"));

            modelBuilder.Entity<Clinic>().HasData(
            new Clinic { Id = 1, Name = "Clinic 1", Location ="Bialystok" },
            new Clinic { Id = 2, Name = "Clinic 2", Location = "Bialystok" },
            new Clinic { Id = 3, Name = "Clinic 3", Location = "Warszawa" }
            );


        }


        public DbSet<WebApplication1.Models.Doctor> Doctors { get; set; } = default!;
        public DbSet<WebApplication1.Models.Appointment> Appointments { get; set; } = default!;
        public DbSet<WebApplication1.Models.Clinic> Clinics { get; set; } = default!;
        public DbSet<WebApplication1.Models.Patient> Patients { get; set; } = default!;


    }
}
