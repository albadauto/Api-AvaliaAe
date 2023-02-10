using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_avaliaae.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _context;
        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<UserModel>> getAllUsers()
        {
            return await _context.User.ToListAsync(); 
        }
    }
}
