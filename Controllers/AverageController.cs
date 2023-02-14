using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliaae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AverageController : ControllerBase
    {
        private readonly IAverageRepository _repository;
        public AverageController(IAverageRepository repository)
        {
            _repository = repository;
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllAverages")]
        public async Task<ActionResult<List<AverageModel>>> GetAllAverages()
        {
            var result = await _repository.GetAllAverages();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(new { success = false, message = "No data found" });
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllAveragesWithInstitution")]
        public async Task<ActionResult<List<AverageModel>>> GetAllAveragesWithInstitution()
        {
            var result = await _repository.GetAveragesByInstitution();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound(new { success = false, message = "No data found"});
            }
        }
    }
}
