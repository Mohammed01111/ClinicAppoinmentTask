using ClinicAppoinmentTask.Model;
using ClinicAppoinmentTask.Repositories;

namespace ClinicAppoinmentTask.Services
{
    public class ClinicService
    {
        private readonly IClinicRepo _clinicRepo;

        public ClinicService(IClinicRepo clinicRepo)
        {
            _clinicRepo = clinicRepo;
        }
        public void AddClinic(Clinic clinic)
        {
            if (clinic.NumberOfSlots > 20)
                throw new Exception("A clinic cannot have more than 20 slots.");

            _clinicRepo.AddClinic(clinic);
        }
        public IEnumerable<Clinic> GetAllClinics()
        {
            return _clinicRepo.GetClinics();
        }
        public void RemoveClinic(int clinicId)
        {
            var clinic = _clinicRepo.GetClinics().FirstOrDefault(c => c.CID == clinicId);
            if (clinic == null)
                throw new Exception("Clinic not found.");

            _clinicRepo.RemoveClinic(clinic);
        }

    }
}
