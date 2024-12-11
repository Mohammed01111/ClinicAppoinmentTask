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
    }
}
