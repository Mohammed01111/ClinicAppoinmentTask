using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public interface IClinicRepo
    {
        void AddClinic(Clinic clinic);
        IEnumerable<Clinic> GetClinics();
        void RemoveClinic(Clinic clinic);
        void UpdateClinic(Clinic clinic);
    }
}