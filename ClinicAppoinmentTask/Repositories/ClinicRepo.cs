using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public class ClinicRepo
    {
        private readonly AppDbContext _context;

        public ClinicRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddClinic(Clinic clinic)
        {   
            _context.Clinics.Add(clinic);
            _context.SaveChanges();
        }

        public IEnumerable<Clinic>GetClinics() => _context.Clinics.ToList();

    }
}
