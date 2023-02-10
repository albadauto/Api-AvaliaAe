using api_avaliaae.Models;

namespace api_avaliaae.Repository.Interfaces
{
    public interface IUserRepository
    {
       Task<List<UserModel>> getAllUsers();

    }
}
