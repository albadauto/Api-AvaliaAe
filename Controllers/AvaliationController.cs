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

        //<description>Irá pegar todas as avaliações
        [Authorize]
        [HttpGet]
        [Route("GetAvaliations")]
        public async Task<ActionResult<List<AvaliationModel>>> GetAvaliations()
        {
            var result = await _repository.getAllAvaliations();
            return Ok(result);
        }
    }
}
