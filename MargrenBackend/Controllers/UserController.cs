using Margren.Domain.Entities;
using MargrenBackend.ApplicationServices;
using MargrenBackend.Commands;
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

        [HttpPost("createUser")]
        public async Task<IActionResult> AddPerson(CreateUserCommand createPersonCommand)
        {

            try
            {
                return Ok(await liveServices.HandleCommand(createPersonCommand));
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR USUARIO", "Ya existe una persona con ese Id: " + ex.Message));
            }
            catch (Exception ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR PERSONA", ex.Message));
            }
        }


    }
}
