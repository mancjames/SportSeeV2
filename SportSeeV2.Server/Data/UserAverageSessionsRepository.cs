using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Dtos;

namespace SportSeeV2.Server.Data
{
    public interface IUserAverageSessionRepository
    {
        Task<UserAverageSessionsDto> GetAverageSessionsById(int id);
    }
    public class UserAverageSessionsRepository : IUserAverageSessionRepository
    {
        private readonly SportSeeDbContext _context;

        public UserAverageSessionsRepository(SportSeeDbContext context)
        {
            _context = context;
        }

        public async Task<UserAverageSessionsDto> GetAverageSessionsById(int id)
        {
            var user = await _context.UserAverageSessionsEntity
                 .Include(u => u.Sessions)
                 .FirstOrDefaultAsync(x => x.UserMainEntityId == id);

            if (user == null)
                return null;


            var userAverageSessions = MapToUserAverageSessionsDto(user);

            return userAverageSessions;
        }

        private UserAverageSessionsDto MapToUserAverageSessionsDto(UserAverageSessionsEntity user)
        {
            return new UserAverageSessionsDto(
                 user.id,
                 user.UserMainEntityId,
                 user.Sessions.Select(s => new SessionsDto(
                    s.id, s.day, s.sessionLength
                )).ToArray()
            );
        }
    }
}
