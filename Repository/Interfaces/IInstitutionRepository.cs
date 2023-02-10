using api_avaliaae.Models;

namespace api_avaliaae.Repository.Interfaces
{
    public interface IInstitutionRepository
    {
        Task<List<InstitutionModel>> getAllInstitutionsWithType();
    }
}
