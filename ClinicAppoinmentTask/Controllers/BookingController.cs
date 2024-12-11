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

    }
}
