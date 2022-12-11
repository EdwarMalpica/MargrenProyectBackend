using Margren.Domain.Entities;
using MargrenBackend.ApplicationServices;
using Microsoft.AspNetCore.Mvc;

namespace MargrenBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly LiveServices liveServices;
        public UserController(LiveServices liveServices)
        {
            this.liveServices = liveServices;
        }

        [HttpGet("getUserById/{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var response = await liveServices.GetUserById(id);
            return Ok(response);
        }




    }
}
