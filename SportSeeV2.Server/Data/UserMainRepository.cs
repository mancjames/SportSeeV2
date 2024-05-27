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
    }
}
