using ClinicAppoinmentTask.Model;
using ClinicAppoinmentTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppoinmentTask.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        // POST: api/patient/add
        [HttpPost("add")]
        public IActionResult AddPatient([FromBody] Patient patient)
        {
            try
            {
                _patientService.AddPatient(patient);
                return Ok("Patient added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        // GET: api/patient/all
        [HttpGet("all")]
        public IActionResult GetAllPatients()
        {
            var patients = _patientService.GetAllPatients();
            return Ok(patients);
        }


    }
}
