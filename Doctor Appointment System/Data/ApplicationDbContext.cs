using DoctorAppointmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointmentSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Doctor Seed Data
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Dr. Ahmed Ali",
                    Specialization = "Cardiologist",
                    Email = "ahmed@hospital.com",
                    Phone = "0300-1234567"
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Dr. Sara Khan",
                    Specialization = "Neurologist",
                    Email = "sara@hospital.com",
                    Phone = "0301-2345678"
                }
            );

            // Patient Seed Data
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id = 1,
                    Name = "Ali Hassan",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Email = "ali@gmail.com",
                    Phone = "0312-3456789",
                    Address = "Lahore, Pakistan"
                },
                new Patient
                {
                    Id = 2,
                    Name = "Fatima Malik",
                    DateOfBirth = new DateTime(1995, 8, 20),
                    Email = "fatima@gmail.com",
                    Phone = "0313-4567890",
                    Address = "Karachi, Pakistan"
                }
            );
        }
    }
}
