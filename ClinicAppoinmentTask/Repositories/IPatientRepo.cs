using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public interface IPatientRepo
    {
        void AddPatient(Patient patient);
        IEnumerable<Patient> GetPatients();
        void RemovePatient(Patient patient);
        void UpdatePatient(Patient patient);
    }
}