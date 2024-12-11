using ClinicAppoinmentTask.Model;
using ClinicAppoinmentTask.Repositories;

namespace ClinicAppoinmentTask.Services
{
    public class ClinicService : IClinicService
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

        public void UpdateClinic(Clinic updatedClinic)
        {
            var clinic = _clinicRepo.GetClinics().FirstOrDefault(c => c.CID == updatedClinic.CID);
            if (clinic == null)
                throw new Exception("Clinic not found.");

            clinic.Specialization = updatedClinic.Specialization;
            clinic.NumberOfSlots = updatedClinic.NumberOfSlots;

            _clinicRepo.UpdateClinic(clinic);
        }

        public Clinic GetClinicBySpecialization(string specialization)
        {
            var clinic = _clinicRepo.GetClinicBySpecialization(specialization);
            if (clinic == null)
                throw new Exception($"No clinic found with specialization: {specialization}");

            return clinic;
        }
    }
}
