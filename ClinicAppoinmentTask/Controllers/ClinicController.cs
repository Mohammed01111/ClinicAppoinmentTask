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


        // PUT: api/clinic/update
        [HttpPut("update")]
        public IActionResult UpdateClinic([FromBody] Clinic updatedClinic)
        {
            try
            {
                _clinicService.UpdateClinic(updatedClinic);
                return Ok("Clinic updated successfully");
            }
            catch (Exception ex)
            {
                return NotFound($"Error: {ex.Message}");
            }
        }


        // DELETE: api/clinic/remove/{clinicId}
        [HttpDelete("remove/{clinicId}")]
        public IActionResult RemoveClinic(int clinicId)
        {
            try
            {
                _clinicService.RemoveClinic(clinicId);
                return Ok("Clinic removed successfully");
            }
            catch (Exception ex)
            {
                return NotFound($"Error: {ex.Message}");
            }
        }
    }
}
