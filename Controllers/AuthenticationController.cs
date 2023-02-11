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
        [HttpPost]
        [Route("authenticate")]
        [AllowAnonymous]
        public ActionResult Authenticate()
        {
            var token = TokenService.GenerateToken();
            return Ok(token);
        }
    }
}
