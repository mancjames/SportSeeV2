using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Dtos;

namespace SportSeeV2.Server.Data
{
    public class ActivitySessionRepository
    {
        private readonly SportSeeDbContext _context;

        public ActivitySessionRepository(SportSeeDbContext context)
        {
            _context = context;
        }

        public async Task<UserActivityDto> GetActivityById(int id)
        {
            var user = await _context.UserActivityEntity
                 .Include(u => u.ActivitySessions)
                 .FirstOrDefaultAsync(x => x.UserMainEntityId == id);

            if (user == null)
                return null;


            var userActivity = new UserActivityDto(
                 user.id,
                 user.UserMainEntityId,
                 user.ActivitySessions.Select(s => new ActivitySessionsDto(
                    s.day.ToString("dd/MM/yyyy"), s.kilogram, s.calories
                )).ToArray()
             );

            return userActivity;
        }
    }
}
