using HealthCare.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCare.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=HealthCareDb; Trusted_Connection = true; TrustServerCertificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite Primary Key for the joining table
            modelBuilder.Entity<Appointment>()
                        .HasKey(a => new { a.PatientId, a.DoctorId });
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
