using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_avaliaae.Repository
{
    public class ApiLoginRepository : IApiLoginRepository
    {
        private readonly DatabaseContext _context;
        public ApiLoginRepository(DatabaseContext context) 
        {
            _context = context; 
        }

        public async Task<ApiLoginModel> GetUserByEmailAndPassword(ApiLoginModel model)
        {
            var result = await _context.ApiLogin.FirstOrDefaultAsync(x => x.Password == model.Password && x.Login == model.Login);
            return result;
        }
    }
}
