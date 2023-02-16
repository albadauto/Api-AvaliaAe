using api_avaliaae.Models;

namespace api_avaliaae.Repository.Interfaces
{
    public interface IAvaliationRepository
    {
        Task<List<AvaliationModel>> getAllAvaliations();
        Task<List<AvaliationModel>> GetAvaliationByUserId(int userId);
    }
}
