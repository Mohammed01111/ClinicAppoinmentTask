using ClinicAppoinmentTask.Model;

namespace ClinicAppoinmentTask.Repositories
{
    public class PatientRepo
    {
        private readonly AppDbContext _context;

        public PatientRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void RemovePatient(Patient patient)
        {
            _context.Patients.Remove(patient);
            _context.SaveChanges();
        }

        public void UpdatePatient(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        
    }
}
