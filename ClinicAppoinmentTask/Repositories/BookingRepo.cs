namespace ClinicAppoinmentTask.Repositories
{
    public class BookingRepo
    {
        private readonly AppDbContext _context;

        public BookingRepo(AppDbContext context)
        {
            _context = context;
        }
    }
}
