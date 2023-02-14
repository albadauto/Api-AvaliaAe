using api_avaliaae.Models;

namespace api_avaliaae.Repository.Interfaces
{
    public interface IAverageRepository
    {
        Task<List<AverageModel>> GetAllAverages();
    }
}
