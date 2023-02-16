using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliaae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaliationController : ControllerBase
    {
        private readonly IAvaliationRepository _repository;
        public AvaliationController(IAvaliationRepository repository)
        {
            _repository = repository;
        }

        [Authorize]
        [HttpGet]
        [Route("GetAvaliations")]
        public async Task<ActionResult<List<AvaliationModel>>> GetAvaliations()
        {
            var result = await _repository.getAllAvaliations();
            return Ok(result);
        }

        [Authorize]
        [HttpGet]
        [Route("GetAvaliationByUserId")]
        public async Task<ActionResult<List<AvaliationModel>>> GetAvaliationByUserId(int Id)
        {
            var result = await _repository.GetAvaliationByUserId(Id);
            return result != null ? Ok(result) : NotFound(new { message = "No data found", success = false});
        }
    }
}
