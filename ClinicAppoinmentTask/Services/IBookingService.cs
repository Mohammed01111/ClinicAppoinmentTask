using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Services
{
    public interface IBookingService
    {
        void BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber);
        IEnumerable<Booking> GetAppointmentsByClinic(int clinicId);
        IEnumerable<Booking> GetAppointmentsByName(string name);
        IEnumerable<Booking> GetAppointmentsByPatient(int patientId);

        void UpdateBooking(int bookingId, int patientId, int clinicId, DateTime date, int slotNumber);
        void RemoveBooking(int bookingId);

    }
}