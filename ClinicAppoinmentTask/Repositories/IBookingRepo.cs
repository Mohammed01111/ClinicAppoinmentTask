using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public interface IBookingRepo
    {
        void AddBooking(Booking booking);
        IEnumerable<Booking> GetAllBookings();
        void RemoveBooking(Booking booking);
        void UpdateBooking(Booking booking);

        IEnumerable<Booking> GetBookingsByClinic(int clinicId);
        IEnumerable<Booking> GetBookingsByPatient(int patientId);


        IEnumerable<Booking> GetAppointmentsByName(string name);
        Booking GetBookingById(int bookingId);
    }
}