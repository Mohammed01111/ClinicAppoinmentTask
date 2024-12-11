using ClinicAppoinmentTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppoinmentTask.Controllers
{
    [ApiController]
    [Route("api/booking")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IPatientService _patientService;
        private readonly IClinicService _clinicService;

        public BookingController(IBookingService bookingService, IPatientService patientService, IClinicService clinicService)
        {
            _bookingService = bookingService;
            _patientService = patientService;
            _clinicService = clinicService;
        }

        [HttpPost("book")]
        public IActionResult BookAppointment(int patientId, int clinicId, DateTime date, int slotNumber)
        {
            try
            {
                // Check if patient exists
                var patient = _patientService.GetPatientById(patientId);
                if (patient == null)
                    return NotFound("Patient not found");

                // Check if clinic exists
                var clinic = _clinicService.GetClinicById(clinicId);
                if (clinic == null)
                    return NotFound("Clinic not found");

                // Book the appointment
                _bookingService.BookAppointment(patientId, clinicId, date, slotNumber);
                return Ok("Appointment booked successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        // Get appointments by clinic ID
        [HttpGet("clinic/{clinicId}")]
        public IActionResult GetAppointmentsByClinic(int clinicId)
        {
            try
            {
                var appointments = _bookingService.GetAppointmentsByClinic(clinicId);
                if (appointments == null || !appointments.Any())
                    return NotFound("No appointments found for this clinic");

                return Ok(appointments);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

    }
}
