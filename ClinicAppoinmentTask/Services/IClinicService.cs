using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Services
{
    public interface IClinicService
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetAllClinics();
        Clinic GetClinicBySpecialization(string specialization);
        void RemoveClinic(int clinicId);
        void UpdateClinic(Clinic updatedClinic);
    }
}