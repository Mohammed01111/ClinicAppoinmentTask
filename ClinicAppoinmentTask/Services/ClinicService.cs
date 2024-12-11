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
    }
}
