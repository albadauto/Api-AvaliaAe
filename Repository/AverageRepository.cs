using api_avaliaae.Data;
using api_avaliaae.Models;
using api_avaliaae.Repository.Interfaces;

namespace api_avaliaae.Repository
{
    public class AverageRepository : IAverageRepository
    {

        private readonly DatabaseContext _context;
        public AverageRepository(DatabaseContext context)
        {
            _context = context;
        }
        public Task<List<AverageModel>> GetAllAverages()
        {
            var result = _context.Average.ToList();
            return Task.FromResult(result);
        }
    }
}
