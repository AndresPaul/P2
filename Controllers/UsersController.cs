using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new { name = "Juan", age = 42 });
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
