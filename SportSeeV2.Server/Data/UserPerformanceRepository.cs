namespace SportSeeV2.Server.Data
{
    public interface IUserPerformanceRepository
    {

    }
    public class UserPerformanceRepository : IUserPerformanceRepository
    {
        private readonly SportSeeDbContext _context;

        public UserPerformanceRepository(SportSeeDbContext context)
        {
            _context = context;
        }
    }
}
