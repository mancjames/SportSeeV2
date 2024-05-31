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
        private readonly ActivitySessionRepository _activitySessionRepository;

        public UserController(UserMainRepository userRepository, ActivitySessionRepository activitySessionRepository)
        {
            _userRepository = userRepository;
            _activitySessionRepository = activitySessionRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserMainDto>>> GetUsers()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserMainDto>> Get(int id)
        {
            var user = await _userRepository.GetId(id);
            if (user == null)
            {
                return Problem($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpGet("{id}/Activity")]
        public async Task<ActionResult<UserActivityDto>> GetActivityById(int id)
        {
            var user = await _activitySessionRepository.GetActivityById(id);
            if (user == null)
            {
                return Problem($"User with ID {id} not found.");
            }
            return Ok(user);
        }
    }
}
