using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Services
{
    public interface IPatientService
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientById(int patientId);
        void RemovePatient(int patientId);
        void UpdatePatient(Patient updatedPatient);
    }
}