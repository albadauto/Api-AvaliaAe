using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_avaliaae.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> getAllUsers()
        {
            var result = await _repository.getAllUsers();
            return Ok(result);
        }
    }
}
