using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliaae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        private readonly IInstitutionRepository _institutionRepository;
        public InstitutionController(IInstitutionRepository repository)
        {
            _institutionRepository = repository;
        }

        [Authorize]
        [HttpGet]
        [Route("getAllInstitution")]
        public async Task<ActionResult<List<InstitutionModel>>> getAllInstitution()
        {
            var result = await _institutionRepository.getAllInstitutionsWithType();
            return Ok(result);
        }
    }
}
