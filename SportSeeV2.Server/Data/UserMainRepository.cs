using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Dtos;
using SportSeeV2.Server.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportSeeV2.Server.Data
{
    public class UserMainRepository
    {
        private readonly SportSeeDbContext _context;

        public UserMainRepository(SportSeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserMainDto>> GetAll()
        {
            var users = await _context.UserMainEntities
                 .Include(u => u.UserInfos)
                 .Include(u => u.KeyData)
                 .ToListAsync();

            var userDtos = users.Select(u => new UserMainDto(
                 u.Id,
                 new UserInfosDto(
                     u.UserInfos.Id,
                     u.UserInfos.FirstName,
                     u.UserInfos.LastName,
                     u.UserInfos.Age
                 ),
                 u.TodayScore,
                 new KeyDataDto(
                     u.KeyData.Id,
                     u.KeyData.CalorieCount,
                     u.KeyData.ProteinCount,
                     u.KeyData.CarbohydrateCount,
                     u.KeyData.LipidCount
                 )
             ));

            return userDtos.ToList();
        }

        public async Task<UserMainDto> GetId(int id)
        {
            var user = await _context.UserMainEntities
                 .Include(u => u.UserInfos)
                 .Include(u => u.KeyData)
                 .FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
                return null;
            
            
            var userDtos = new UserMainDto(
                 user.Id,
                 new UserInfosDto(
                     user.UserInfos.Id,
                     user.UserInfos.FirstName,
                     user.UserInfos.LastName,
                     user.UserInfos.Age
                 ),
                 user.TodayScore,
                 new KeyDataDto(
                     user.KeyData.Id,
                     user.KeyData.CalorieCount,
                     user.KeyData.ProteinCount,
                     user.KeyData.CarbohydrateCount,
                     user.KeyData.LipidCount
                 )
             );

            return userDtos;
        }
    }
}
