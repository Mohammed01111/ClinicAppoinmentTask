using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public class BookingRepo
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


    }
}
