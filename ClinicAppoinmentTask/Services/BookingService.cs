using ClinicAppoinmentTask.Model;
using ClinicAppoinmentTask.Repositories;

namespace ClinicAppoinmentTask.Services
{
    public class BookingService : IBookingService
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
        public void RemoveBooking(int bookingId)
        {
            var existingBooking = _bookingRepo.GetBookingById(bookingId);
            if (existingBooking == null)
                throw new Exception("Booking not found");

            _bookingRepo.RemoveBooking(existingBooking);
        }
        public void UpdateBooking(int bookingId, int patientId, int clinicId, DateTime date, int slotNumber)
        {
            if (slotNumber < 1 || slotNumber > 20)
                throw new Exception("Slot number must be between 1 and 20");

            var existingBooking = _bookingRepo.GetBookingById(bookingId);
            if (existingBooking == null)
                throw new Exception("Booking not found");

            existingBooking.PID = patientId;
            existingBooking.CID = clinicId;
            existingBooking.Date = date;
            existingBooking.SlotNumber = slotNumber;

            _bookingRepo.UpdateBooking(existingBooking);
        }
        public Booking GetBookingById(int bookingId) =>
             _bookingRepo.GetBookingById(bookingId);

        public IEnumerable<Booking> GetAppointmentsByClinic(int clinicId) =>
            _bookingRepo.GetBookingsByClinic(clinicId);

        public IEnumerable<Booking> GetAppointmentsByPatient(int patientId) =>
            _bookingRepo.GetBookingsByPatient(patientId);

        public IEnumerable<Booking> GetAppointmentsByName(string name) =>
        _bookingRepo.GetAppointmentsByName(name);
    }
}
