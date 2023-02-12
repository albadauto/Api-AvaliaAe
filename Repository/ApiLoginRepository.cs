using api_avaliaae.Data;
using api_avaliaae.Repository.Interfaces;

namespace api_avaliaae.Repository
{
    public class ApiLoginRepository : IApiLoginRepository
    {
        private readonly DatabaseContext _context;
        public ApiLoginRepository(DatabaseContext context) 
        {
            _context = context; 
        }
    }
}
