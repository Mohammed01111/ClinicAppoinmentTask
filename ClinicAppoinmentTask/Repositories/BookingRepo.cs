using ClinicAppoinmentTask.Model;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppoinmentTask.Repositories
{
    public class BookingRepo : IBookingRepo
    {
        private readonly AppDbContext _context;

        public BookingRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public void RemoveBooking(Booking booking)
        {
            _context.Bookings.Remove(booking);
            _context.SaveChanges();

        }

        public Booking GetBookingById(int bookingId)
        {
            return _context.Bookings
                .Include(b => b.Patient) 
                .Include(b => b.Clinic)  
                .FirstOrDefault(b => b.BookingId == bookingId);
        }
        public IEnumerable<Booking> GetAllBookings()
        {
            return _context.Bookings
                .Include(b => b.Patient)
                .Include(b => b.Clinic)
                .ToList();
        }


        public void UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            _context.SaveChanges();

        }

        public IEnumerable<Booking> GetBookingsByPatient(int patientId) =>
            _context.Bookings
                    .Where(b => b.PID == patientId)
                    .Include(b => b.Clinic)
                    .ToList();

        public IEnumerable<Booking> GetBookingsByClinic(int clinicId) =>
           _context.Bookings
                   .Where(b => b.CID == clinicId)
                   .Include(b => b.Patient)
                   .ToList();

        public IEnumerable<Booking> GetAppointmentsByName(string name) =>
        _context.Bookings.Where(a => a.Patient.Name.Contains(name));

    }
}
