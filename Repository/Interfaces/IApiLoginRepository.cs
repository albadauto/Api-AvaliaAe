using api_avaliaae.Models;

namespace api_avaliaae.Repository.Interfaces
{
    public interface IApiLoginRepository
    {

        Task<ApiLoginModel> GetUserByEmailAndPassword(ApiLoginModel model);
    }
}
