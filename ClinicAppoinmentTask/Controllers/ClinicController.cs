using ClinicAppoinmentTask.Model;
using ClinicAppoinmentTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppoinmentTask.Controllers
{
    [ApiController]
    [Route("api/clinic")]
    public class ClinicController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpPost("add")]
        public IActionResult AddClinic([FromBody] Clinic clinic)
        {
            try
            {
                _clinicService.AddClinic(clinic);
                return Ok("Clinic added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        // GET: api/clinic/all
        [HttpGet("all")]
        public IActionResult GetAllClinics()
        {
            var clinics = _clinicService.GetAllClinics();
            return Ok(clinics);
        }

        // GET: api/clinic/{clinicId}
        [HttpGet("{clinicId}")]
        public IActionResult GetClinicById(int clinicId)
        {
            try
            {
                var clinic = _clinicService.GetClinicById(clinicId);
                return Ok(clinic);
            }
            catch (Exception ex)
            {
                return NotFound($"Error: {ex.Message}");
            }
        }

        // GET: api/clinic/specialization/{specialization}
        [HttpGet("specialization/{specialization}")]
        public IActionResult GetClinicBySpecialization(string specialization)
        {
            try
            {
                var clinic = _clinicService.GetClinicBySpecialization(specialization);
                return Ok(clinic);
            }
            catch (Exception ex)
            {
                return NotFound($"Error: {ex.Message}");
            }
        }
}
