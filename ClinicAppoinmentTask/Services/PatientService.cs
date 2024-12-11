using ClinicAppoinmentTask.Model;
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

        public void AddPatient(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.Name))
                throw new Exception("Patient name is required.");

            if (patient.Age <= 0)
                throw new Exception("Patient age must be greater than zero.");

            if (string.IsNullOrWhiteSpace(patient.Gender) ||
                !(patient.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ||
                  patient.Gender.Equals("Female", StringComparison.OrdinalIgnoreCase)))
                throw new Exception("Patient gender must be 'Male' or 'Female'.");

            _patientRepo.AddPatient(patient);
        }
    }
}
