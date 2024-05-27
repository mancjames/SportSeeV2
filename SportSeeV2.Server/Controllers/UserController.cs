using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportSeeV2.Server.Data;
using SportSeeV2.Server.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportSeeV2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserMainRepository _userRepository;

        public UserController(UserMainRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMainDto>>> GetUsers()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }
    }
}
