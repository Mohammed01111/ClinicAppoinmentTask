namespace ClinicAppoinmentTask.Repositories
{
    public class ClinicRepo
    {
        private readonly AppDbContext _context;

        public ClinicRepo(AppDbContext context)
        {
            _context = context;
        }
    }
}
