using ClinicAppoinmentTask.Model;
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
        public void BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber)
        {
            if (slotNumber < 1 || slotNumber > 20)
                throw new Exception("Slot number must be between 1 and 20");

            var booking = new Booking
            {
                PID = patientId,
                CID = clinicId,
                Date = date,
                SlotNumber = slotNumber
            };

            _bookingRepo.AddBooking(booking);
        }

        public IEnumerable<Booking> GetAppointmentsByClinic(int clinicId) =>
            _bookingRepo.GetBookingsByClinic(clinicId);
    }
}
