using ClinicAppoinmentTask.Repositories;

namespace ClinicAppoinmentTask.Services
{
    public class PatientService
    {
        private readonly IPatientRepo _patientRepo;

        public PatientService(IPatientRepo patientRepo)
        {
            _patientRepo = patientRepo;
        }
    }
}
