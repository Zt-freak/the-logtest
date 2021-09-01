using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheLog.Business.Interfaces.Services;

namespace TheLog.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class Users : ControllerBase
    {
        private readonly IUserService _service;
        public Users(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult Get(int id)
        {
            var user = _service.GetUserById(id);
            Debug.Assert(user != null, "This user does not exist");
            return Ok(user);
        }
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            var users = _service.GetAllUsers();
            return Ok(users);
        }
    }
}
