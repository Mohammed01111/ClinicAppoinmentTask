using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public interface IBookingRepo
    {
        void AddBooking(Booking booking);
        IEnumerable<Booking> GetAllBookings();
        void RemoveBooking(Booking booking);
        void UpdateBooking(Booking booking);
    }
}