namespace ClinicAppoinmentTask.Repositories
{
    public class PatientRepo
    {
        private readonly AppDbContext _context;

        public PatientRepo(AppDbContext context)
        {
            _context = context;
        }
    }
}
