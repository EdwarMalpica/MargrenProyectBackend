using Margren.Domain.Entities;
using MargrenBackend.ApplicationServices;
using MargrenBackend.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MargrenBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly LiveServices personServices;
        public PersonController(LiveServices personServices)
        {
            this.personServices = personServices;
        }

        [HttpGet("getPersonById/{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var response = await personServices.GetPersonById(id);
            return Ok(response);
        }

        [HttpPost("createPerson")]
        public async Task<IActionResult> AddPerson(CreatePersonCommand createPersonCommand)
        {
            
            try
            {
                return Ok(await personServices.HandleCommand(createPersonCommand));
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
        
        [HttpPost("updatePerson")]
        public async Task<IActionResult> UpdateUser(UpdatePersonCommand updatePerson)
        {
            return Ok(await personServices.HandleCommand(updatePerson));
        }
        /*
        [HttpPost("updateUser")]
        public async Task<IActionResult> UpdateUser(UpdateUserCommand updatePerson)
        {
            return Ok(await personServices.HandleCommand(updatePerson));
        }


        [HttpPost("createUserToPerson")]
        public async Task<IActionResult> AddUser(CreateUserCommand createUserCommand)
        {
            try
            {
                return Ok(await personServices.HandleCommand(createUserCommand));
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR USUARIO", "El Login ya existe: " + ex.Message));
            }
            catch (Exception ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR USUARIO", ex.Message));
            }
        }

        [HttpPost("updatePassword")]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordCommand updatePassword)
        {
            return Ok(await personServices.HandleCommand(updatePassword));
        }


        [HttpGet("getPersonById/{id}")]
        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var response = await personServices.GetPersonById(id);
            return Ok(response);
        }

        [HttpGet("getUsersOfPersonByPersonId/{id}")]
        public async Task<IActionResult> GetUsersByPersonId(int id)
        {
            var response = await personServices.GetUsersByPersonId(id);
            return Ok(response);
        }


        [HttpGet("getPersonByLogin/{login}")]
        public async Task<IActionResult> GetIdPersonByLogin(string login)
        {
            var response = await personServices.GetIdPersonByLogin(login);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> login(LoginCommand login)
        {
            var response = await personServices.HandleCommand(login);
            return Ok(response);
        }*/

    }
}
