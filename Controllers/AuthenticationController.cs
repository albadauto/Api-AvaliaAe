using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using api_avaliaae.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliaae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IApiLoginRepository _repository;
        public AuthenticationController(IApiLoginRepository repository)
        {
            _repository = repository;    
        }

        [HttpPost]
        [Route("authenticate")]
        [AllowAnonymous]
        public async Task<ActionResult<ApiLoginModel>> Authenticate([FromBody] ApiLoginModel model)
        {
            var result = await _repository.GetUserByEmailAndPassword(model);
            if(result != null)
            {
                var token = TokenService.GenerateToken();
                return Ok(new { token = token, success = true });
            }
            else
            {
                return NotFound(new { success = false, message = "Login inválido" });
            }
        }
    }
}
