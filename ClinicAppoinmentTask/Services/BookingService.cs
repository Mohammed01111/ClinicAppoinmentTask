using ClinicAppoinmentTask.Repositories;

namespace ClinicAppoinmentTask.Services
{
    public class BookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }
    }
}
