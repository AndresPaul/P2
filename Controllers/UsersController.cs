using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }
        [HttpPost]
        public IActionResult PostUsers()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult PutUsers()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUsers()
        {
            return Ok();
        }
    }
}
