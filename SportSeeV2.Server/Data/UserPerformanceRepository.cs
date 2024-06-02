using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Dtos;
using SportSeeV2.Server.Enums;

namespace SportSeeV2.Server.Data
{
    public interface IUserPerformanceRepository
    {
        Task<UserPerformanceDto> GetPerformanceById(int id);
    }
    public class UserPerformanceRepository : IUserPerformanceRepository
    {
        private readonly SportSeeDbContext _context;

        public UserPerformanceRepository(SportSeeDbContext context)
        {
            _context = context;
        }

        public async Task<UserPerformanceDto> GetPerformanceById(int id)
        {
            var user = await _context.UserPerformanceEntity
                .Include(u => u.Data)
                .FirstOrDefaultAsync(u => u.UserMainEntityId == id);

            if (user == null)
                return null;

            var userPerformance = MapToUserPerformanceDto(user);

            return userPerformance;

        }

        private UserPerformanceDto MapToUserPerformanceDto(UserPerformanceEntity user)
        {
            var kindDictionary = ((PerformanceKind[])Enum.GetValues(typeof(PerformanceKind)))
               .ToDictionary(k => (int)k, k => k.ToString().ToLower());

            return new UserPerformanceDto(
                user.Id,
                user.UserMainEntityId,
                kindDictionary,
                user.Data.Select(s => new PerformanceDataDto(
                    s.Id,
                    s.Value,
                    (int)s.Kind)).ToArray()
            );
        }
    }
}
