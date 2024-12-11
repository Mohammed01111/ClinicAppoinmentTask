using ClinicAppoinmentTask.Model;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppoinmentTask
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Patient)
                .WithMany(p => p.Bookings)
                .HasForeignKey(b => b.PID);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Clinic)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.CID);

            modelBuilder.Entity<Clinic>()
                .HasIndex(c => c.Specialization)
                .IsUnique();
        }
    }
}
