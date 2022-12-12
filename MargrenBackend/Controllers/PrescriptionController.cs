using Margren.Domain.Entities;
using MargrenBackend.ApplicationServices;
using MargrenBackend.Commands;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MargrenBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController: ControllerBase
    {
        private readonly PrescriptionServices prescriptionServices;
        public PrescriptionController(PrescriptionServices prescriptionServices)
        {
            this.prescriptionServices = prescriptionServices;
        }
        [HttpGet("getPrescriptionById/{id}")]
        public async Task<ActionResult<Prescription>> GetPrescriptionById(int id)
        {
            var response = await prescriptionServices.GetPrescriptionById(id);
            return Ok(response);
        }

        [HttpPost("createPrescription")]
        public async Task<IActionResult> AddPrescription(CreatePrescriptionCommand createPrescription)
        {
            try
            {
                return Ok(await prescriptionServices.HandleCommand(createPrescription));
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR Receta", "Ya existe una receta con ese Id: " + ex.Message));
            }
            catch (Exception ex)
            {
                return Ok(ContentResponse.createResponse(false, "ERROR AL CREAR Receta", ex.Message));
            }
        }
    }
}
